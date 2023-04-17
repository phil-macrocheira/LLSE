using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LLSE
{
    public sealed class SaveFile
    {
        /// <summary>
        /// London Life save file size
        /// </summary>
        public const int SAVE_SIZE = 0xAFC;

        /// <summary>
        /// Offset to save data in file
        /// </summary>
        public const int SAVE_OFFSET = 0xF4AC;

        /// <summary>
        /// Path to the save file
        /// </summary>
        public string FilePath
        {
            get; // Any code can read it
            private set; // Only this class can edit it
        }

        /// <summary>
        /// In-memory save buffer
        /// </summary>
        private byte[] _saveBuffer;

        /// <summary>
        /// Initializes a new SaveFile class
        /// </summary>
        /// <param name="filePath">Path to the save file to read</param>
        public SaveFile(string filePath)
        {
            FilePath = filePath;
            _saveBuffer = new byte[SAVE_SIZE]; // Allocate London Life save buffer (we ignore non-London Life data)
            using (FileStream fs = File.OpenRead(filePath)) // Open file
            {
                fs.Seek(SAVE_OFFSET, SeekOrigin.Begin); // Skip unneeded data
                fs.Read(_saveBuffer, 0, SAVE_SIZE); // Read in save buffer
            }
        }

        // Methods to read data quickly
        public sbyte ReadSByte(int offset) => (sbyte)_saveBuffer[offset];
        public byte ReadByte(int offset) => _saveBuffer[offset];
        public short ReadShort(int offset) => BitConverter.ToInt16(_saveBuffer, offset);
        public ushort ReadUShort(int offset) => BitConverter.ToUInt16(_saveBuffer, offset);
        public int ReadInt(int offset) => BitConverter.ToInt32(_saveBuffer, offset);
        public uint ReadUInt(int offset) => BitConverter.ToUInt32(_saveBuffer, offset);
        public long ReadLong(int offset) => BitConverter.ToInt64(_saveBuffer, offset);

        public byte[] ReadArray(int offset, int size) => _saveBuffer.Skip(offset).Take(size).ToArray();

        // Methods to write data quickly
        public void Write(int offset, in byte[] data) => Buffer.BlockCopy(data, 0, _saveBuffer, offset, data.Length);
        public void Write(int offset, sbyte value) => _saveBuffer[offset] = (byte)value;
        public void Write(int offset, byte value) => _saveBuffer[offset] = value;
        public void Write(int offset, short value) => Write(offset, BitConverter.GetBytes(value));
        public void Write(int offset, ushort value) => Write(offset, BitConverter.GetBytes(value));
        public void Write(int offset, int value) => Write(offset, BitConverter.GetBytes(value));
        public void Write(int offset, uint value) => Write(offset, BitConverter.GetBytes(value));
        public void Write(int offset, long value) => Write(offset, BitConverter.GetBytes(value));

        /// <summary>
        /// Converts a row-column style location to an absolute offset.
        /// </summary>
        /// <param name="row">The row the data is on</param>
        /// <param name="column">The column the data is on</param>
        /// <returns>int absoluteOffset</returns>
        public static int HexOffset(string offset) => Convert.ToInt32(offset, 16);

        /// <summary>
        /// Saves the current save data to the original file.
        /// </summary>
        public void Save()
        {
            /* Repair save header first, then save */
            Checksum.RepairHeader(_saveBuffer);

            using (FileStream fs = File.OpenWrite(FilePath))
            {
                fs.Seek(SAVE_OFFSET, SeekOrigin.Begin);
                fs.Write(_saveBuffer, 0, _saveBuffer.Length);
            }
        }
        public string Scan(byte[] FindThis,int ExtraOffset)
        {
            for (int i = 27; i < _saveBuffer.Length-FindThis.Length; i++) {
                int found = 0;
                for (int j = 0; j < FindThis.Length; j++) {
                    if (_saveBuffer[i+j] == FindThis[j]) {
                        found++;
                    }
                    else { break; }
                }
                if (found == FindThis.Length)
                {
                    return (i + ExtraOffset).ToString("X");
                }
            }
            return "ERROR";
        }
    }
}

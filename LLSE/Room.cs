using System;
using System.Linq;
using System.Collections.Generic;

namespace LLSE
{
    public class Room
    {
        public SaveFile save;
        public List<string> RoomItems = new List<string>();
        public List<byte> RoomPositionX = new List<byte>();
        public List<byte> RoomPositionY = new List<byte>();
        public List<byte> RoomRotations = new List<byte>();
        public string RoomFloor;
        public string RoomWall;
        public string Roommate;
        public int RoomSize;
        ItemList itemlist = new ItemList();
        RoommateList roommatelist = new RoommateList();

        public bool GetRoomData()
        {
            byte[] QuestDataStart = { 160, 148, 82 };
            string RoomOffset = save.Scan(QuestDataStart, 157);

            if (RoomOffset == "ERROR") {return false;}

            string FloorOffset = (Convert.ToInt32(RoomOffset, 16) + 1).ToString("X");
            string WallOffset = (Convert.ToInt32(RoomOffset, 16) + 5).ToString("X");
            string ItemOffset = (Convert.ToInt32(RoomOffset, 16) + 9).ToString("X");

            byte[] RoommateData = save.ReadArray(SaveFile.HexOffset(RoomOffset),2);
            Array.Reverse(RoommateData, 0, RoommateData.Length);
            string RoommateBinary = string.Join("",
                RoommateData.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));
            RoommateBinary = RoommateBinary.Substring(4, 7);

            if (RoommateBinary.Length == 0) { return false; }
            while (RoommateBinary[0] == '0')
            {
                RoommateBinary = RoommateBinary.Remove(0, 1);
                if (RoommateBinary.Length == 0) { return false; }
            }
            
            Roommate = roommatelist.Roommates[RoommateBinary];
            //Console.WriteLine(Roommate);

            RoomSize = 180; // WHERE IS HOUSE SIZE STORED?

            byte[] RoomFloorData = save.ReadArray(SaveFile.HexOffset(FloorOffset),2);
            Array.Reverse(RoomFloorData,0,RoomFloorData.Length);
            string FloorBinary = string.Join("",
                RoomFloorData.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));
            FloorBinary = FloorBinary.Substring(2, 10);
            FloorBinary = FloorBinary.Remove(FloorBinary.Length-1,1);
            while (FloorBinary[0] == '0')
            {
                FloorBinary = FloorBinary.Remove(0, 1);
            }
            //Console.WriteLine(FloorBinary);
            RoomFloor = itemlist.Items[FloorBinary];
            //Console.WriteLine(RoomFloor);

            byte[] RoomWallData = save.ReadArray(SaveFile.HexOffset(WallOffset), 2);
            Array.Reverse(RoomWallData, 0, RoomWallData.Length);
            string WallBinary = string.Join("",
                RoomWallData.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));
            WallBinary = WallBinary.Substring(2, 10);
            WallBinary += '1';
            while (WallBinary[0] == '0')
            {
                WallBinary = WallBinary.Remove(0, 1);
            }
            //Console.WriteLine(WallBinary);
            RoomWall = itemlist.Items[WallBinary];
            //Console.WriteLine(RoomWall);

            byte[] RoomData = save.ReadArray(SaveFile.HexOffset(ItemOffset),RoomSize);
            Array.Reverse(RoomData,0,RoomData.Length);
            string BinaryArray = string.Join("",
                RoomData.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));
            ParseBinaryArray(BinaryArray);
            return true;
        }
        public void ParseBinaryArray(string BinaryArray)
        {
            byte Rotation;
            byte Y;
            byte X;
            string ItemBinary;
            string ItemName;

            for (int i = 0; i < RoomSize*8; i=i+30)
            {
                string item = BinaryArray.Substring(i, 30);
                if (Convert.ToInt32(item,2) != 0)
                {
                    Rotation = Convert.ToByte(BinaryArray.Substring(i+1,2),2);
                    RoomRotations.Add(Rotation);

                    Y = Convert.ToByte(BinaryArray.Substring(i + 5, 6), 2);
                    RoomPositionY.Add(Y);

                    X = Convert.ToByte(BinaryArray.Substring(i + 13, 6), 2);
                    RoomPositionX.Add(X);

                    ItemBinary = BinaryArray.Substring(i + 19, 10);
                    //Console.WriteLine(ItemBinary);
                    ItemName = itemlist.Items[ItemBinary];
                    RoomItems.Add(ItemName);

                    //Console.WriteLine(ItemName);
                    //Console.WriteLine(X);
                    //Console.WriteLine(Y);
                    //Console.WriteLine(Rotation);
                }
            }
            return;
        }
    }
}

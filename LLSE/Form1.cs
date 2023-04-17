using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LLSE
{
    public partial class Form1 : Form
    {
        private SaveFile save = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void wealth_text_Click(object sender, EventArgs e) { }

        private void open_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Open Save File",
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                save = new SaveFile(openFileDialog1.FileName);
                LoadSave(); // Load the save's data
            }
        }

        private void LoadSave()
        {
            string Month = GetMonth();
            byte Day = GetDay();
            int Happiness = GetHappiness();
            int Wealth = GetWealth();
            string Gender = GetGender();
            string HairColor = GetHairColor();
            int SkinTone = GetSkinTone();
            string Hairstyle = GetHairstyle();
            string Expression = GetExpression();
            
            Room room = new Room();
            room.save = save;
            bool RoomError = room.GetRoomData();
            if (RoomError == false)
            {
                MessageBox.Show("This save file is invalid. " +
                    "Try finishing all grapevine and ongoing quests and trying again.", "Invalid Save");
                return;
            }
            
            List<string> RoomItems = room.RoomItems;
            List<byte> RoomPositionX = new List<byte>();
            List<byte> RoomPositionY = new List<byte>();
            List<byte> RoomRotations = new List<byte>();
            string Roommate = room.Roommate;
            
            month_box.Text = Month;
            day_box.Text = Day.ToString();
            health_box.Text = Happiness.ToString();
            wealth_box.Text = Wealth.ToString();
            GenderBox.Text = Gender;
            HairColorBox.Text = HairColor;
            SkinToneBox.Text = SkinTone.ToString();
            HairstyleBox.Text = Hairstyle;
            ExpressionBox.Text = Expression;

            RoommateText.Text = "Roommate: " + Roommate;
            RoomText.Text = "Room Items:\n\n" + string.Join("\n",RoomItems);
        }

        private string GetMonth()
        {
            byte month = save.ReadByte(SaveFile.HexOffset("8")); // read current month byte
            switch (month)
            {
                case 1: return "January";
                case 2: return "February";
                case 3: return "March";
                case 4: return "April";
                case 5: return "May";
                case 6: return "June";
                case 7: return "July";
                case 8: return "August";
                case 9: return "September";
                case 10: return "October";
                case 11: return "November";
                case 12: return "December";
                default: return "January";
            }
        }

        private byte GetMonthUI()
        {
            switch(month_box.Text)
            {
                case "January": return 1;
                case "February": return 2;
                case "March": return 3;
                case "April": return 4;
                case "May": return 5;
                case "June": return 6;
                case "July": return 7;
                case "August": return 8;
                case "September": return 9;
                case "October": return 10;
                case "November": return 11;
                case "December": return 12;
                default: return 1;
            }
        }
        private byte GetDay()
        {
            return save.ReadByte(SaveFile.HexOffset("9")); // Load UI Current Date
        }
        private int GetHappiness()
        {
            return save.ReadInt(SaveFile.HexOffset("C")); // Load UI Happiness
        }
        private int GetWealth()
        {
            return save.ReadInt(SaveFile.HexOffset("10")); // Load UI Wealth
        }
        private string GetGender()
        {
            byte gender = save.ReadByte(SaveFile.HexOffset("14")); // Load UI Gender
            if (gender == 1) return "Male";
            else return "Female";
        }
        private byte GetGenderUI()
        {
            switch (GenderBox.Text)
            {
                case "Male": return 1;
                case "Female": return 2;
                default: return 2;
            }
        }
        private string GetHairColor()
        {
            byte haircolor = save.ReadByte(SaveFile.HexOffset("15")); // Load UI Hair Color
            switch (haircolor)
            {
                case 0: return "Caramel Brown";
                case 1: return "Whip White";
                case 2: return "Ash Gray";
                case 3: return "Jet Black";
                case 4: return "Chestnut Brown";
                case 5: return "Cocoa Brown";
                case 6: return "Honey Blonde";
                case 7: return "Tomato Red";
                case 8: return "Ocean Blue";
                case 9: return "Tangerine";
                case 10: return "Grass Green";
                default: return "Caramel Brown";
            }
        }
        private byte GetHairColorUI()
        {
            switch (HairColorBox.Text)
            {
                case "Caramel Brown": return 0;
                case "Whip White": return 1;
                case "Ash Gray": return 2;
                case "Jet Black": return 3;
                case "Chestnut Brown": return 4;
                case "Cocoa Brown": return 5;
                case "Honey Blonde": return 6;
                case "Tomato Red": return 7;
                case "Ocean Blue": return 8;
                case "Tangerine": return 9;
                case "Grass Green": return 10;
                default: return 0;
            }
        }
        private int GetSkinTone()
        {
            return save.ReadByte(SaveFile.HexOffset("16")) + 1; // Load UI Skin Tone
        }
        private byte GetSkinToneUI()
        {
            return Decimal.ToByte(SkinToneBox.Value - 1);
        }
        private string GetHairstyle()
        {
            byte hairstyle = save.ReadByte(SaveFile.HexOffset("1C")); // Load UI Hairstyle
            switch (hairstyle)
            {
                case 142: return "Floppy Hair";
                case 143: return "Mohawk";
                case 144: return "Flattop";
                case 145: return "Pompadour";
                case 146: return "Mullet";
                case 147: return "Sideburns";
                case 148: return "Traditional";
                case 149: return "Pixie Cut";
                case 150: return "Long Locks";
                case 151: return "Pigtails";
                case 152: return "Inverted Bob";
                case 154: return "Shoulder Length";
                case 155: return "Long & Silky";
                case 157: return "Bowl Cut";
                case 160: return "Trendy Cut";
                default: return "Bowl Cut";
            }
        }
        private byte GetHairstyleUI()
        {
            switch (HairstyleBox.Text)
            {
                case "Floppy Hair": return 142;
                case "Mohawk": return 143;
                case "Flattop": return 144;
                case "Pompadour": return 145;
                case "Mullet": return 146;
                case "Sideburns": return 147;
                case "Traditional": return 148;
                case "Pixie Cut": return 149;
                case "Long Locks": return 150;
                case "Pigtails": return 151;
                case "Inverted Bob": return 152;
                case "Shoulder Length": return 154;
                case "Long & Silky": return 155;
                case "Bowl Cut": return 157;
                case "Trendy Cut": return 160;
                default: return 157;
            }
        }
        private string GetExpression()
        {
            byte expression = save.ReadByte(SaveFile.HexOffset("20")); // Load UI Expression
            switch (expression)
            {
                case 161: return "Neutral";
                case 162: return "McGrumpington";
                case 163: return "Determined";
                case 164: return "Elated";
                case 165: return "Sleepy";
                case 166: return "Smiley";
                case 167: return "Surprised";
                case 168: return "Shy";
                case 169: return "Mellow";
                case 170: return "Scaredy-Cat";
                case 171: return "Worrywart";
                case 172: return "Sternfaced";
                default: return "Neutral";
            }
        }
        private byte GetExpressionUI()
        {
            switch (ExpressionBox.Text)
            {
                case "Neutral": return 161;
                case "McGrumpington": return 162;
                case "Determined": return 163;
                case "Elated": return 164;
                case "Sleepy": return 165;
                case "Smiley": return 166;
                case "Surprised": return 167;
                case "Shy": return 168;
                case "Mellow": return 169;
                case "Scaredy-Cat": return 170;
                case "Worrywart": return 171;
                case "Sternfaced": return 172;
                default: return 161;
            }
        }
        private void SetDate()
        {
            byte month = GetMonthUI(); // Load UI Current Month
            save.Write(SaveFile.HexOffset("8"), month); // Set UI Month
            save.Write(SaveFile.HexOffset("9"), byte.Parse(day_box.Text)); // Set UI Day
        }
        private void SetHappinessAndWealth()
        {
            int Happiness = int.Parse(health_box.Text);
            int Wealth = int.Parse(wealth_box.Text);

            int HappinessOffset = ScanHappinessOffset(Happiness,Wealth);

            byte HappinessRemainder = GetRemainder(Happiness);
            byte WealthRemainder = GetRemainder(Wealth);

            save.Write(SaveFile.HexOffset("C"), Happiness); // Set UI Happiness
            save.Write(SaveFile.HexOffset("10"), Wealth); // Set UI Wealth

            // TO FIX: the UI health is current happiness, not max happiness.
            //save.Write(SaveFile.RawOffset(HappinessOffset-1), HappinessRemainder); // Set Happiness Remainder Byte
            //save.Write(SaveFile.RawOffset(HappinessOffset+6), WealthRemainder); // Set Wealth Remainder Byte

            //save.Write(SaveFile.RawOffset(HappinessOffset), Happiness); // Set Max Happiness
            //save.Write(SaveFile.RawOffset(HappinessOffset+7), Wealth); // Set Wealth
        }
        private int ScanHappinessOffset(int Happiness, int Wealth)
        {
            Happiness = Happiness / 8;
            Wealth = Wealth / 8;

            string HappinessHex = Happiness.ToString("X");
            string WealthHex = Wealth.ToString("X");

            //Console.WriteLine(HappinessHex);
            //Console.WriteLine(WealthHex);

            // scan for HappinessHex in SaveFile
            // if (HappinessHex found in SaveFile)
            //      then if (WealthHex found +7 bytes later)
            //           then return HappinessHex offset
            //      else exit program with error "Failed to find happiness and wealth in save file,
            //           likely due to a flaw in this program's logic"
            return 960;
        }
        private byte GetRemainder(int num)
        {
            num = num % 8;

            switch (num)
            {
                case 0: return 0;   // 00
                case 1: return 32;  // 20
                case 2: return 64;  // 40
                case 3: return 96;  // 60
                case 4: return 128; // 80
                case 5: return 160; // A0
                case 6: return 192; // C0
                case 7: return 224; // E0
                default: return 0;
            }
        }
        private void UpdateData()
        {
            SetDate();
            SetHappinessAndWealth();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateData();
            save?.Save();
            MessageBox.Show("London Life Save File Successfully Overwritten", "Save Complete");
        }
        private void date_text_Click(object sender, EventArgs e) {}
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {}
        private void day_text_Click(object sender, EventArgs e) {}

        private void label1_Click_1(object sender, EventArgs e) {}

        private void textBox1_TextChanged_1(object sender, EventArgs e) {}

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e) {}

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {}

        private void FaceText_Click(object sender, EventArgs e) {}

        private void HairText_Click(object sender, EventArgs e) {}

        private void TraitText_Click(object sender, EventArgs e) {}

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
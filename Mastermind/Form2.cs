using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace Mastermind
{
    
    public partial class Form2 : Form
    {
        public int numGameSlots;
        public int numofColors;
        public bool repeatColors;
        public bool EmptySpaces;
        public bool singlePlayerGame;
        public int NumTry;
        public bool computerGuesser;
        public List<string> AvailableColors;
        public Image[] AvailablePegPicture;
        private GameController GC;

        public Form2(bool tfNull, bool tfRepeats, int numColors, int numSlots, bool singlePlayerEnabled, bool compGuesser, int TryValue)
        {
            numGameSlots = numSlots;
            repeatColors = tfRepeats;
            EmptySpaces = tfNull;
            numofColors = numColors;
            singlePlayerGame = singlePlayerEnabled;
            computerGuesser = compGuesser;
            NumTry = TryValue;
            AvailableColors = new List<string>();
            AvailablePegPicture = new Image[numofColors];
            InitializeComponent();
            if (!computerGuesser)
            {
                MessageBox.Show("Please Input the sequence now Mastermind.");
            }
            TriesRemaining.Text = "Tries remaining: " + (NumTry).ToString();
        }
        private Button[] btns()
        {
            Button[] btnAry = { Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Slot7, Slot8, Slot9, Slot10 };
            return btnAry;
        }

        private Button[] pegs()
        {
            Button[] btnAry = { Peg1
                    , Peg2
                    , Peg3
                    , Peg4
                    , Peg5
                    , Peg6
                    , Peg7
                    , Peg8
                    , Peg9
                    , Peg10 };
            return btnAry;
        }
        private void availableColors()
        {
            Button[] pegsInPlay = pegs();
            for(int i = 0; i <numofColors; i++)
            {
                if(pegsInPlay[i].Enabled == true)
                {
                    AvailablePegPicture[i] = pegsInPlay[i].BackgroundImage;
                }
            }
        }

        private void availableColorsPic()
        {
            Button[] pegsInPlay = pegs();
            for (int i = 0; i < numofColors; i++)
            {
                if (pegsInPlay[i].Enabled == true)
                {
                    AvailableColors.Add(pegsInPlay[i].Tag.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nextSlot(Image pegImage, string colorTag)
        {
            Button[] btnAry = btns();
            bool SlotFound = true;
            int i = 0;
            do
            {
                if (btnAry[i].Tag.ToString() == "NoColor")
                {
                    btnAry[i].BackgroundImage = pegImage;
                    btnAry[i].Tag = colorTag;
                    SlotFound = false;
                }
                i++;
            } while (SlotFound && i <= numGameSlots);
            if(i>numGameSlots)
            {
                MessageBox.Show("The Slots are full either empty a slot or submit inquiry");
            }
        }
        private void submitFunction_Click(object sender, EventArgs e)
        {
            

            switch(GC.checkInput(InputValueText()))
            {
                case 0:
                    MessageBox.Show("Input breaks rules please reveiw the suggestion");
                    break;
                case 1:
                    ReturnGuesses.DataSource = GC.GetDT();
                    SetLabelRed(GC.getRedPegs());
                    SetLabelWhite(GC.getWhitePegs());
                    AdjustColumnWidth();
                    MessageBox.Show("Congrats you won!");
                    break;
                case 2:
                    ReturnGuesses.DataSource = GC.GetDT();
                    SetLabelRed(GC.getRedPegs());
                    SetLabelWhite(GC.getWhitePegs());
                    AdjustColumnWidth();
                    slotClearer();
                    TriesRemaining.Text = "Tries remaining: " + (NumTry - ReturnGuesses.RowCount+1).ToString();
                    if (ReturnGuesses.RowCount > NumTry)
                    {
                        string[] FailResponse = new string[1];
                        FailResponse[0] = "Failed";
                        GC.checkInput(FailResponse);
                        MessageBox.Show("Sorry you ran out of tries. last line has the answer");
                    }
                    break;
                case 3:
                    slotClearer();
                    MessageBox.Show("Please hand to guesser.");
                    break;
            }
                

        }

        public string[] InputValueText()
        {
            Button[] btnAry = btns();
            string[] UserValue = new string[numGameSlots];

            for (int i = 0; i < numGameSlots; i++)
            {
                UserValue[i] = btnAry[i].Tag.ToString();
            }
            return UserValue;
        }
        private void AdjustColumnWidth()
        {
            int l = ReturnGuesses.Columns.Count;
            for(int i = 0; i < l; i++)
            {
                
                ReturnGuesses.Columns[i].Width = 50;
            }
        }

        private void SetLabelRed(int CountValue)
        {
            string LabelValue = "Correct location amount = " + CountValue.ToString();
            RightLocationRightColor.Text = LabelValue;
        }

        private void SetLabelWhite(int CountValue)
        {
            string LabelValue = "Correct color amount = " + CountValue.ToString();
            RightColorWrongLocation.Text = LabelValue;
        }
        public void slotClearer()
        {
            Button[] btnSection = btns();
            for (int i = 0; i< btnSection.Length;i++)
            {
                btnSection[i].Tag = "NoColor";
                btnSection[i].BackgroundImage = null;
            }
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyValue)
            {
                //peg1
                case 97:
                    if (Peg1.Enabled)
                    {
                        nextSlot(Peg1.BackgroundImage, Peg1.Tag.ToString());
                    }
                    break;
                case 49:
                    if (Peg1.Enabled)
                    {
                        nextSlot(Peg1.BackgroundImage, Peg1.Tag.ToString());
                    }
                    break;
                //peg2
                case 98:
                    if (Peg2.Enabled)
                    {
                        nextSlot(Peg2.BackgroundImage, Peg2.Tag.ToString());
                    }
                    break;
                case 50:
                    if (Peg2.Enabled)
                    {
                        nextSlot(Peg2.BackgroundImage, Peg2.Tag.ToString());
                    }
                    break;
                //peg3
                case 99:
                    if (Peg3.Enabled)
                    {
                        nextSlot(Peg3.BackgroundImage, Peg3.Tag.ToString());
                    }
                    break;      
                case 51:
                    if (Peg3.Enabled)
                    {
                        nextSlot(Peg3.BackgroundImage, Peg3.Tag.ToString());
                    }
                    break;
                //peg4
                case 100:
                    if (Peg4.Enabled)
                    {
                        nextSlot(Peg4.BackgroundImage, Peg4.Tag.ToString());
                    }
                    break;
                case 52:
                    if (Peg4.Enabled)
                    {
                        nextSlot(Peg4.BackgroundImage, Peg4.Tag.ToString());
                    }
                    break;
                //peg5
                case 101:
                    if (Peg5.Enabled)
                    {
                        nextSlot(Peg5.BackgroundImage, Peg5.Tag.ToString());
                    }
                    break;
                case 53:
                    if (Peg5.Enabled)
                    {
                        nextSlot(Peg5.BackgroundImage, Peg5.Tag.ToString());
                    }
                    break;
                //peg6
                case 102:
                    if (Peg6.Enabled)
                    {
                        nextSlot(Peg6.BackgroundImage, Peg6.Tag.ToString());
                    }
                    break;
                case 54:
                    if (Peg6.Enabled)
                    {
                        nextSlot(Peg6.BackgroundImage, Peg6.Tag.ToString());
                    }
                    break;
                //peg7
                case 103:
                    if (Peg7.Enabled)
                    {
                        nextSlot(Peg7.BackgroundImage, Peg7.Tag.ToString());
                    }
                    break;
                case 55:
                    if (Peg7.Enabled)
                    {
                        nextSlot(Peg7.BackgroundImage, Peg7.Tag.ToString());
                    }
                    break;
                //peg8
                case 104:
                    if (Peg8.Enabled)
                    {
                        nextSlot(Peg8.BackgroundImage, Peg8.Tag.ToString());
                    }
                    break;
                case 56:
                    if (Peg8.Enabled)
                    {
                        nextSlot(Peg8.BackgroundImage, Peg8.Tag.ToString());
                    }
                    break;
                //peg9
                case 105:
                    if (Peg9.Enabled)
                    {
                        nextSlot(Peg9.BackgroundImage, Peg9.Tag.ToString());
                    }
                    break;
                case 57:
                    if (Peg9.Enabled)
                    {
                        nextSlot(Peg9.BackgroundImage, Peg9.Tag.ToString());
                    }
                    break;
                //peg10
                case 106:
                    if (Peg10.Enabled)
                    {
                        nextSlot(Peg10.BackgroundImage, Peg10.Tag.ToString());
                    }
                    break;
                case 58:
                    if (Peg10.Enabled)
                    {
                        nextSlot(Peg10.BackgroundImage, Peg10.Tag.ToString());
                    }
                    break;


            }
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            Button[] clrs = pegs();
            Button[] slts = btns();
            

            for (int i = 0; i <10; i++)
            {
                if(i<numGameSlots)
                {
                    slts[i].Enabled = true;
                    slts[i].Visible = true;
                }
                if(i<numofColors)
                {
                    clrs[i].Enabled = true;
                    clrs[i].Visible = true;
                }
            }
            availableColors();
            availableColorsPic();

            if (GC == null)
            {
                GC = new GameController(AvailableColors, AvailablePegPicture, this);
            }
        }
        #region Pegs

        private void Peg1_Click(object sender, EventArgs e)
        {

            nextSlot(Peg1.BackgroundImage, Peg1.Tag.ToString());
        }

        private void Peg2_Click(object sender, EventArgs e)
        {
            nextSlot(Peg2.BackgroundImage, Peg2.Tag.ToString());
        }

        private void Peg3_Click(object sender, EventArgs e)
        {
            nextSlot(Peg3.BackgroundImage, Peg3.Tag.ToString());
        }

        private void Peg4_Click(object sender, EventArgs e)
        {
            nextSlot(Peg4.BackgroundImage, Peg4.Tag.ToString());
        }

        private void Peg5_Click(object sender, EventArgs e)
        {
            nextSlot(Peg5.BackgroundImage, Peg5.Tag.ToString());
        }

        private void Peg6_Click(object sender, EventArgs e)
        {
            nextSlot(Peg6.BackgroundImage, Peg6.Tag.ToString());
        }

        private void Peg7_Click(object sender, EventArgs e)
        {
            nextSlot(Peg7.BackgroundImage, Peg7.Tag.ToString());
        }

        private void Peg8_Click(object sender, EventArgs e)
        {
            nextSlot(Peg8.BackgroundImage, Peg8.Tag.ToString());

        }

        private void Peg9_Click(object sender, EventArgs e)
        {
            nextSlot(Peg9.BackgroundImage, Peg9.Tag.ToString());

        }

        private void Peg10_Click(object sender, EventArgs e)
        {
            nextSlot(Peg10.BackgroundImage, Peg10.Tag.ToString());
        }
        #endregion
        #region Slots

        private void Slot1_Click(object sender, EventArgs e)
        {
            Slot1.BackgroundImage = null;
            Slot1.Tag = "NoColor";
        }

        private void Slot2_Click(object sender, EventArgs e)
        {
            Slot2.BackgroundImage = null;
            Slot2.Tag = "NoColor";
        }

        private void Slot3_Click(object sender, EventArgs e)
        {
            Slot3.BackgroundImage = null;
            Slot3.Tag = "NoColor";
        }

        private void Slot4_Click(object sender, EventArgs e)
        {
            Slot4.BackgroundImage = null;
            Slot4.Tag = "NoColor";
        }

        private void Slot5_Click(object sender, EventArgs e)
        {
            Slot5.BackgroundImage = null;
            Slot5.Tag = "NoColor";
        }

        private void Slot6_Click(object sender, EventArgs e)
        {
            Slot6.BackgroundImage = null;
            Slot6.Tag = "NoColor";
        }

        private void Slot7_Click(object sender, EventArgs e)
        {
            Slot7.BackgroundImage = null;
            Slot7.Tag = "NoColor";
        }

        private void Slot8_Click(object sender, EventArgs e)
        {
            Slot8.BackgroundImage = null;
            Slot8.Tag = "NoColor";
        }

        private void Slot9_Click(object sender, EventArgs e)
        {
            Slot9.BackgroundImage = null;
            Slot9.Tag = "NoColor";
        }

        private void Slot10_Click(object sender, EventArgs e)
        {
            Slot10.BackgroundImage = null;
            Slot10.Tag = "NoColor";
        }
        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    
    class MastermindPuzzleCreator
    {
        private string[] Colors;
        private bool rptclrs;
        private int slots;
        private int clrs;

        public void setAnswer(int numSlots, bool tfRepeats,  bool tfNull, int numColors, string[] ColorList, AnswerSection answr)
        {
            rptclrs = tfRepeats;
            slots = numSlots;
            
            Colors = ColorList;
            if (tfNull == true)
            {
                clrs = numColors+1;
            }
            else
            {
                clrs = numColors;
            }
            answr.setAnswer(setClrPegs());

        }

        private string[] setClrPegs()
        {
            List<string> colorList = new List<string>();
            string Color;
            bool paramCheck = false;
            
            for (int i = 0; i < slots; i++)
            {
                do
                {
                    Random random = new Random();
                    int num = random.Next(clrs);
                    if (num > Colors.Length)
                    {
                        Color = "";
                    }
                    else
                    {
                        Color = Colors[num];
                    }

                    if (!rptclrs)
                    {
                        if(!colorList.Contains(Color))
                        {
                            paramCheck = true;
                        }
                    }else
                    {
                        paramCheck = true;
                    }
                } while (!paramCheck);
                colorList.Add(Color);
                paramCheck = false;
            }
            return colorList.ToArray();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public class AnswerSection
    {
        private string[] hiddenAnswer;
        public bool AnswerSet;

        public AnswerSection()
        {
            AnswerSet = false;
        }
        public string[] getAnswer()
        {
            return hiddenAnswer;
        }

        public void setAnswer(string[] input)
        {
            if(AnswerSet == false)
            {
                hiddenAnswer = input;
                AnswerSet = true;
            }
        }
        public bool checkAnswer(string[] input)
        {
            bool checkValue = true;
            if(AnswerSet)
            {
                for(int i = 0; i<hiddenAnswer.Length;i++)
                {
                    if(hiddenAnswer[i]!=input[i])
                    {
                        checkValue = false;
                    }
                }
            }
            else
            {
                checkValue = false;
            }
            AnswerSet = !checkValue;
            return checkValue;
        }

        public int[] RedPegsWhitePegs(string[] input)
        {
            int[] pegCounts = new int[2];
            int[] tempValue = correctLocations(input);
            pegCounts[0] = tempValue.Length;
            pegCounts[1] = CorrectColors(input, tempValue);

            return pegCounts;
        }

        private int[] correctLocations(string[] input)
        {
            List<int> amntRight = new List<int>();

            for (int i = 0; i < hiddenAnswer.Length; i++)
            {
                if(hiddenAnswer[i] == input[i])
                {
                    amntRight.Add(i);
                }
            }

            return amntRight.ToArray();
        }

        private int CorrectColors(string[] input, int[] usedAnswers)
        {
            bool alreadyUsed = false;
            List<int> amntUsed = new List<int>();
            List<int> amntRight = new List<int>();
            for(int i = 0; i < usedAnswers.Length; i++)
            {
                amntUsed.Add(usedAnswers[i]);
            }

            for(int i = 0; i < input.Length;i++)
            {
                if(amntUsed.Contains(i))
                {
                    alreadyUsed = true;
                }
                if(alreadyUsed ==false)
                {
                    for(int j = 0; j <hiddenAnswer.Length;j++)
                    {
                        if(input[i]==hiddenAnswer[j]&& amntRight.Contains(j)!=true)
                        {
                            amntRight.Add(j);
                        }
                    }
                }
                alreadyUsed = false;
            }

            return amntRight.Count;
        }
    }
}

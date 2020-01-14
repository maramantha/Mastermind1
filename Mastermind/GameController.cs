using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Mastermind
{
    class GameController
    {

        private AnswerSection Answer = new AnswerSection();
        private StoreAnswers SA = new StoreAnswers();
        private MastermindPuzzleCreator mster = new MastermindPuzzleCreator();
        private List<string> colorsAvailable = new List<string>();
        private Image[] pictureList;
        private int WhitePegs;
        private int RedPegs;
        private Form2 HolderValue;

        public int getRedPegs()
        {
            return RedPegs;
        }

        public int getWhitePegs()
        {
            return WhitePegs;
        }

        private void setRedPegs(int rp)
        {
            RedPegs = rp;
        }

        private void setWhitePegs(int wp)
        {
            WhitePegs = wp;
        }

        public GameController(List<string> colors, Image[] pictures, Form2 sharedItem)
        {
            colorsAvailable = colors;
            pictureList = pictures;
            HolderValue = sharedItem;
        }

        public void StartGame()
        {
            if (HolderValue.computerGuesser)
            {
                mster.setAnswer(HolderValue.numGameSlots
                    , HolderValue.repeatColors
                    , HolderValue.EmptySpaces
                    , HolderValue.numofColors
                    , HolderValue.AvailableColors.ToArray()
                    , Answer);

            }
        }

        private bool EmptyCheck(string[] btnSection)
        {
            bool checkValue = true;
            if (HolderValue.EmptySpaces == false)
            {
                for (int i = 0; i < HolderValue.numGameSlots; i++)
                {
                    if (btnSection[i] == "NoColor")
                    {
                        checkValue = false;
                    }
                }
            }
            return checkValue;
        }
        private bool repeatCheck(string[] btnSection)
        {
            bool checkValue = true;
            if (HolderValue.repeatColors == false)
            {
                for (int i = 0; i < HolderValue.numGameSlots - 1; i++)
                {
                    for (int j = i + 1; j < HolderValue.numGameSlots; j++)
                    {
                        if (btnSection[i] == btnSection[j])
                        {
                            checkValue = false;
                        }
                    }
                }
            }
            return checkValue;
        }

        public DataTable GetDT()
        {
            return SA.dt;
        }

        private Image[] UserPictures(string[] userColors)
        {
            Image[] uPicture = new Image[userColors.Length];
            for(int i = 0; i < userColors.Length;i++)
            {
                int j = 0;
                while (colorsAvailable[j] != userColors[i])
                {

                    j++;
                }
                uPicture[i] = pictureList[j];
            }

            return uPicture;
        }

        public int checkInput(string[] GuessSet)
        {
            int rValue = 0;
            if (GuessSet[0] == "Failed"||EmptyCheck(GuessSet) && repeatCheck(GuessSet))
            {
                
                
                if (GuessSet[0] != "Failed")
                {
                    Image[] userPicture = UserPictures(GuessSet);
                    StartGame();
                
                    if (Answer.AnswerSet)
                    {
                        int[] correctValues = Answer.RedPegsWhitePegs(GuessSet);

                        setRedPegs(correctValues[0]);
                        setWhitePegs(correctValues[1]);

                        SA.StoreGuess(userPicture, correctValues[0], correctValues[1], GuessSet);
                        if (Answer.checkAnswer(GuessSet))
                        {
                            SA.DeleteOldSet();
                            rValue = 1;
                        }
                        else
                        {
                            
                            rValue = 2;

                        }
                    }
                    else
                    {
                        Answer.setAnswer(GuessSet);
                        rValue = 3;
                    }

                }
                else
                {
                    Image[] userPicture = UserPictures(Answer.getAnswer());
                    userPicture = UserPictures(Answer.getAnswer());
                    SA.StoreGuess(userPicture, 4, 0, Answer.getAnswer());
                }
            }
            
            return rValue;
            
        }

        
    }
}

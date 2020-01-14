using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Board
    {
        public string slot1;
        public string slot2;
        public string slot3;
        public string slot4;
        public string slot5;
        public string slot6;
        public string slot7;
        public string slot8;
        public string slot9;
        public string slot10;
        public int RightLocRightCol;
        public int WrongLocRightCol;

        public Board(string s1, string s2, string s3, string s4, int RCnum, int RLnum, string s5 = "", string s6 = "", string s7 = "", string s8 = "", string s9 = "", string s10 = "")
        {
            slot1 = s1;
            slot2 = s2;
            slot3 = s3;
            slot4 = s4;
            slot5 = s5;
            slot6 = s6;
            slot7 = s7;
            slot8 = s8;
            slot9 = s9;
            slot10 = s10;
            RightLocRightCol = RCnum;
            WrongLocRightCol = RLnum;
        }
    }
}

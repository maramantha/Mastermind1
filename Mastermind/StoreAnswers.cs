using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.Work.WebApi;
using Newtonsoft.Json;

namespace Mastermind
{
    class StoreAnswers
    {
        public string GuessJson;
        public DataTable dt;

        public StoreAnswers()
        {
            dt = new DataTable();
        }
        public void StoreGuess(Image[] s1,int RCnum, int RLnum, string[] sColor)
        {
            for (int i = 0; i < sColor.Length;i++)
            {
                if (!(sColor[i] == ""))
                {
                    int alph = i + 1;
                    buildDataTable("Peg" + alph.ToString());
                }
            }
            buildDataTable("White");
            buildDataTable("Red");

            loadDT(s1, RCnum, RLnum);

            GuessJson = JsonConvert.SerializeObject(dt);

        }

        private void loadDT(Image[] Pegs, int RCnum, int RLnum)
        {
            string loc = "Peg";
            var row = dt.NewRow();
            for(int i = 0; i<Pegs.Length; i++)
            {
                    string obj = loc + (i + 1).ToString();
                
                    row[obj] = Pegs[i];
            }
            row["White"] = RLnum;
            row["Red"] = RCnum;

            dt.Rows.Add(row);
            
        }


        private void buildDataTable(string pegCheck)
        {

                if(!dt.Columns.Contains(pegCheck))
                {
                    if(pegCheck.Contains("Peg"))
                {
                    dt.Columns.Add(pegCheck,typeof(Image));
                }
                    else
                {
                    dt.Columns.Add(pegCheck);
                }
                    
                }
        }

        public void DeleteOldSet()
        {
            if(File.Exists(path()))
            {
                File.Delete(path());
            }
        }

        public string path()
        {
            return @"C:\Users\natha\Documents\Mastermind.json";
        }

    }
}

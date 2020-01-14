using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Mastermind
{
    class ShowGuesses
    {
        //DataTable DT;
        StoreAnswers answers = new StoreAnswers();

        public DataTable buildDT()
        {
            DataTable dtValue;
            string o1;
            // read JSON directly from a file
            using (StreamReader file = File.OpenText(answers.path()))
            using (JsonTextReader reader = new JsonTextReader(file))
            {

                JObject o2 = (JObject)JToken.ReadFrom(reader);
                o1 = @o2.ToString();
                dtValue = (DataTable)JsonConvert.DeserializeObject(o1, (typeof(DataTable)));
            }
            string json = @"[{""ID"":1,""bookingID"":1,""Schema"":""10:00 Welcom""},"
                            + @"{""ID"":2,""bookingID"":1,""Schema"":""12:00 Lunch""},"
                            + @"{""ID"":3,""bookingID"":1,""Schema"":""15:00 coffee break""},"
                            + @"{""ID"":null,""bookingID"":null,""Schema"":""null""}]";
            
            return dtValue;
        }

        
    }
}

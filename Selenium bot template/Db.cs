using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_bot_template
{
    public static class DB
    {
        public class Settings
        {
            public int Id { get; set; }
            public bool UseProxy { get; set; }
            public string Proxy { get; set; }
        }

        public static void LoadSettings()
        {
            using (var db = new LiteDatabase(@"BotData.db"))
            {
                var settings = db.GetCollection<Settings>("Settings");
                //

            }
        }

    }
}

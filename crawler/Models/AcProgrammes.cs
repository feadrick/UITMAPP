using System;
using System.Collections.Generic;
using System.Text;

namespace crawler.Models
{
    public class AcProgrammes
    {
       public string programme_name { get; set; }
       public string programme_code { get; set; }
       public string programme_link { get; set; }

        public AcProgrammes() {
            this.programme_name = "";
            this.programme_code = "";
            this.programme_link = "";
        }
        public AcProgrammes(string name, string code, string link) {
            this.programme_name = name;
            this.programme_code = code;
            this.programme_link = link;
        }
    }
}

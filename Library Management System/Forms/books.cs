using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Forms
{
    class books
    {
        public string ID { get; set; }
        public string name { get; set; }
        public string author { get; set; }

        public books(string iD, string name, string author)
        {
            ID = iD;
            this.name = name;
            this.author = author;
        }
    }
}

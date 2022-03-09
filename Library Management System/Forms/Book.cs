using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Forms
{
    class Book
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public Book(string iD, string name, string author)
        {
            ID = iD;
            Name = name;
            Author = author;
        }
    }
}

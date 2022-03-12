﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Forms
{
    class Issue
    {
        public string StudName { get; set; }
        public string StudClass { get; set; }
        public string BookName { get; set; }
        public string BookID { get; set; }

        public Issue(string studName, string studClass, string bookName, string bookID)
        {
            StudName = studName;
            StudClass = studClass;
            BookName = bookName;
            BookID = bookID;
        }
    }
}

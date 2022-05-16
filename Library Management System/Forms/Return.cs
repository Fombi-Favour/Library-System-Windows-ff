using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Forms
{
    class Return
    {
        public string StudName { get; set; }
        public string StudClass { get; set; }
        public string BookName { get; set; }
        public string BookID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Return(string studName, string studClass, string bookName, string bookID, DateTime issueDate, DateTime returnDate)
        {
            StudName = studName;
            StudClass = studClass;
            BookName = bookName;
            BookID = bookID;
            IssueDate = issueDate;
            ReturnDate = returnDate;
        }
    }
}

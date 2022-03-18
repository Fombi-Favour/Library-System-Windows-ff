using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserLoginCache
    {
        public static int userID { get; set; }
        public static string School { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
    }
}

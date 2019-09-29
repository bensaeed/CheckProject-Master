using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueCheck.View
{
    class UserData
    {
        //C_Operation objOperation = new C_Operation();
        //public UserData()
        //{
        //    var user = objOperation.ALLUsers();
        //    if (user == null) return;
        //    //var enumerable = user as IList<Users> ?? user.ToList();
        //    var enumerable = user.ToList();

        //    ID   = enumerable.Where(c => c.GetType == "ID")
        //       .Select(c => c.Value).Single();
        //}
        public static int ID { get; set; }
        public static string LoginName { get; set; }
        public static string Firstname { get; set; }
        public static string LastName { get; set; } 
   
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazzydior.BusinessClass
{
    public class UserAccount
    {
        public int UserID { get; set;}
        public string UserFName { get; set;}
        public string UserLName { get; set; }
        public int UserPositionID { get; set;}
        public string UserStatus { get; set;}
        public string Username { get; set;}
        public string UserPassword { get; set;}
        public DateTime UserDateCreated { get; set; }
    }
}

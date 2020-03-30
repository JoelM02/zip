using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class LoginUSer
    {
        //declare properties 
        public string username { get; set; }
        public string password { get; set; }


        //ini
        public LoginUSer(string user1, string pass1)
        {
            this.username = user1;
            this.password = pass1;
        }

      
    }
}

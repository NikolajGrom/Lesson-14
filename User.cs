using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lesson_14
{
    public class User
    {
        public string Login { get; set; }
        public int Passvord { get; set; }
        public string Email { get; set; }




        public User(string Login, int Passvord, string Email)
        {
            this.Login = Login;
            this.Passvord = Passvord;
            this.Email = Email;


        }
        public override string ToString()
        {
            return String.Format("Login {0} \n  Passvord {1} \n  Email {2} \n",
                                  this.Login, this.Passvord, this.Email);
        }

    }
} 
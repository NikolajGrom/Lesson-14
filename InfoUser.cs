using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    public class InfoUser : User
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string MiddleName { get; set; }
        public InfoUser() : base("Login", 123, "Email")
        {
                
        }
        public InfoUser(int Age, string Name, string SurName, string MiddleName) : base ("Login", 123, "Email")
        {
            this.Age = Age;
            this.Name = Name;
            this.SurName = SurName;
            this.MiddleName = MiddleName;
        }

        public override string ToString()
        {
            return base.ToString() + ($" \n Age {0} \n Name {1} \n SurName {2} \n MiddleName {3} ",
                                    this.Age, this.Name, this.SurName, this.MiddleName);
        }



    }
}
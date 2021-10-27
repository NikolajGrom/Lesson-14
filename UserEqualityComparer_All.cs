using Lesson_14;
using System;
using System.Collections.Generic;
using System.Linq;
class UserEqualityComparer_All : IEqualityComparer<InfoUser>
    {
        public bool Equals(InfoUser b1, InfoUser b2)
        {
            if(b1.Age != b2.Age)
                return false;
            if(b1.Email != b2.Email)
                return false;
            if(b1.Login != b2.Login)
                return false;
            if(b1.Passvord != b2.Passvord)
                return false;
                if(b1.Name != b2.Name)
                return false;
            if(b1.SurName != b2.SurName)
                return false;
            if(b1.MiddleName != b2.MiddleName)
                return false;


            return true;
        }

        public int GetHashCode(InfoUser bx)
        {
            int hCode = bx.Login.Length + bx.Passvord;
            return hCode.GetHashCode();
        }
    }
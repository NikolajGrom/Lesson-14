using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_14
{
    public class MySistem<T> : List<InfoUser>, IDisposable
    {
        public void MySistemAdd( InfoUser infoUser)
        {
             base.Add(infoUser);
        }
        //public void MySistemFindAll()
        //{

        //}
        public bool MySistemRemove(InfoUser infoUser)
        {
            infoUser = new InfoUser();
            for (var i = 0; i < this.Count(); i++)
            {
                if (this[i].Passvord == infoUser.Passvord && this[i].Login == infoUser.Login)
                {
                    infoUser = this[i];
                    base.Remove(infoUser);
                    return true;
                }
            }
            return true;
        }
    

        //public void MySistemClear()
        //{

        //}

        public void Dispose()
        {
            for (int i = 0; i < this.Count(); i++)
                GC.Collect(GC.GetGeneration(this[i]));
        }
        //public override string ToString()
        //{
        //    return base.ToString();
        //}

    }
}
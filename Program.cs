using System;
using System.Collections.Generic;
using System.Linq;



namespace Lesson_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User");

            MySistem<InfoUser> us = new MySistem<InfoUser>();

            us.MySistemAdd(new InfoUser
            {
                Age = 21,
                Name = " Vasya ",
                SurName = " Vasiliy ",
                MiddleName = " Vasilev ",
                Login = " vasya_21 ",
                Passvord = 123,
                Email = "VASYA@COM"
            });

            us.MySistemAdd(new InfoUser
            {
                Name = " Petya ",
                SurName = " Vasiliy ",
                MiddleName = " Vasilev ",
                Age = 21,
                Login = " vasya_25 ",
                Passvord = 321,
                Email = "PETYA@COM"
            });

            foreach (var i in us.Distinct(new UserEqualityComparer_All()))
                System.Console.WriteLine(i);

           


            Console.Read();


        }
    }
}

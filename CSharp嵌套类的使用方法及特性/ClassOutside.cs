using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp嵌套类的使用方法及特性
{
    public class Outside
    {
        static Outside()
        {
            Console.WriteLine("Outside Inilizlized");
        }
        public void SayIt()
        {
            Nested.Run();
        }
        private class Nested
        {
            static Nested()
            {
                Console.WriteLine("Nested initilized");
            }

            public static void Run()
            {
                Console.WriteLine("Nested Run");
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// 实验代码，源网页：
/// http://www.cnblogs.com/jxnclyk/archive/2010/08/04/1791817.html
/// </summary>

namespace CSharp嵌套类的使用方法及特性
{
    class Program
    {
        static void Main(string[] args)
        {
            /// http://stackoverflow.com/questions/2062875/show-utf8-characters-in-console
            Console.OutputEncoding = Encoding.GetEncoding(936);

            testA();

            test懒加载();

            FullyLazySingleton();


            Console.WriteLine("All tests finished. Press any key to exit.");
            Console.ReadKey();
        }

        static void testA()
        {
            var a = new A();
            // Invoke SayIt would lead to stackoverflow.
            //a.SayIt();
            Console.WriteLine("A finished.");
        }

        static void test懒加载()
        {
            Outside o = new Outside();//打印"Outside Inilizlized"

            Console.WriteLine("Nested 还没有 initilized.");
            o.SayIt();//首先打印"Nested initilized" 再打印 "Nested Run"

            Console.WriteLine("test懒加载 finished.");
        }

        static void FullyLazySingleton()
        {
            //成功
            object o1 = System.Activator.CreateInstance("CSharp嵌套类的使用方法及特性", "CSharp嵌套类的使用方法及特性.A_S+Nested");
            try
            {
                //失败 抛出System.TypeLoadException 异常
                object o2 = System.Activator.CreateInstance("CSharp嵌套类的使用方法及特性", "CSharp嵌套类的使用方法及特性.A_S.Nested");
            }
            catch (TypeLoadException tle)
            {
                Console.WriteLine(tle.Message);
            }
        }
    }
}

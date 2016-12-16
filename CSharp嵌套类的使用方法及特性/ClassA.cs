using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp嵌套类的使用方法及特性
{
    public class A
    {
        private static int _AInt;
        private int _instanceInt;   // 这变量没啥用
        private static void AMethod()
        {
            Console.WriteLine(_AInt);
        }
        public void SayIt()
        {
            NestedA.Method(this);
        }
        /*嵌套类 定义*/
        private class NestedA
        {
            /// DC-Shi说明：调用此方法显然会导致StackOverflow
            public static void Method(A a)
            {
                //静态成员
                _AInt = 100;
                AMethod();
                //实例成员
                a._instanceInt = 10;
                a.SayIt();
            }
        }
    }
}

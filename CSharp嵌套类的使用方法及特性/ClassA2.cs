using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp嵌套类的使用方法及特性
{
    public class A2
    {
        private int _a;

        /*嵌套类 定义*/
        private class NestedA
        {
            public NestedA(A2 a)
            {
                a._a = 9;
                /// 虽然_a是private，但是依然可以在这里访问
            }
        }
    }
}

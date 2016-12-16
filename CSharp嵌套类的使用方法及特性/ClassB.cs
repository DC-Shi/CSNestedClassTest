using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp嵌套类的使用方法及特性
{
    public class B
    {
        public static void BMethod()
        {
            //成功
            NestedA.StaticMethod();
            //编译报错
            /// 权限不够，无法操作嵌套类的private成员
            //NestedA._Int = 100;

            NestedA ins = new NestedA();
            //成功
            ins.Method();
            //编译报错
            /// 权限不够，无法操作private成员
            //ins._instanceInt = 100;
        }
        /*嵌套类 定义*/
        private class NestedA
        {
            private static int _Int;
            private int _instanceInt;
            public static void StaticMethod() { }
            public void Method() { }
        }
    }
}

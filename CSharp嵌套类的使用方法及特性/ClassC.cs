using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp嵌套类的使用方法及特性
{
    public class C_A
    {
        /*嵌套类 定义*/
        protected class Nested
        {
            protected virtual void BaseNested_Method() { }
        }
    }

    public class C : C_A
    {
        /*内嵌类 定义*/
        protected class C_Nested : Nested
        {
            protected override void BaseNested_Method()
            {
                //重写部分
            }
        }
    }

}

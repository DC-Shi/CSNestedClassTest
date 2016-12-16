using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp嵌套类的使用方法及特性
{
    public class Singleton
    {
        public static Singleton Instance
        {
            get
            {
                return Nested.instance;
            }
        }
        private class Nested
        {
            public readonly static Singleton instance = new Singleton();
        }
    }

    public class A_S
    {
        public class Nested
        {
            protected void BaseNested_Method()
            {
            }
        }
    }
}

using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //public
            ConsoleApp1.Color1 color1 = new ConsoleApp1.Color1();
            color1.PublicMethod();
        }
    }

    class Color3 : ConsoleApp1.Color1
    {
        public void Method2()
        {
            ProtectedInternalMethod();
            ProtectedMethod();
            PublicMethod();
        }
    }

    class Color4 : ConsoleApp1.Color2()
        {
        public void Method3()
        {
            ProtectedInternalMethod();
            ProtectedMethod();
            PublicMethod();
        }
        }
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //public
            //internal
            //protected internal
            
            Color1 color1 = new Color1();
            color1.PublicMethod();
            color1.InternalMethod();
            color1.ProtectedInternalMethod();
            Console.ReadLine();
        }
    }

    public class Color1
    {
        public void PublicMethod()
        {
            Console.WriteLine("public class public Method");
            //public 
            //protected
            //protected internal
            //internal
            //private
            //private protected
            PublicMethod();
            ProtectedMethod();
            ProtectedInternalMethod();
            InternalMethod();
            PrivateMethod();
            PrivateProtectedMethod();
        }
        protected void ProtectedMethod()
        {
            Console.WriteLine("public class protected Method");
        }
        internal void InternalMethod()
        {
            Console.WriteLine("public class internal Method");
        }
        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("public class protected internal Method");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("public class Private Method");
        }
        private protected void PrivateProtectedMethod()
        {
            Console.WriteLine("public class Private Protected Method");
        }

        //virtual void VirtualMethod() //can not be private
        //{
        //    Console.WriteLine("public class virtual Method");
        //}

        //abstract void VirtualMethod()   //can not declare a body;
        //                                //can not be private
        //{
        //    Console.WriteLine("public class abstract Method");
        //}
    }

    public class Color2 : Color1
    {
        public void Method1()
        {
            PublicMethod();
            PrivateProtectedMethod();
            ProtectedInternalMethod();
            ProtectedMethod();
            InternalMethod();
        }
    }
}

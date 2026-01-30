using System;
using System.Collections.Generic;
using System.Text;

namespace Eslavath_Aditya_assignment_Csharp
{
    class MyClass
    {
        protected string myString;

        public string ContainedString
        {
            set { myString = value; }
        }

        public virtual string GetString()
        {
            return myString;
        }
    }

    class MyDerivedClass : MyClass
    {
        public override string GetString()
        {
            return base.GetString() + " (output from derived class)";
        }
    }

    internal class q6
    {
        static void Main(string[] args)
        {
            MyDerivedClass obj = new MyDerivedClass();
            obj.ContainedString = "Hello World";
            Console.WriteLine(obj.GetString());
        }
    }
}

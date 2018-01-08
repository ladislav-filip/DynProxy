using System;

namespace DynProxy
{
    public class MyClass
    {
        public virtual bool Flag { get; set; }

        public virtual void Execute()
        {
            Console.WriteLine("Execute method called");
        }
    }
}
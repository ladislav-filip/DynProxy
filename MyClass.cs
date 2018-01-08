using System;

namespace DynProxy
{
    /// <summary>
    /// Zkušební třída pro proxy
    /// </summary>
    public class MyClass
    {
        public virtual bool Flag { get; set; }

        public virtual void Execute()
        {
            Console.WriteLine("Execute method called");
        }
    }
}
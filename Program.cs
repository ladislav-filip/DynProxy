using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace DynProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ProxyGenerator()
                .CreateClassProxy<MyClass>(
                    new Interceptor());
            Work(proxy);

            Console.WriteLine("Finnish. Press any key.");
            Console.ReadKey();
        }

        static private void Work(MyClass obj)
        {
            obj.Flag = true;
            obj.Execute();
        }
    }
}

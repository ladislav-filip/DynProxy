using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace DynProxy
{
    /// <summary>
    /// Ukázka jak si vytvořit dynamic proxy
    /// </summary>
    class Program
    {
        /// <summary>
        /// Pracovní testovací metoda
        /// </summary>
        /// <param name="obj"></param>
        private static void Work(MyClass obj)
        {
            obj.Flag = true;
            obj.Execute();
        }

        static void Main(string[] args)
        {
            // vygeneruji proxy...
            var proxy = new ProxyGenerator()
                .CreateClassProxy<MyClass>(
                    new Interceptor());
            // ...a spustím testovací metodu
            Work(proxy);

            Console.WriteLine("Finnish. Press any key.");
            Console.ReadKey();
        }
    }
}

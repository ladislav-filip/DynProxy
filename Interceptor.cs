using System;
using Castle.DynamicProxy;

namespace DynProxy
{
    /// <summary>
    /// Obalující proxy třída
    /// </summary>
    public class Interceptor : IInterceptor
    {
        /// <summary>
        /// Metoda je vyvolána před každým voláním metody v originální třídě
        /// </summary>
        /// <param name="invocation"></param>
        public void Intercept(IInvocation invocation)
        {
            // pokud jsou volány vlastnosti, tak jde o metody typy "set_Xxx"
            Console.WriteLine($"Before target call {invocation.Method.Name}");
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Target exception {e.Message}");
                throw;
            }
            finally
            {
                Console.WriteLine($"After target call {invocation.Method.Name}");
            }
        }
    }
}
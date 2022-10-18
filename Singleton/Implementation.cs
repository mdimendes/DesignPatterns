using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class Logger
    {

        // private static Logger? _instance;

        /// <summary>
        /// Instance
        /// </summary>
        //public static Logger Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new Logger();
        //        }
        //        return _instance;
        //    }
        //}


        //Lazy<T>
        private static readonly Lazy<Logger> _lazyLogger
            = new Lazy<Logger>(() => new Logger());

        /// <summary>
        /// Instance
        /// </summary>
        public static Logger Instance
        {
            get
            {
                return _lazyLogger.Value;                
            }
        }

        protected Logger() //Clients cannot instantiate, but can be subclassed
        {

        }

        /// <summary>
        /// SingletonOperation
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }
    }
}

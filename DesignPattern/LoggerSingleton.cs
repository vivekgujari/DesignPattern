using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class LoggerSingleton
    {
        public static LoggerSingleton Logger;
        private LoggerSingleton()
        { 
            
        }

        public static LoggerSingleton getInstance()
        {
            if (Logger == null)
                Logger = new LoggerSingleton();
            return Logger;
        }
    }
}

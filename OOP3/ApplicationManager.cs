using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        //polimorfizm tabanlı bağlantılar 
        public void Apply(ICreditManager creditype, List<ILoggerService> loggerservices)
        {
            creditype.Calculate();
            foreach(var loggerservice in loggerservices)
            {
                loggerservice.Log();
            }
        }

        public void Information(List<ICreditManager> creditypelist)
        {
            foreach (var creditype in creditypelist)
            {
                creditype.Calculate();
            }

        }



    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            //kullanıcıya işlem sonucunda sms gönderme 

            Console.WriteLine("musteriye SMS yollandı");
            Console.ReadLine();
        }
    }
}

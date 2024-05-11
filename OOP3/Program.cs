using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager consumer1 = new CalculateConsumerLoan();
            ICreditManager vehicle1 = new CalculateVehicleLoan();
            ICreditManager housing1 = new CalculateHousingLoan(); ;
            //creditManager.Calculate();

            ILoggerService dataservice = new DataLoggerService();

            ApplicationManager basvuru1 = new ApplicationManager();
            basvuru1.Apply(consumer1, new List<ILoggerService> {dataservice,new SmsLoggerService()});

            //List<ICreditManager> creditypes = new List<ICreditManager>() { consumer1, vehicle1, housing1 };

            //ApplicationManager onbilgi = new ApplicationManager();
            //onbilgi.Information(creditypes);

        }
    }
}

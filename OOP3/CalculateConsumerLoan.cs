using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class CalculateConsumerLoan : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("ihtiyaç kredisi hesaplandı");
            
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class CalculateVehicleLoan : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Tasıt kredisi hesaplandı");
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }



}

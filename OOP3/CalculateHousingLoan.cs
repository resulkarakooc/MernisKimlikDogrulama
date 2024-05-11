using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OOP3
{
    internal class CalculateHousingLoan : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi hesaplandı");
            
            Console.ReadLine();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

    }
}

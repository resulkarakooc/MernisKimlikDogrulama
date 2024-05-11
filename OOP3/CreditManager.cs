using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface ICreditManager
    {
        //İnterface(arabirim,arayüz) ler oluşturacağımız classlarda şablon olurlar
        void Calculate();
        void Remove();
    }
}

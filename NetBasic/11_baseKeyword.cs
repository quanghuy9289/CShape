using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic
{
    class Milk
    {
        public string color = "White";
    }

    class Milo : Milk
    {
        public new string color = "Brown"; // dung new keyword de chi ra color dc hided khoi lop co so (option)
        public void ShowColor()
        {
            Console.WriteLine("Base color: " + base.color);
            Console.WriteLine("Milo color: " + color);
        }
    }
}

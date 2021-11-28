using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Basics
{
    class Program
    {
        static void Main()
        {
            Zdravic zdravic = new Zdravic();
            zdravic.text = "Ahoj uživateli";
            zdravic.Pozdrav("Jakub");
            zdravic.Pozdrav("Tomáš");
            zdravic.text = "Vítám tě tu programátore";
            zdravic.Pozdrav("Richard");
            Console.ReadKey();
        }
    }
}

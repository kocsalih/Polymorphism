using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Banka seçiniz: A / B");
            ConsoleKeyInfo secim;
            secim = Console.ReadKey();

            if (secim.Key==ConsoleKey.A)
            {
                Abankası B1 = new Abankası();
                B1.BilgileriAl();
                B1.IndirimOraninaGoreIndirimYap();

            }

            else if (secim.Key==ConsoleKey.B)
            {
                Bbankasi B2 = new Bbankasi();
                B2.BilgileriAl();
                B2.IndirimOraninaGoreIndirimYap();
            }
            else
            {
                Console.WriteLine("İstenilen bankalardan birini seçiniz!");
            }

            Console.ReadKey();
        }
    }
}

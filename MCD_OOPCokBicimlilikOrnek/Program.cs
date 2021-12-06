using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPCokBicimlilikOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //polymorphism

            Console.WriteLine("Banka seçiniz A/B : ");
            ConsoleKeyInfo secim;
            secim = Console.ReadKey();

            if (secim.Key==ConsoleKey.A)
            {
                ABankasi bankam = new ABankasi();
                bankam.BilgileriAl();
                bankam.IndirimOraninaGoreIndirimYap();
            }
            else if (secim.Key==ConsoleKey.B)
            {
                BBankasi bankam = new BBankasi();
                bankam.BilgileriAl();
                bankam.IndirimOraninaGoreIndirimYap();
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz.");
            }


            Console.ReadKey();
        }
    }
}

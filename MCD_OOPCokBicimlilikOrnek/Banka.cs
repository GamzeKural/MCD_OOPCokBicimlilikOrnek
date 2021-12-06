using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPCokBicimlilikOrnek
{
    public class Banka
    {

        public string BankaAdi { get; set; }

        private decimal _alisverisTutari=0;

        public decimal AlisverisTutari
        {
            get;
            set;
        }

        public void BilgileriAl()
        {
            Console.WriteLine(BankaAdi+" bankasına hoşgeldiniz...");
            Console.WriteLine("Alışveriş tutarı giriniz: ");
            _alisverisTutari = Convert.ToDecimal(Console.ReadLine());
            if (_alisverisTutari>0)
            {
                AlisverisTutari = _alisverisTutari;
            }
            else
            {
                throw new Exception("Tutar sıfırdan büyük olmalıdır.");
            }
        }

        public virtual void IndirimOraninaGoreIndirimYap()
        {
            AlisverisTutari -= AlisverisTutari * 0.20m;
            Console.WriteLine("%20 indirim uygulandı...");
            Console.WriteLine("Ödenecek tutar: "+AlisverisTutari);
        }

    }
}

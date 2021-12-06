using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPCokBicimlilikOrnek
{
    public class BBankasi:Banka
    {
        //Bu banka 0.05 indirim yapacak bu nedenle virtual metodu override ettik.

        public override void IndirimOraninaGoreIndirimYap()
        {
            AlisverisTutari -= AlisverisTutari * 0.05m;
            Console.WriteLine("%5 indirim uygulandı...");
            Console.WriteLine("Ödenecek tutar: "+AlisverisTutari);
        }
    }
}

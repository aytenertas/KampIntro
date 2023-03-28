using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler sepete eklendi :" + urun.Adi);        
        }

        public void Ekle2(string urunAdi, int urunFiyati, string urunAciklama , int stokAdedi)
        {
            Console.WriteLine("Tebrikler sepete eklendi " + urunAdi);
        }
    }
}

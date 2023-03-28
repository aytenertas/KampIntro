using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class DortIşlem
    {
        public void Toplama(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam eşittir : " + toplam);
        }

        public void Cıkarma(int sayi1, int sayi2)
        {
            int Fark = sayi1 - sayi2;
            Console.WriteLine("Fark eşittir : " + Fark);
        }

        public void Bolme(int sayi1, int sayi2)
        {
            int Bölme = sayi1 / sayi2;
            Console.WriteLine("Bölüm eşittir : " + Bölme);
        }

        public void Carpma(int sayi1, int sayi2)
        {
            int çarpım = sayi1 * sayi2;
            Console.WriteLine("Çarpım eşittir : " + çarpım);
            Console.ReadKey();
        }
        
    }
}

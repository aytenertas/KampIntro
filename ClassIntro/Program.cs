using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 23;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Serhat Yıldız";
            kurs2.İzlenmeOrani = 38;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Yılmaz Bilgin";
            kurs3.İzlenmeOrani = 78;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C";
            kurs4.Egitmen = "Fuat Gümüş";
            kurs4.İzlenmeOrani = 25;


            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ " " + kurs.İzlenmeOrani);  
            }

           // Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
            Console.ReadLine();
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }
}

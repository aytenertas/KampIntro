using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", 
                "Proglamlamaya başlangıç için temel kurs","Java", "Python", "C++", "CSharp"};

            for (int i = 0; i < kurslar.Length; i++)
            {
               Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("---------------------------------------------------------------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.ReadKey();
        }
    }
}

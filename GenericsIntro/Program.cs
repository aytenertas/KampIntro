﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Ayten");

            Console.WriteLine(isimler.Length);

            isimler.Add("hale");

            Console.WriteLine(isimler.Length);

            isimler.Add("jale");

            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }


            Console.ReadKey();
        }
    }
}

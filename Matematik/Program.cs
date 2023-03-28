using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIşlem dortIşlem = new DortIşlem();
            dortIşlem.Toplama(6, 2);
            dortIşlem.Cıkarma(6, 2);
            dortIşlem.Bolme(6, 2);
            dortIşlem.Carpma(6, 2);
        }

        
    }
}

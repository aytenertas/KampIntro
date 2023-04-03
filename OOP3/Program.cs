using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); dersek de oluyor.
            //İnterface'ler de o interface'yi implemente eden class'ın referans numarasını tutabilir.

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService(); //new DatabaseLoggerService() BasvuruYap metodunun içine bunu yazarak da referans numarasını tutabiliriz.
         //   List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() }; BasvuruYap metodu içinde de burda da listemizimi tanımlayabiliriz.


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> { databaseLoggerService, fileLoggerService, new SmsLoggerService() }); //krediManager verilemez. Çünkü o bir interface , interface newlenemez.

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager, konutKrediManager };

         //   basvuruManager.KrediOnBilgilendirmesiYap(krediler);


            Console.ReadKey();
        }
    }
}

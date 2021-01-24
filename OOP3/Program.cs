using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();    

            IKrediManager konutKrediManager = new KonutKrediManager();            

            IKrediManager tasitKrediManager = new TasitKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();

            ILoggerService databaselogger = new DatabaseLoggerService();

            ILoggerService filelogger = new FileLoggerService();

            basvuruManager.BasvuruYap(konutKrediManager, filelogger);
            //interfaceler onu implemente eden clasın referans numarasını tutabilirler.

            List<IKrediManager> krediler = new List<IKrediManager>()
            {
                ihtiyacKrediManager,
                tasitKrediManager
            };//bir veya birden fazla kredi sınıfını hesaplayabilmek için liste kullandık
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            //interfaceleri birbirinin alternatifi olan fakat kod içeriği farklı olan için kullanırız
        }
    }
}

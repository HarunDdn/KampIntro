using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)//bu basvuruyu hangi krediye göre yapacağız?parametre ile--buna enjection denir
        {
            //basvuru bilgileri alınır....
            krediManager.Hesapla();//basvuruyu kredi bağımsız hale getirdik.
            loggerService.Log();//hangi loglayıcı service seçildi ise ona logla
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler, ILoggerService loggerService)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
            loggerService.Log();
        }
    }
}

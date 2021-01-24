using System;
using System.Collections.Generic;
using System.Text;

namespace Opp3_Form
{
    class BasvuruManager
    {
        
        public void BasvuruYap(IKrediManager krediManager,IBilgilendirmeService bilgilendirmeService,double anapara)
        {
            bilgilendirmeService.Bilgilendir();
            krediManager.Hesapla(anapara);
            
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler, IBilgilendirmeService bilgilendirmeService, double anapara)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla(anapara);
            }
            bilgilendirmeService.Bilgilendir();
        }
    }
}

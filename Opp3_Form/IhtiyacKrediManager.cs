using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Opp3_Form
{
    class IhtiyacKrediManager : IKrediManager
    {
        
        public void Hesapla(double anapara)
        {
            Application.OpenForms["Form1"].Controls["txt_bireyselsonuc"].Text =  (anapara * 0.05).ToString();
        }
    }
}

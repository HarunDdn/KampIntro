using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Opp3_Form
{
    class TasitKrediManager : IKrediManager
    {       

        

        public void Hesapla(double anapara)
        {
            Application.OpenForms["Form1"].Controls["txt_tasitsonuc"].Text = (anapara * 0.1).ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opp3_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double _anapara;
        //bool _tasitkredisi, _konutkredisi, _bireyselkredi;       

        IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

        IKrediManager konutKrediManager = new KonutKrediManager();

        IKrediManager tasitKrediManager = new TasitKrediManager();

        BasvuruManager basvuruManager = new BasvuruManager();

        IBilgilendirmeService bilgilendirmeService = new MailGonderService();
        List<IKrediManager> krediler = new List<IKrediManager>();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _anapara = Convert.ToDouble(textBox1.Text);
        }

        private void chk_tasit_CheckedChanged(object sender, EventArgs e)
        {

            if (chk_tasit.Checked)
            {
                krediler.Add(tasitKrediManager);
            }
            else
            {
                krediler.Remove(tasitKrediManager);    
            }
            
        }

        private void chk_konut_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_konut.Checked)
            {
                krediler.Add(konutKrediManager);
            }
            else
            {
                krediler.Remove(konutKrediManager);
            }
        }

        private void chk_bireysel_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_bireysel.Checked)
            {
                krediler.Add(ihtiyacKrediManager);
            }
            else
            {
                krediler.Remove(ihtiyacKrediManager);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //_sonuc= basvuruManager.BasvuruYap(tasitKrediManager, bilgilendirmeService,_anapara);
            
            
            
            basvuruManager.KrediOnBilgilendirmesiYap(krediler, bilgilendirmeService, _anapara);
            //textBox2.Text = _sonuc.ToString();
        }

        private List<IKrediManager> dinamikListeOlustur()
        {
            return  new List<IKrediManager>();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}

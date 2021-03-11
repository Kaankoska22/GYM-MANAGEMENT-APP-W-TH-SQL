using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BİGSMASHSPORSALONU
{
    public partial class YENİÇALIŞANKAYIT : Form
    {
        public YENİÇALIŞANKAYIT()
        {
            InitializeComponent();
        }
        ////////////////////////////////
        ÇALIŞANGÜNCELLE CN = new ÇALIŞANGÜNCELLE();
        ÇALIŞANFONKSİYONLARI CS = new ÇALIŞANFONKSİYONLARI();
        ////////////////////////////////
        private void button2_Click(object sender, EventArgs e)//BTN GERİ DÖN
        {
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            CN.Show();
            this.Hide();
        }//ÇALIŞAN BİLGİ GÜNCELLEME SAYFASINA YÖNLENDİRME
        private void button1_Click(object sender, EventArgs e)//EKLE BUTONU
        {
            CS.ÇALIŞANEKLE(textBoxAD,maskedTextBoxŞİFRE,textBoxSOYAD,maskedTextBoxTC,radioButtonERKEK,radioButtonKADIN,maskedTextBoxTELEFON,numericUpDownYAŞ,richTextBoxKISANOT,textBoxFOTO);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxFOTO.Text = openFileDialog1.FileName;
        }
    }
}

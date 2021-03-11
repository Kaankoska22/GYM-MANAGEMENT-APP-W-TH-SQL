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
    public partial class  ÇALIŞANGÜNCELLE : Form 
    {
        public ÇALIŞANGÜNCELLE()
        {
            InitializeComponent();
        }
        //////////////////////////////
        ÇALIŞANFONKSİYONLARI ÇS = new ÇALIŞANFONKSİYONLARI();
        //////////////////////////////
        private void button2_Click(object sender, EventArgs e)//BTN GERİ DÖN 
        {
            this.Hide();
        }
        private void ÇALIŞANGÜNCELLE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'çALIŞANBİLGİLERİ.TBLÇALIŞAN' table. You can move, or remove it, as needed.
            this.tBLÇALIŞANTableAdapter.Fill(this.çALIŞANBİLGİLERİ.TBLÇALIŞAN);




        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ÇS.DATAGRİDENVERİAL(pictureBox3,labelGÜNCELLENİCEKID,dataGridView1,textBoxAD,maskedTextBoxŞİFRE,textBoxSOYAD,maskedTextBoxTC,maskedTextBoxTELEFON,radioButtonERKEK,radioButtonKADIN,richTextBoxKISANOT,textBoxFOTO,numericUpDownYAŞ); 
        }//CLİCK İLE BİLGİLERİ AKTARMA
        private void button1_Click(object sender, EventArgs e)
        {
           ÇS.GÜNCELLE(labelGÜNCELLENİCEKID,textBoxAD,maskedTextBoxŞİFRE,textBoxSOYAD,maskedTextBoxTC,maskedTextBoxTELEFON,numericUpDownYAŞ,radioButtonERKEK,radioButtonKADIN,textBoxFOTO,richTextBoxKISANOT);
            // TODO: This line of code loads data into the 'çALIŞANBİLGİLERİ.TBLÇALIŞAN' table. You can move, or remove it, as needed.
            this.tBLÇALIŞANTableAdapter.Fill(this.çALIŞANBİLGİLERİ.TBLÇALIŞAN);
        }//GÜNCELLE BUTONU 

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxFOTO.Text = openFileDialog1.FileName;
        }
    }
}

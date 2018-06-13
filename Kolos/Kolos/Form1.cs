using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Kolos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult wczytaj = this.openFileDialog.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult zapisz = this.NowaSesja.ShowDialog();
            if(NowaSesja.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string nazwaPliku = NowaSesja.FileName.ToString();
                using (StreamWriter)
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            czas.Text = "60";
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            czas.Text = "90";

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            czas.Text = "120";

        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            string alfabet = "ABCDEFGHIJKLMNOPRSTUWZ";
            char c = alfabet[r.Next(alfabet.Length)];
            litera.Text = c.ToString();
        }
    }
}

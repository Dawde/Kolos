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
using System.Xml.Linq;

namespace Kolos
{
    public partial class Form1 : Form
    {
       public string current;

        private Timer timer1;
        private int counter;
        private char c;
        
        private Control ActiveUserControl { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.ActiveUserControl = wprowadzanie1;
            ActiveUserControl.Visible = false;
            counter = Int32.Parse(czas.Text);
            this.ActiveControl = textBoxNazwaGracza;

        }

        private void check()
        {
            if (String.IsNullOrWhiteSpace(textBoxNazwaGracza.Text)) this.ActiveControl = textBoxNazwaGracza;
            MessageBox.Show("Podaj nazwę gracza", "Nazwa gracza");

        }

        public void SwitchUserControl(Control controls)
        {
            ActiveUserControl.Visible = false;
            controls.Visible = true;
            this.ActiveUserControl = controls;
        }

        private void odliczanie()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            czas.Text = counter.ToString();
        }

        private void losowanie()
        {
            Random r = new Random();
            string alfabet = "ABCDEFGHIJKLMNOPRSTUWZ";
            c = alfabet[r.Next(alfabet.Length)];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
                timer1.Stop();
            czas.Text = counter.ToString();
        }
        
        private void Gracz()
        {
            
        }

        private void buttonWczytaj_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(nazwaGracza.Text))
            {


                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    current = openFileDialog.FileName.ToString();
                    XDocument document = XDocument.Load(current);
                    litera.Text = document.Root.Attribute("litera").Value;
                    czas.Text = document.Root.Attribute("czas").Value;
                    counter = Int32.Parse(czas.Text);
                    SwitchUserControl(wprowadzanie1);
                    if (ActiveUserControl is Wprowadzanie)
                    {
                        Wprowadzanie tmp = ActiveUserControl as Wprowadzanie;
                        tmp.currentFile = current;
                    }
                }
            }
            else check();

        }

        

        private void buttonNowa_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(nazwaGracza.Text))
            {
                losowanie();
                if (NowaSesja.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string letter = c.ToString();
                    string time = czas.Text;
                    XDocument document = new XDocument(
                        new XElement("Sesja",
                        new XAttribute("litera", letter),
                        new XAttribute("czas", time)));
                    document.Save(NowaSesja.FileName.ToString());
                    current = NowaSesja.FileName.ToString();
                    litera.Text = c.ToString();
                    SwitchUserControl(wprowadzanie1);
                    odliczanie();
                    if (ActiveUserControl is Wprowadzanie)
                    {
                        Wprowadzanie tmp = ActiveUserControl as Wprowadzanie;
                        tmp.currentFile = current;
                    }


                }
                
            }
            else check();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            czas.Text = "60";
            if (timer1 != null && timer1.Enabled == true)
            {
                timer1.Stop();
            }
            counter = Int32.Parse(czas.Text);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            czas.Text = "90";
            if (timer1 != null && timer1.Enabled == true)
            {
                timer1.Stop();
            }
            counter = Int32.Parse(czas.Text);

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            czas.Text = "120";
            if (timer1 != null && timer1.Enabled == true)
            {
                timer1.Stop();
            }
            counter = Int32.Parse(czas.Text);

        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            string alfabet = "ABCDEFGHIJKLMNOPRSTUWZ";
            c = alfabet[r.Next(alfabet.Length)];
            litera.Text = c.ToString();
            SwitchUserControl(wprowadzanie1);
            odliczanie();
        }

        private void textBoxNazwaGracza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxNazwaGracza.Text) && e.KeyChar==13)
            {
                nazwaGracza.Text = textBoxNazwaGracza.Text;
                textBoxNazwaGracza.Visible = false;
                nazwaGracza.Visible = true;
                if (ActiveUserControl is Wprowadzanie)
                {
                    Wprowadzanie tmp = ActiveUserControl as Wprowadzanie;
                    tmp.playerName = nazwaGracza.Text;
                }
            }
        }

        private void zmieńNazweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNazwaGracza.Visible = true;
            nazwaGracza.Visible = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           /* if(ActiveUserControl is Wprowadzanie)
            {
                if(ActiveUserControl.Visible == false)
                {
                    SwitchUserControl(tabela1);
                    if (ActiveUserControl is Tabela)
                    {
                        Tabela tmp = ActiveUserControl as Tabela;
                        tmp.obecny = current;
                    }
                }
            }*/
            
        }
    }
}

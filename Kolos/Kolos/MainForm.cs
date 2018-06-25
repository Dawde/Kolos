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
    public partial class MainForm : Form
    {
        private string current;

        public int coounter{get {return counter;}}
        private Timer timer1;
        private int counter;
        private char c;
         
        
       // public Control ActiveUserControl { get; set; }

        public MainForm()
        {
            
            InitializeComponent();
           // this.ActiveUserControl = wprowadzanie1;
           // ActiveUserControl.Visible = false;
            counter = Int32.Parse(czas.Text);
            this.ActiveControl = textBoxNazwaGracza;

        }

        private void Stop(Object sender, EventArgs e)
        {
            timer1.Stop();
            counter = 60;
        }

        private void check()
        {
            if (String.IsNullOrWhiteSpace(textBoxNazwaGracza.Text)) this.ActiveControl = textBoxNazwaGracza;
            MessageBox.Show("Podaj nazwę gracza", "Nazwa gracza");

        }

       /* public void SwitchUserControl(Control controls)
        {
            ActiveUserControl.Visible = false;
            controls.Visible = true;
            this.ActiveUserControl = controls;
        }*/

        private void odliczanie()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);            
            timer1.Interval = 1000; // 1 second
            timer1.Start();
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
            {
                timer1.Stop();
                Wprowadzanie.Instance.zakoncz(this, e);
            }

            czas.Text = counter.ToString();
        }
        
        private void Gracz()
        {
            
        }

        private void buttonWczytaj_Click(object sender, EventArgs e)
        {
           // if (timer1.Enabled == true)
           //     timer1.Stop();
            if (!String.IsNullOrWhiteSpace(nazwaGracza.Text))
            {


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Tabela.Instance.tFile = openFileDialog.FileName.ToString();

                    if (Tabela.Instance != null)
                    {
                        this.Controls.Remove(Tabela.Instance);

                        Tabela.Instance = null;
                    }

                    current = openFileDialog.FileName.ToString();
                    XDocument document = XDocument.Load(current);
                    litera.Text = document.Root.Attribute("litera").Value;
                    czas.Text = document.Root.Attribute("czas").Value;
                    counter = Int32.Parse(czas.Text);
                    this.Controls.Add(Wprowadzanie.Instance);
                    Wprowadzanie.Instance.TimerStop += new EventHandler(Stop);
                    UC uCwprowadzanie = new UC(current, nazwaGracza.Text, litera.Text);
                    // SwitchUserControl(wprowadzanie1);
                    /* if (ActiveUserControl is Wprowadzanie)
                     {
                         Wprowadzanie tmp = ActiveUserControl as Wprowadzanie;
                         tmp.currentFile = current;
                     }*/
                    odliczanie();

                }
            }
            else check();

        }

        

        private void buttonNowa_Click(object sender, EventArgs e)
        {
            //if(timer1.Enabled == true)
             //    timer1.Stop();
            if (!String.IsNullOrWhiteSpace(nazwaGracza.Text))
            {
                losowanie();
                if (NowaSesja.ShowDialog() == DialogResult.OK)
                {
                    if (Tabela.Instance != null)
                    {
                        this.Controls.Remove(Tabela.Instance);
                        Tabela.Instance = null;
                    }
                    char letter = c;
                    int time = counter;//Int32.Parse(czas.Text);
                    current = NowaSesja.FileName.ToString();
                    
                    /*XDocument document = new XDocument(
                        new XElement("Sesja",
                        new XAttribute("litera", letter),
                        new XAttribute("czas", time)));
                    document.Save(NowaSesja.FileName.ToString());*/
                    Sesja sesja = new Sesja(letter, time, current);
                    litera.Text = c.ToString();
                    //SwitchUserControl(wprowadzanie1);
                    this.Controls.Add(Wprowadzanie.Instance);
                    Wprowadzanie.Instance.TimerStop += new EventHandler(Stop);
                    UC uCwprowadzanie = new UC(current, nazwaGracza.Text, litera.Text);
                    /*Wprowadzanie.Instance.BringToFront();
                    Wprowadzanie.Instance.Location = new Point(271, 36);
                    Wprowadzanie.Instance.Size = new Size(478, 322);
                    Wprowadzanie.Instance.currentFile = current;
                    Wprowadzanie.Instance.playerName = nazwaGracza.Text;*/
                    odliczanie();
                   /* if (ActiveUserControl is Wprowadzanie)
                    {
                        Wprowadzanie tmp = ActiveUserControl as Wprowadzanie;
                        tmp.currentFile = current;
                    }*/


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
            //Random r = new Random();
            //string alfabet = "ABCDEFGHIJKLMNOPRSTUWZ";
            //c = alfabet[r.Next(alfabet.Length)];
            losowanie();
            litera.Text = c.ToString();
           // SwitchUserControl(wprowadzanie1);
            odliczanie();
        }

        private void textBoxNazwaGracza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxNazwaGracza.Text) && e.KeyChar==13)
            {
                nazwaGracza.Text = textBoxNazwaGracza.Text;
                textBoxNazwaGracza.Visible = false;
                nazwaGracza.Visible = true;
               /* if (ActiveUserControl is Wprowadzanie)
                {
                    Wprowadzanie tmp = ActiveUserControl as Wprowadzanie;
                    tmp.playerName = nazwaGracza.Text;
                }*/
            }
        }

        private void zmieńNazweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNazwaGracza.Visible = true;
            nazwaGracza.Visible = false;
        }

        private void textBoxNazwaGracza_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxNazwaGracza.Text))
            {
                nazwaGracza.Text = textBoxNazwaGracza.Text;
                textBoxNazwaGracza.Visible = false;
                nazwaGracza.Visible = true;
            }
        }
    }
}

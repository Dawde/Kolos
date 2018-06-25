using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kolos
{
    public partial class Wprowadzanie : UserControl
    {
        public string currentFile { get; set; }
        public string playerName { get; set; }
        public string Litera { get; set; }

        

        public event EventHandler TimerStop;

        private static Wprowadzanie _instance;
        public static Wprowadzanie Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Wprowadzanie();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }

        public Wprowadzanie()
        {
            InitializeComponent();
        }

        private void buttonZakoncz_Click(object sender, EventArgs e)
        {
            /*XDocument plik = XDocument.Load(currentFile);
            plik.Root.Add(
                new XElement("Gracz",
                new XAttribute("Gracz",playerName),
                new XElement("Państwo", textBoxPanstwo.Text),
                new XElement("Miasto",textBoxMiasto.Text),
                new XElement("Roślina", textBoxRoslina.Text),
                new XElement("Zwierzę", textBoxZwierze.Text),
                new XElement("Rzecz", textBoxRzecz.Text),
                new XElement("Imię", textBoxImie.Text)
                ));
            plik.Save(currentFile);*/

            /*Sesja sesja = new Sesja(playerName, textBoxPanstwo.Text, textBoxMiasto.Text, textBoxRoslina.Text, textBoxZwierze.Text, textBoxRzecz.Text, textBoxImie.Text, currentFile);
            //this.Visible = false;
            this.Parent.Controls.Add(Tabela.Instance);
            UC Cwprowadzanie = new UC(currentFile);
            this.Parent.Controls.Remove(Wprowadzanie.Instance);
            Wprowadzanie.Instance = null;
            TimerStop(this,e);*/

            /* Tabela.Instance.BringToFront();
             Tabela.Instance.Location = new Point(113, 41);
             Tabela.Instance.Size = new Size(701, 322);
             this.Parent.Controls.Add();*/
            zakoncz(this, e);

        }

        public void zakoncz(object sender, EventArgs e)
        {
            Sesja sesja = new Sesja(playerName, textBoxPanstwo.Text, textBoxMiasto.Text, textBoxRoslina.Text, textBoxZwierze.Text, textBoxRzecz.Text, textBoxImie.Text, currentFile);
            //this.Visible = false;
            this.Parent.Controls.Add(Tabela.Instance);
            UC Cwprowadzanie = new UC(currentFile);
            this.Parent.Controls.Remove(Wprowadzanie.Instance);
            Wprowadzanie.Instance = null;
            TimerStop(this, e);
        }

        private void textBoxPanstwo_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxPanstwo.Text.StartsWith(Litera.ToString()))
                textBoxPanstwo.Text = "";
        }
    }
}

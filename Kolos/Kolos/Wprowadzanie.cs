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

        public Wprowadzanie()
        {
            InitializeComponent();
        }

        private void buttonZakoncz_Click(object sender, EventArgs e)
        {
             XDocument plik = XDocument.Load(currentFile);
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
             plik.Save(currentFile);
            this.Visible = false;

            
        }
    }
}

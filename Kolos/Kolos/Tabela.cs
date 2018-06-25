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
    public partial class Tabela : UserControl
    {
        //private counter = 
        public string tFile { get; set; }

        private static Tabela _instance;
        public static Tabela Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Tabela();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        public Tabela()
        {
            InitializeComponent();
            //wczytaj();
            
        }

        private void wczytaj()
        {
            //MessageBox.Show(tFile);
            XDocument document = XDocument.Load(tFile);
            string letter = document.Root.Attribute("litera").Value;
            string player; //= document.Root.Element("Gracz").Attribute("Gracz").Value;
            
            var descendants = document.Root.Elements("Gracz");
            foreach (var item in descendants)
            {
                List<string> row = new List<string>();
                row.Add(letter);
                player = item.Attribute("Gracz").Value;
                row.Add(player);
                row.Add(item.Element("Państwo").Value);
                row.Add(item.Element("Miasto").Value);
                row.Add(item.Element("Roślina").Value);
                row.Add(item.Element("Zwierzę").Value);
                row.Add(item.Element("Rzecz").Value);
                row.Add(item.Element("Imię").Value);
                string[] row2 = row.ToArray();
                var listViewItem = new ListViewItem(row2);
                listViewTabela.Items.Add(listViewItem);
                
            }
            

        }

        private void listViewTabela_VisibleChanged(object sender, EventArgs e)
        {
            wczytaj();
        }

        private void buttonWyniki_Click(object sender, EventArgs e)
        {
            buttonWyniki.Visible = false;
            listViewTabela.Visible = true;
        }
    }
}

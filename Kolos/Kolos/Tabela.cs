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
            wczytaj();
            
        }

        private void wczytaj()
        {
            //MessageBox.Show(tFile);
            /*XDocument document = XDocument.Load(currentFile);
            string letter = document.Root.Attribute("litera").Value;
            string player = document.Root.Attribute("Gracz").Value;
            string[] row = {letter,player};
            var listViewItem = new ListViewItem(row);
            listViewTabela.Items.Add(listViewItem);*/

        }

    }
}

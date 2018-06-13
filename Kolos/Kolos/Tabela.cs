using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolos
{
    public partial class Tabela : UserControl
    {
        public Tabela()
        {
            InitializeComponent();
            
        }

        public string obecny { get; set; }

        private void listViewTabela_MouseMove(object sender, MouseEventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(obecny))
            listViewTabela.Columns.Add(obecny);
        }
    }
}

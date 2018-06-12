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
            test();
        }

        private void test()
        {
            var test = new ListViewItem(new[] { "A", "Assss", "AAAAAA", "asdasd", "agfsfdsfs", "sgasda", "sadasdad" });
            listViewTabela.Items.Add(test);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Kolos
{
    public class UC
    {
        public UC(string current,string nazwaGracza, string litera)
        {
            
            Wprowadzanie.Instance.BringToFront();
            Wprowadzanie.Instance.Location = new Point(271, 36);
            Wprowadzanie.Instance.Size = new Size(478, 322);
            Wprowadzanie.Instance.currentFile = current;
            Wprowadzanie.Instance.playerName = nazwaGracza;
            Wprowadzanie.Instance.Litera = litera;
        }

        public UC(string current)
        {
            Tabela.Instance.BringToFront();
            Tabela.Instance.Location = new Point(113, 41);
            Tabela.Instance.Size = new Size(701, 322);
            Tabela.Instance.tFile = current;
        }
    }
}

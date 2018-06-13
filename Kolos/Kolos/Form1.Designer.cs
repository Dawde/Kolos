namespace Kolos
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonWczytaj = new System.Windows.Forms.Button();
            this.labelCzas = new System.Windows.Forms.Label();
            this.czas = new System.Windows.Forms.Label();
            this.contextMenuStripCzas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelLitera = new System.Windows.Forms.Label();
            this.litera = new System.Windows.Forms.Label();
            this.buttonLosuj = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.NowaSesja = new System.Windows.Forms.SaveFileDialog();
            this.nazwaGracza = new System.Windows.Forms.Label();
            this.textBoxNazwaGracza = new System.Windows.Forms.TextBox();
            this.contextMenuStripNazwa = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zmieńNazweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wprowadzanie1 = new Kolos.Wprowadzanie();
            this.tabela1 = new Kolos.Tabela();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStripCzas.SuspendLayout();
            this.contextMenuStripNazwa.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(12, 12);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(75, 23);
            this.buttonZapisz.TabIndex = 0;
            this.buttonZapisz.Text = "Nowa sesja";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonNowa_Click);
            // 
            // buttonWczytaj
            // 
            this.buttonWczytaj.Location = new System.Drawing.Point(93, 12);
            this.buttonWczytaj.Name = "buttonWczytaj";
            this.buttonWczytaj.Size = new System.Drawing.Size(75, 23);
            this.buttonWczytaj.TabIndex = 1;
            this.buttonWczytaj.Text = "Wczytaj";
            this.buttonWczytaj.UseVisualStyleBackColor = true;
            this.buttonWczytaj.Click += new System.EventHandler(this.buttonWczytaj_Click);
            // 
            // labelCzas
            // 
            this.labelCzas.AutoSize = true;
            this.labelCzas.Location = new System.Drawing.Point(9, 63);
            this.labelCzas.Name = "labelCzas";
            this.labelCzas.Size = new System.Drawing.Size(30, 13);
            this.labelCzas.TabIndex = 2;
            this.labelCzas.Text = "Czas";
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.ContextMenuStrip = this.contextMenuStripCzas;
            this.czas.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czas.Location = new System.Drawing.Point(12, 76);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(70, 51);
            this.czas.TabIndex = 3;
            this.czas.Text = "60";
            // 
            // contextMenuStripCzas
            // 
            this.contextMenuStripCzas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.contextMenuStripCzas.Name = "contextMenuStripCzas";
            this.contextMenuStripCzas.Size = new System.Drawing.Size(93, 70);
            this.contextMenuStripCzas.Text = "Ilość czasu";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem2.Text = "60";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem3.Text = "90";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem4.Text = "120";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // labelLitera
            // 
            this.labelLitera.AutoSize = true;
            this.labelLitera.Location = new System.Drawing.Point(12, 131);
            this.labelLitera.Name = "labelLitera";
            this.labelLitera.Size = new System.Drawing.Size(33, 13);
            this.labelLitera.TabIndex = 4;
            this.labelLitera.Text = "Litera";
            // 
            // litera
            // 
            this.litera.AutoSize = true;
            this.litera.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.litera.Location = new System.Drawing.Point(12, 144);
            this.litera.Name = "litera";
            this.litera.Size = new System.Drawing.Size(51, 51);
            this.litera.TabIndex = 5;
            this.litera.Text = "A";
            // 
            // buttonLosuj
            // 
            this.buttonLosuj.Location = new System.Drawing.Point(12, 198);
            this.buttonLosuj.Name = "buttonLosuj";
            this.buttonLosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonLosuj.TabIndex = 6;
            this.buttonLosuj.Text = "Losuj";
            this.buttonLosuj.UseVisualStyleBackColor = true;
            this.buttonLosuj.Visible = false;
            this.buttonLosuj.Click += new System.EventHandler(this.buttonLosuj_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Pliki XML|*.xml";
            this.openFileDialog.RestoreDirectory = true;
            // 
            // NowaSesja
            // 
            this.NowaSesja.DefaultExt = "xml";
            this.NowaSesja.Filter = "Pliki XML|*.xml";
            this.NowaSesja.RestoreDirectory = true;
            // 
            // nazwaGracza
            // 
            this.nazwaGracza.AutoSize = true;
            this.nazwaGracza.ContextMenuStrip = this.contextMenuStripNazwa;
            this.nazwaGracza.Font = new System.Drawing.Font("Comic Sans MS", 11F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaGracza.Location = new System.Drawing.Point(174, 12);
            this.nazwaGracza.Name = "nazwaGracza";
            this.nazwaGracza.Size = new System.Drawing.Size(0, 22);
            this.nazwaGracza.TabIndex = 11;
            this.nazwaGracza.Visible = false;
            // 
            // textBoxNazwaGracza
            // 
            this.textBoxNazwaGracza.Location = new System.Drawing.Point(179, 14);
            this.textBoxNazwaGracza.Name = "textBoxNazwaGracza";
            this.textBoxNazwaGracza.Size = new System.Drawing.Size(110, 20);
            this.textBoxNazwaGracza.TabIndex = 12;
            this.textBoxNazwaGracza.WordWrap = false;
            this.textBoxNazwaGracza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNazwaGracza_KeyPress);
            // 
            // contextMenuStripNazwa
            // 
            this.contextMenuStripNazwa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zmieńNazweToolStripMenuItem});
            this.contextMenuStripNazwa.Name = "contextMenuStripNazwa";
            this.contextMenuStripNazwa.Size = new System.Drawing.Size(145, 26);
            // 
            // zmieńNazweToolStripMenuItem
            // 
            this.zmieńNazweToolStripMenuItem.Name = "zmieńNazweToolStripMenuItem";
            this.zmieńNazweToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.zmieńNazweToolStripMenuItem.Text = "Zmień nazwe";
            this.zmieńNazweToolStripMenuItem.Click += new System.EventHandler(this.zmieńNazweToolStripMenuItem_Click);
            // 
            // wprowadzanie1
            // 
            this.wprowadzanie1.currentFile = null;
            this.wprowadzanie1.Location = new System.Drawing.Point(271, 36);
            this.wprowadzanie1.Name = "wprowadzanie1";
            this.wprowadzanie1.playerName = null;
            this.wprowadzanie1.Size = new System.Drawing.Size(478, 322);
            this.wprowadzanie1.TabIndex = 9;
            // 
            // tabela1
            // 
            this.tabela1.Location = new System.Drawing.Point(113, 41);
            this.tabela1.Name = "tabela1";
            this.tabela1.obecny = null;
            this.tabela1.Size = new System.Drawing.Size(701, 322);
            this.tabela1.TabIndex = 14;
            this.tabela1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(363, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 20);
            this.textBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 370);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nazwaGracza);
            this.Controls.Add(this.wprowadzanie1);
            this.Controls.Add(this.buttonLosuj);
            this.Controls.Add(this.litera);
            this.Controls.Add(this.labelLitera);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.labelCzas);
            this.Controls.Add(this.buttonWczytaj);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.textBoxNazwaGracza);
            this.Controls.Add(this.tabela1);
            this.Name = "Form1";
            this.Text = "Państwa miasta";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.contextMenuStripCzas.ResumeLayout(false);
            this.contextMenuStripNazwa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonWczytaj;
        private System.Windows.Forms.Label labelCzas;
        private System.Windows.Forms.Label czas;
        private System.Windows.Forms.Label labelLitera;
        private System.Windows.Forms.Label litera;
        private System.Windows.Forms.Button buttonLosuj;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog NowaSesja;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCzas;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private Wprowadzanie wprowadzanie1;
        private System.Windows.Forms.Label nazwaGracza;
        private System.Windows.Forms.TextBox textBoxNazwaGracza;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNazwa;
        private System.Windows.Forms.ToolStripMenuItem zmieńNazweToolStripMenuItem;
        private Tabela tabela1;
        private System.Windows.Forms.TextBox textBox1;
    }
}


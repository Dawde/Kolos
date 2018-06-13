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
            this.contextMenuStripCzas.SuspendLayout();
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
            this.buttonZapisz.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonWczytaj
            // 
            this.buttonWczytaj.Location = new System.Drawing.Point(93, 12);
            this.buttonWczytaj.Name = "buttonWczytaj";
            this.buttonWczytaj.Size = new System.Drawing.Size(75, 23);
            this.buttonWczytaj.TabIndex = 1;
            this.buttonWczytaj.Text = "Wczytaj";
            this.buttonWczytaj.UseVisualStyleBackColor = true;
            this.buttonWczytaj.Click += new System.EventHandler(this.button2_Click);
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
            this.buttonLosuj.Click += new System.EventHandler(this.buttonLosuj_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Pliki XML|*.xml";
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.Title = "Wczytaj";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // NowaSesja
            // 
            this.NowaSesja.CreatePrompt = true;
            this.NowaSesja.DefaultExt = "xml";
            this.NowaSesja.FileName = "ass";
            this.NowaSesja.Filter = "Pliki XML|*.xml";
            this.NowaSesja.RestoreDirectory = true;
            this.NowaSesja.Title = "Tworzenie nowej sesji";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 370);
            this.Controls.Add(this.buttonLosuj);
            this.Controls.Add(this.litera);
            this.Controls.Add(this.labelLitera);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.labelCzas);
            this.Controls.Add(this.buttonWczytaj);
            this.Controls.Add(this.buttonZapisz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStripCzas.ResumeLayout(false);
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
        private Tabela tabela1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog NowaSesja;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCzas;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}


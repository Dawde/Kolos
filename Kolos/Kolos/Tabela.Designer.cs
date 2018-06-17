namespace Kolos
{
    partial class Tabela
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewTabela = new System.Windows.Forms.ListView();
            this.Litera = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gracz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Panstwo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Miasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Roslina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zwierze = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rzecz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Imie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewTabela
            // 
            this.listViewTabela.AutoArrange = false;
            this.listViewTabela.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Litera,
            this.Gracz,
            this.Panstwo,
            this.Miasto,
            this.Roslina,
            this.Zwierze,
            this.Rzecz,
            this.Imie});
            this.listViewTabela.GridLines = true;
            this.listViewTabela.Location = new System.Drawing.Point(3, 3);
            this.listViewTabela.Name = "listViewTabela";
            this.listViewTabela.Size = new System.Drawing.Size(694, 316);
            this.listViewTabela.TabIndex = 1;
            this.listViewTabela.UseCompatibleStateImageBehavior = false;
            this.listViewTabela.View = System.Windows.Forms.View.Details;
            // 
            // Litera
            // 
            this.Litera.Text = "Litera";
            this.Litera.Width = 41;
            // 
            // Gracz
            // 
            this.Gracz.Text = "Gracz";
            this.Gracz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Gracz.Width = 89;
            // 
            // Panstwo
            // 
            this.Panstwo.Text = "Państwo";
            this.Panstwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Panstwo.Width = 84;
            // 
            // Miasto
            // 
            this.Miasto.Text = "Miasto";
            this.Miasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Miasto.Width = 96;
            // 
            // Roslina
            // 
            this.Roslina.Text = "Roślina";
            this.Roslina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Roslina.Width = 94;
            // 
            // Zwierze
            // 
            this.Zwierze.Text = "Zwierzę";
            this.Zwierze.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Zwierze.Width = 96;
            // 
            // Rzecz
            // 
            this.Rzecz.Text = "Rzecz";
            this.Rzecz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Rzecz.Width = 97;
            // 
            // Imie
            // 
            this.Imie.Text = "Imię";
            this.Imie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Imie.Width = 93;
            // 
            // Tabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewTabela);
            this.Name = "Tabela";
            this.Size = new System.Drawing.Size(700, 322);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewTabela;
        private System.Windows.Forms.ColumnHeader Litera;
        private System.Windows.Forms.ColumnHeader Panstwo;
        private System.Windows.Forms.ColumnHeader Miasto;
        private System.Windows.Forms.ColumnHeader Roslina;
        private System.Windows.Forms.ColumnHeader Zwierze;
        private System.Windows.Forms.ColumnHeader Rzecz;
        private System.Windows.Forms.ColumnHeader Imie;
        private System.Windows.Forms.ColumnHeader Gracz;
    }
}

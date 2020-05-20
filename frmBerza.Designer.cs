namespace PraviProjekatBerza
{
    partial class frmBerza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBerza = new System.Windows.Forms.Panel();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnKupi = new System.Windows.Forms.Button();
            this.btnOsoba = new System.Windows.Forms.Button();
            this.pnlBerza.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBerza
            // 
            this.pnlBerza.Controls.Add(this.btnOsoba);
            this.pnlBerza.Controls.Add(this.btnKupi);
            this.pnlBerza.Controls.Add(this.btnDetalji);
            this.pnlBerza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBerza.Location = new System.Drawing.Point(0, 0);
            this.pnlBerza.Name = "pnlBerza";
            this.pnlBerza.Size = new System.Drawing.Size(800, 450);
            this.pnlBerza.TabIndex = 0;
            this.pnlBerza.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBerza_Paint);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(71, 398);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(75, 23);
            this.btnDetalji.TabIndex = 0;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            // 
            // btnKupi
            // 
            this.btnKupi.Location = new System.Drawing.Point(359, 398);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(75, 23);
            this.btnKupi.TabIndex = 1;
            this.btnKupi.Text = "Kupi";
            this.btnKupi.UseVisualStyleBackColor = true;
            // 
            // btnOsoba
            // 
            this.btnOsoba.Location = new System.Drawing.Point(626, 398);
            this.btnOsoba.Name = "btnOsoba";
            this.btnOsoba.Size = new System.Drawing.Size(75, 23);
            this.btnOsoba.TabIndex = 2;
            this.btnOsoba.Text = "Osoba";
            this.btnOsoba.UseVisualStyleBackColor = true;
            // 
            // frmBerza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBerza);
            this.Name = "frmBerza";
            this.Text = "Berza";
            this.pnlBerza.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBerza;
        private System.Windows.Forms.Button btnOsoba;
        private System.Windows.Forms.Button btnKupi;
        private System.Windows.Forms.Button btnDetalji;
    }
}
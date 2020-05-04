namespace PraviProjekatBerza
{
    partial class frmMeni
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
            this.pnlMeni = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlMeni
            // 
            this.pnlMeni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMeni.Location = new System.Drawing.Point(0, 0);
            this.pnlMeni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMeni.Name = "pnlMeni";
            this.pnlMeni.Size = new System.Drawing.Size(384, 361);
            this.pnlMeni.TabIndex = 0;
            this.pnlMeni.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMeni_Paint);
            // 
            // frmMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.pnlMeni);
            this.Name = "frmMeni";
            this.Text = "Meni";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMeni;
    }
}


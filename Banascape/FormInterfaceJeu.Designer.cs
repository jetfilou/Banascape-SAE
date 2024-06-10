namespace Banascape
{
    partial class frmInterfaceJeu
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
            this.labyrinthePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labyrinthePanel
            // 
            this.labyrinthePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labyrinthePanel.Location = new System.Drawing.Point(0, 0);
            this.labyrinthePanel.Name = "labyrinthePanel";
            this.labyrinthePanel.Size = new System.Drawing.Size(914, 600);
            this.labyrinthePanel.TabIndex = 0;
            this.labyrinthePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            // 
            // frmInterfaceJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.ControlBox = false;
            this.Controls.Add(this.labyrinthePanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInterfaceJeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banascape";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel labyrinthePanel;
    }
}

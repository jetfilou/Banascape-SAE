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
            labyrinthePanel = new Panel();
            SuspendLayout();
            // 
            // labyrinthePanel
            // 
            labyrinthePanel.BackColor = Color.Black;
            labyrinthePanel.BackgroundImageLayout = ImageLayout.Zoom;
            labyrinthePanel.Dock = DockStyle.Fill;
            labyrinthePanel.Location = new Point(0, 0);
            labyrinthePanel.Margin = new Padding(3, 2, 3, 2);
            labyrinthePanel.Name = "labyrinthePanel";
            labyrinthePanel.Size = new Size(1924, 1115);
            labyrinthePanel.TabIndex = 0;
            labyrinthePanel.Paint += OnPaint;
            // 
            // frmInterfaceJeu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1924, 1115);
            ControlBox = false;
            Controls.Add(labyrinthePanel);
            Margin = new Padding(1);
            Name = "frmInterfaceJeu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Banascape";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel labyrinthePanel;
    }
}

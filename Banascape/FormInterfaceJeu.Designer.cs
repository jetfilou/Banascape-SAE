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
            lblPoint = new Label();
            lblNiveau = new Label();
            panel1 = new Panel();
            picObjet = new PictureBox();
            picCoeur2 = new PictureBox();
            picCoeur1 = new PictureBox();
            picClef = new PictureBox();
            labyrinthePanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picObjet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCoeur2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCoeur1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClef).BeginInit();
            SuspendLayout();
            // 
            // labyrinthePanel
            // 
            labyrinthePanel.BackColor = Color.Black;
            labyrinthePanel.BackgroundImageLayout = ImageLayout.Zoom;
            labyrinthePanel.Controls.Add(lblPoint);
            labyrinthePanel.Controls.Add(lblNiveau);
            labyrinthePanel.Controls.Add(panel1);
            labyrinthePanel.Dock = DockStyle.Fill;
            labyrinthePanel.Location = new Point(0, 0);
            labyrinthePanel.Name = "labyrinthePanel";
            labyrinthePanel.Size = new Size(1924, 1055);
            labyrinthePanel.TabIndex = 0;
            labyrinthePanel.Paint += OnPaint;
            // 
            // lblPoint
            // 
            lblPoint.AutoSize = true;
            lblPoint.BackColor = Color.Transparent;
            lblPoint.Cursor = Cursors.No;
            lblPoint.Dock = DockStyle.Right;
            lblPoint.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPoint.ForeColor = Color.White;
            lblPoint.Location = new Point(1766, 0);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(158, 39);
            lblPoint.TabIndex = 6;
            lblPoint.Text = "Points : 0";
            lblPoint.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNiveau
            // 
            lblNiveau.AutoSize = true;
            lblNiveau.BackColor = Color.Transparent;
            lblNiveau.Cursor = Cursors.No;
            lblNiveau.Dock = DockStyle.Bottom;
            lblNiveau.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNiveau.ForeColor = Color.White;
            lblNiveau.Location = new Point(0, 933);
            lblNiveau.Name = "lblNiveau";
            lblNiveau.Size = new Size(170, 39);
            lblNiveau.TabIndex = 1;
            lblNiveau.Text = "Niveau : 1";
            lblNiveau.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(picObjet);
            panel1.Controls.Add(picCoeur2);
            panel1.Controls.Add(picCoeur1);
            panel1.Controls.Add(picClef);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 972);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 83);
            panel1.TabIndex = 5;
            // 
            // picObjet
            // 
            picObjet.BackColor = Color.LightGray;
            picObjet.Dock = DockStyle.Right;
            picObjet.Location = new Point(1786, 0);
            picObjet.Margin = new Padding(3, 4, 3, 4);
            picObjet.MaximumSize = new Size(69, 80);
            picObjet.Name = "picObjet";
            picObjet.Size = new Size(69, 80);
            picObjet.SizeMode = PictureBoxSizeMode.StretchImage;
            picObjet.TabIndex = 5;
            picObjet.TabStop = false;
            // 
            // picCoeur2
            // 
            picCoeur2.BackColor = Color.Transparent;
            picCoeur2.Image = Properties.Resources.coeur_plein;
            picCoeur2.Location = new Point(90, 5);
            picCoeur2.Margin = new Padding(3, 4, 3, 4);
            picCoeur2.MaximumSize = new Size(80, 73);
            picCoeur2.Name = "picCoeur2";
            picCoeur2.Size = new Size(80, 73);
            picCoeur2.SizeMode = PictureBoxSizeMode.StretchImage;
            picCoeur2.TabIndex = 3;
            picCoeur2.TabStop = false;
            // 
            // picCoeur1
            // 
            picCoeur1.BackColor = Color.Transparent;
            picCoeur1.Image = Properties.Resources.coeur_plein;
            picCoeur1.Location = new Point(3, 5);
            picCoeur1.Margin = new Padding(3, 4, 3, 4);
            picCoeur1.MaximumSize = new Size(80, 73);
            picCoeur1.Name = "picCoeur1";
            picCoeur1.Size = new Size(80, 73);
            picCoeur1.SizeMode = PictureBoxSizeMode.StretchImage;
            picCoeur1.TabIndex = 4;
            picCoeur1.TabStop = false;
            // 
            // picClef
            // 
            picClef.BackColor = Color.Transparent;
            picClef.Dock = DockStyle.Right;
            picClef.Image = Properties.Resources.clef;
            picClef.Location = new Point(1855, 0);
            picClef.Margin = new Padding(3, 4, 3, 4);
            picClef.MaximumSize = new Size(69, 80);
            picClef.Name = "picClef";
            picClef.Size = new Size(69, 80);
            picClef.SizeMode = PictureBoxSizeMode.StretchImage;
            picClef.TabIndex = 2;
            picClef.TabStop = false;
            // 
            // frmInterfaceJeu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1924, 1055);
            ControlBox = false;
            Controls.Add(labyrinthePanel);
            Margin = new Padding(1);
            Name = "frmInterfaceJeu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Banascape";
            labyrinthePanel.ResumeLayout(false);
            labyrinthePanel.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picObjet).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCoeur2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCoeur1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClef).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel labyrinthePanel;
        private Label lblNiveau;
        private PictureBox picClef;
        private PictureBox picCoeur2;
        private PictureBox picCoeur1;
        private Panel panel1;
        private Label lblPoint;
        private PictureBox picObjet;
    }
}

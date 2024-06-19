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
            labyrinthePanel.Margin = new Padding(3, 2, 3, 2);
            labyrinthePanel.Name = "labyrinthePanel";
            labyrinthePanel.Size = new Size(1684, 791);
            labyrinthePanel.TabIndex = 0;
            labyrinthePanel.Paint += OnPaint;
            // 
            // lblPoint
            // 
            lblPoint.AutoSize = true;
            lblPoint.BackColor = Color.Transparent;
            lblPoint.Cursor = Cursors.No;
            lblPoint.Dock = DockStyle.Right;
            lblPoint.Font = new Font("Bahnschrift", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPoint.ForeColor = Color.White;
            lblPoint.Location = new Point(1558, 0);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(126, 33);
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
            lblNiveau.Font = new Font("Bahnschrift", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNiveau.ForeColor = Color.White;
            lblNiveau.Location = new Point(0, 707);
            lblNiveau.Name = "lblNiveau";
            lblNiveau.Size = new Size(127, 33);
            lblNiveau.TabIndex = 1;
            lblNiveau.Text = "Niveau : 1";
            lblNiveau.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(picObjet);
            panel1.Controls.Add(picCoeur2);
            panel1.Controls.Add(picCoeur1);
            panel1.Controls.Add(picClef);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 740);
            panel1.Name = "panel1";
            panel1.Size = new Size(1684, 51);
            panel1.TabIndex = 5;
            // 
            // picObjet
            // 
            picObjet.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            picObjet.BackColor = Color.Transparent;
            picObjet.BorderStyle = BorderStyle.Fixed3D;
            picObjet.Location = new Point(1535, 6);
            picObjet.MaximumSize = new Size(53, 46);
            picObjet.Name = "picObjet";
            picObjet.Size = new Size(53, 46);
            picObjet.SizeMode = PictureBoxSizeMode.StretchImage;
            picObjet.TabIndex = 5;
            picObjet.TabStop = false;
            // 
            // picCoeur2
            // 
            picCoeur2.BackColor = Color.Transparent;
            picCoeur2.Image = Properties.Resources.coeur_plein;
            picCoeur2.Location = new Point(79, 0);
            picCoeur2.MaximumSize = new Size(61, 48);
            picCoeur2.Name = "picCoeur2";
            picCoeur2.Size = new Size(61, 48);
            picCoeur2.SizeMode = PictureBoxSizeMode.StretchImage;
            picCoeur2.TabIndex = 3;
            picCoeur2.TabStop = false;
            // 
            // picCoeur1
            // 
            picCoeur1.BackColor = Color.Transparent;
            picCoeur1.Image = Properties.Resources.coeur_plein;
            picCoeur1.Location = new Point(12, 0);
            picCoeur1.MaximumSize = new Size(61, 48);
            picCoeur1.Name = "picCoeur1";
            picCoeur1.Size = new Size(61, 48);
            picCoeur1.SizeMode = PictureBoxSizeMode.StretchImage;
            picCoeur1.TabIndex = 4;
            picCoeur1.TabStop = false;
            // 
            // picClef
            // 
            picClef.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            picClef.BackColor = Color.Transparent;
            picClef.Image = Properties.Resources.clef;
            picClef.Location = new Point(1589, 3);
            picClef.Margin = new Padding(500);
            picClef.MaximumSize = new Size(60, 60);
            picClef.Name = "picClef";
            picClef.Size = new Size(52, 48);
            picClef.SizeMode = PictureBoxSizeMode.StretchImage;
            picClef.TabIndex = 2;
            picClef.TabStop = false;
            // 
            // frmInterfaceJeu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1684, 791);
            ControlBox = false;
            Controls.Add(labyrinthePanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(1);
            Name = "frmInterfaceJeu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Banascape";
            WindowState = FormWindowState.Maximized;
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

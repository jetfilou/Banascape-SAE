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
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            picObjet = new PictureBox();
            picCoeur2 = new PictureBox();
            picCoeur1 = new PictureBox();
            picClef = new PictureBox();
            labyrinthePanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            lblPoint.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPoint.ForeColor = Color.White;
            lblPoint.Location = new Point(1557, 0);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(127, 31);
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
            lblNiveau.Location = new Point(0, 698);
            lblNiveau.Name = "lblNiveau";
            lblNiveau.Size = new Size(136, 31);
            lblNiveau.TabIndex = 1;
            lblNiveau.Text = "Niveau : 1";
            lblNiveau.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BackgroundImage = Properties.Resources._62__2_;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(picObjet);
            panel1.Controls.Add(picCoeur2);
            panel1.Controls.Add(picCoeur1);
            panel1.Controls.Add(picClef);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 729);
            panel1.Name = "panel1";
            panel1.Size = new Size(1684, 62);
            panel1.TabIndex = 5;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Dock = DockStyle.Right;
            pictureBox5.Location = new Point(1649, 29);
            pictureBox5.MaximumSize = new Size(60, 60);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 4);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.vise;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(1654, 31);
            pictureBox3.MaximumSize = new Size(30, 30);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.vise;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(1654, -2);
            pictureBox4.MaximumSize = new Size(30, 30);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.vise;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Location = new Point(0, 33);
            pictureBox2.MaximumSize = new Size(30, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.vise;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.MaximumSize = new Size(30, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // picObjet
            // 
            picObjet.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            picObjet.BackColor = Color.LightGray;
            picObjet.Location = new Point(1532, 10);
            picObjet.MaximumSize = new Size(40, 40);
            picObjet.Name = "picObjet";
            picObjet.Size = new Size(40, 40);
            picObjet.SizeMode = PictureBoxSizeMode.StretchImage;
            picObjet.TabIndex = 5;
            picObjet.TabStop = false;
            // 
            // picCoeur2
            // 
            picCoeur2.BackColor = Color.Transparent;
            picCoeur2.Image = Properties.Resources.coeur_plein;
            picCoeur2.Location = new Point(118, 3);
            picCoeur2.MaximumSize = new Size(70, 55);
            picCoeur2.Name = "picCoeur2";
            picCoeur2.Size = new Size(70, 55);
            picCoeur2.SizeMode = PictureBoxSizeMode.StretchImage;
            picCoeur2.TabIndex = 3;
            picCoeur2.TabStop = false;
            // 
            // picCoeur1
            // 
            picCoeur1.BackColor = Color.Transparent;
            picCoeur1.Image = Properties.Resources.coeur_plein;
            picCoeur1.Location = new Point(36, 3);
            picCoeur1.MaximumSize = new Size(70, 55);
            picCoeur1.Name = "picCoeur1";
            picCoeur1.Size = new Size(70, 55);
            picCoeur1.SizeMode = PictureBoxSizeMode.StretchImage;
            picCoeur1.TabIndex = 4;
            picCoeur1.TabStop = false;
            // 
            // picClef
            // 
            picClef.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            picClef.BackColor = Color.Transparent;
            picClef.Image = Properties.Resources.clef;
            picClef.Location = new Point(1586, 2);
            picClef.Margin = new Padding(500);
            picClef.MaximumSize = new Size(60, 60);
            picClef.Name = "picClef";
            picClef.Size = new Size(60, 60);
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
            Margin = new Padding(1);
            Name = "frmInterfaceJeu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Banascape";
            labyrinthePanel.ResumeLayout(false);
            labyrinthePanel.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}

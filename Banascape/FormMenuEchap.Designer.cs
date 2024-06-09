namespace Banascape
{
    partial class FormMenuEchap
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
            picMenuEchap = new PictureBox();
            lblMenu = new Label();
            btnJouer = new Button();
            btnQuitter = new Button();
            picVie = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picMenuEchap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVie).BeginInit();
            SuspendLayout();
            // 
            // picMenuEchap
            // 
            picMenuEchap.BackColor = Color.Transparent;
            picMenuEchap.Dock = DockStyle.Fill;
            picMenuEchap.Image = Properties.Resources.Menu_vierge;
            picMenuEchap.Location = new Point(0, 0);
            picMenuEchap.Name = "picMenuEchap";
            picMenuEchap.Size = new Size(383, 511);
            picMenuEchap.SizeMode = PictureBoxSizeMode.StretchImage;
            picMenuEchap.TabIndex = 2;
            picMenuEchap.TabStop = false;
            // 
            // lblMenu
            // 
            lblMenu.Anchor = AnchorStyles.Top;
            lblMenu.AutoSize = true;
            lblMenu.BackColor = Color.Transparent;
            lblMenu.Font = new Font("Circular Std Medium", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.ForeColor = Color.White;
            lblMenu.Location = new Point(121, 434);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(145, 51);
            lblMenu.TabIndex = 4;
            lblMenu.Text = "MENU";
            // 
            // btnJouer
            // 
            btnJouer.Anchor = AnchorStyles.Top;
            btnJouer.BackColor = Color.Transparent;
            btnJouer.BackgroundImage = Properties.Resources.bouton_carre_play;
            btnJouer.BackgroundImageLayout = ImageLayout.Zoom;
            btnJouer.Cursor = Cursors.PanNW;
            btnJouer.FlatAppearance.BorderColor = Color.White;
            btnJouer.FlatAppearance.BorderSize = 0;
            btnJouer.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnJouer.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnJouer.FlatStyle = FlatStyle.Flat;
            btnJouer.Location = new Point(148, 44);
            btnJouer.Margin = new Padding(2);
            btnJouer.Name = "btnJouer";
            btnJouer.Size = new Size(89, 88);
            btnJouer.TabIndex = 5;
            btnJouer.UseVisualStyleBackColor = false;
            btnJouer.Click += btnPlay_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.Anchor = AnchorStyles.Top;
            btnQuitter.BackColor = Color.Transparent;
            btnQuitter.BackgroundImage = Properties.Resources.bouton_carre_quitter;
            btnQuitter.BackgroundImageLayout = ImageLayout.Zoom;
            btnQuitter.Cursor = Cursors.PanNW;
            btnQuitter.FlatAppearance.BorderColor = Color.White;
            btnQuitter.FlatAppearance.BorderSize = 0;
            btnQuitter.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnQuitter.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnQuitter.FlatStyle = FlatStyle.Flat;
            btnQuitter.Location = new Point(148, 156);
            btnQuitter.Margin = new Padding(2);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(89, 88);
            btnQuitter.TabIndex = 6;
            btnQuitter.UseVisualStyleBackColor = false;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // picVie
            // 
            picVie.Anchor = AnchorStyles.Top;
            picVie.BackColor = Color.Transparent;
            picVie.Image = Properties.Resources.vie;
            picVie.Location = new Point(106, 283);
            picVie.Name = "picVie";
            picVie.Size = new Size(160, 71);
            picVie.SizeMode = PictureBoxSizeMode.Zoom;
            picVie.TabIndex = 7;
            picVie.TabStop = false;
            // 
            // FormMenuEchap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(383, 511);
            Controls.Add(picVie);
            Controls.Add(btnQuitter);
            Controls.Add(btnJouer);
            Controls.Add(lblMenu);
            Controls.Add(picMenuEchap);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenuEchap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenuEchap";
            ((System.ComponentModel.ISupportInitialize)picMenuEchap).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picMenuEchap;
        private Label lblMenu;
        private Button btnJouer;
        private Button btnQuitter;
        private PictureBox picVie;
    }
}
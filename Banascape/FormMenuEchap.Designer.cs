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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)picMenuEchap).BeginInit();
            SuspendLayout();
            // 
            // picMenuEchap
            // 
            picMenuEchap.BackColor = Color.Transparent;
            picMenuEchap.Dock = DockStyle.Fill;
            picMenuEchap.Image = Properties.Resources.Menu_vierge;
            picMenuEchap.Location = new Point(0, 0);
            picMenuEchap.Margin = new Padding(3, 2, 3, 2);
            picMenuEchap.Name = "picMenuEchap";
            picMenuEchap.Size = new Size(335, 383);
            picMenuEchap.SizeMode = PictureBoxSizeMode.StretchImage;
            picMenuEchap.TabIndex = 2;
            picMenuEchap.TabStop = false;
            // 
            // lblMenu
            // 
            lblMenu.Anchor = AnchorStyles.Top;
            lblMenu.AutoSize = true;
            lblMenu.BackColor = Color.Transparent;
            lblMenu.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.ForeColor = Color.White;
            lblMenu.Location = new Point(106, 326);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(115, 37);
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
            btnJouer.Location = new Point(130, 33);
            btnJouer.Margin = new Padding(2);
            btnJouer.Name = "btnJouer";
            btnJouer.Size = new Size(78, 66);
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
            btnQuitter.Location = new Point(130, 199);
            btnQuitter.Margin = new Padding(2);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(78, 66);
            btnQuitter.TabIndex = 6;
            btnQuitter.UseVisualStyleBackColor = false;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.bouton_retour;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.PanNW;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(130, 117);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 66);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            // 
            // FormMenuEchap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(335, 383);
            Controls.Add(button1);
            Controls.Add(btnQuitter);
            Controls.Add(btnJouer);
            Controls.Add(lblMenu);
            Controls.Add(picMenuEchap);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMenuEchap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenuEchap";
            ((System.ComponentModel.ISupportInitialize)picMenuEchap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picMenuEchap;
        private Label lblMenu;
        private Button btnJouer;
        private Button btnQuitter;
        private Button button1;
    }
}
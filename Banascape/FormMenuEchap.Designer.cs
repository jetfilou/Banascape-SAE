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
            lblMenu = new Label();
            btnJouer = new Button();
            btnQuitter = new Button();
            btnRetourMenuPrincipal = new Button();
            SuspendLayout();
            // 
            // lblMenu
            // 
            lblMenu.Anchor = AnchorStyles.Top;
            lblMenu.AutoSize = true;
            lblMenu.BackColor = Color.Transparent;
            lblMenu.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.ForeColor = Color.White;
            lblMenu.Location = new Point(147, 543);
            lblMenu.Margin = new Padding(4, 0, 4, 0);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(170, 55);
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
            btnJouer.Location = new Point(176, 55);
            btnJouer.Name = "btnJouer";
            btnJouer.Size = new Size(111, 110);
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
            btnQuitter.Location = new Point(176, 332);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(111, 110);
            btnQuitter.TabIndex = 6;
            btnQuitter.UseVisualStyleBackColor = false;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // btnRetourMenuPrincipal
            // 
            btnRetourMenuPrincipal.Anchor = AnchorStyles.Top;
            btnRetourMenuPrincipal.BackColor = Color.Transparent;
            btnRetourMenuPrincipal.BackgroundImage = Properties.Resources.bouton_retour;
            btnRetourMenuPrincipal.BackgroundImageLayout = ImageLayout.Zoom;
            btnRetourMenuPrincipal.Cursor = Cursors.PanNW;
            btnRetourMenuPrincipal.FlatAppearance.BorderColor = Color.White;
            btnRetourMenuPrincipal.FlatAppearance.BorderSize = 0;
            btnRetourMenuPrincipal.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRetourMenuPrincipal.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRetourMenuPrincipal.FlatStyle = FlatStyle.Flat;
            btnRetourMenuPrincipal.Location = new Point(176, 195);
            btnRetourMenuPrincipal.Name = "btnRetourMenuPrincipal";
            btnRetourMenuPrincipal.Size = new Size(111, 110);
            btnRetourMenuPrincipal.TabIndex = 7;
            btnRetourMenuPrincipal.UseVisualStyleBackColor = false;
            btnRetourMenuPrincipal.Click += btnRetourMenuPrincipal_Click;
            // 
            // FormMenuEchap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.Menu_vierge;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(459, 638);
            Controls.Add(btnRetourMenuPrincipal);
            Controls.Add(btnQuitter);
            Controls.Add(btnJouer);
            Controls.Add(lblMenu);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMenuEchap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenuEchap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMenu;
        private Button btnJouer;
        private Button btnQuitter;
        private Button btnRetourMenuPrincipal;
    }
}
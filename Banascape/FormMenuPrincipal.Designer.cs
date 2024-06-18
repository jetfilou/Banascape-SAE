namespace Banascape
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            btnReprendre = new Button();
            lblBanascape = new Label();
            btnNouvellePartie = new Button();
            btnQuitter = new Button();
            btnClassement = new Button();
            SuspendLayout();
            // 
            // btnReprendre
            // 
            btnReprendre.Anchor = AnchorStyles.Top;
            btnReprendre.BackColor = Color.Transparent;
            btnReprendre.BackgroundImage = Properties.Resources.Bouton1;
            btnReprendre.BackgroundImageLayout = ImageLayout.Zoom;
            btnReprendre.Cursor = Cursors.PanNW;
            btnReprendre.FlatAppearance.BorderSize = 0;
            btnReprendre.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnReprendre.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnReprendre.FlatStyle = FlatStyle.Flat;
            btnReprendre.Font = new Font("Bahnschrift Condensed", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReprendre.ForeColor = Color.Black;
            btnReprendre.Location = new Point(45, 202);
            btnReprendre.Margin = new Padding(3, 4, 3, 4);
            btnReprendre.Name = "btnReprendre";
            btnReprendre.Size = new Size(190, 66);
            btnReprendre.TabIndex = 1;
            btnReprendre.Text = "Reprendre";
            btnReprendre.UseVisualStyleBackColor = false;
            btnReprendre.Click += btnReprendre_Click;
            // 
            // lblBanascape
            // 
            lblBanascape.Anchor = AnchorStyles.Top;
            lblBanascape.AutoSize = true;
            lblBanascape.BackColor = Color.Transparent;
            lblBanascape.Font = new Font("Bahnschrift Condensed", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBanascape.ForeColor = Color.White;
            lblBanascape.Location = new Point(45, 99);
            lblBanascape.Name = "lblBanascape";
            lblBanascape.Size = new Size(203, 57);
            lblBanascape.TabIndex = 2;
            lblBanascape.Text = "BANASCAPE";
            // 
            // btnNouvellePartie
            // 
            btnNouvellePartie.Anchor = AnchorStyles.Top;
            btnNouvellePartie.BackColor = Color.Transparent;
            btnNouvellePartie.BackgroundImage = Properties.Resources.Bouton1;
            btnNouvellePartie.BackgroundImageLayout = ImageLayout.Zoom;
            btnNouvellePartie.Cursor = Cursors.PanNW;
            btnNouvellePartie.FlatAppearance.BorderSize = 0;
            btnNouvellePartie.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNouvellePartie.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnNouvellePartie.FlatStyle = FlatStyle.Flat;
            btnNouvellePartie.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNouvellePartie.ForeColor = Color.Black;
            btnNouvellePartie.Location = new Point(45, 302);
            btnNouvellePartie.Margin = new Padding(3, 4, 3, 4);
            btnNouvellePartie.Name = "btnNouvellePartie";
            btnNouvellePartie.Size = new Size(190, 66);
            btnNouvellePartie.TabIndex = 3;
            btnNouvellePartie.Text = "Nouvelle Partie";
            btnNouvellePartie.UseVisualStyleBackColor = false;
            btnNouvellePartie.Click += btnNouvellePartie_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.Anchor = AnchorStyles.Top;
            btnQuitter.BackColor = Color.Transparent;
            btnQuitter.BackgroundImage = Properties.Resources.Bouton1;
            btnQuitter.BackgroundImageLayout = ImageLayout.Zoom;
            btnQuitter.Cursor = Cursors.PanNW;
            btnQuitter.FlatAppearance.BorderSize = 0;
            btnQuitter.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnQuitter.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnQuitter.FlatStyle = FlatStyle.Flat;
            btnQuitter.Font = new Font("Bahnschrift Condensed", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuitter.ForeColor = Color.Black;
            btnQuitter.Location = new Point(45, 402);
            btnQuitter.Margin = new Padding(3, 4, 3, 4);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(190, 66);
            btnQuitter.TabIndex = 4;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = false;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // btnClassement
            // 
            btnClassement.Anchor = AnchorStyles.Bottom;
            btnClassement.BackColor = Color.Transparent;
            btnClassement.BackgroundImage = Properties.Resources.Bouton1;
            btnClassement.BackgroundImageLayout = ImageLayout.Zoom;
            btnClassement.Cursor = Cursors.PanNW;
            btnClassement.FlatAppearance.BorderSize = 0;
            btnClassement.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClassement.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClassement.FlatStyle = FlatStyle.Flat;
            btnClassement.Font = new Font("Bahnschrift Condensed", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClassement.ForeColor = Color.Black;
            btnClassement.Location = new Point(705, 514);
            btnClassement.Margin = new Padding(3, 4, 3, 4);
            btnClassement.Name = "btnClassement";
            btnClassement.Size = new Size(185, 56);
            btnClassement.TabIndex = 5;
            btnClassement.Text = "Classement";
            btnClassement.UseVisualStyleBackColor = false;
            btnClassement.Click += btnClassement_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.fond;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            ControlBox = false;
            Controls.Add(btnClassement);
            Controls.Add(btnQuitter);
            Controls.Add(btnNouvellePartie);
            Controls.Add(lblBanascape);
            Controls.Add(btnReprendre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Banascape";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnReprendre;
        private Label lblBanascape;
        private Button btnNouvellePartie;
        private Button btnQuitter;
        private Button btnClassement;
    }
}

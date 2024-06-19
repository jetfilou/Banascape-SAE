namespace Banascape
{
    partial class frmGameOver
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
            lblGameOver = new Label();
            lblNiveau = new Label();
            lblScore = new Label();
            btnQuitter = new Button();
            lblResultatNiveau = new Label();
            lblResultatScore = new Label();
            btnReplay = new Button();
            lblPseudoJoueur = new Label();
            lblPseudo = new Label();
            SuspendLayout();
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = true;
            lblGameOver.BackColor = Color.Transparent;
            lblGameOver.Font = new Font("Bahnschrift Condensed", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGameOver.ForeColor = Color.White;
            lblGameOver.Location = new Point(178, 28);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(159, 46);
            lblGameOver.TabIndex = 0;
            lblGameOver.Text = "GAME OVER";
            // 
            // lblNiveau
            // 
            lblNiveau.AutoSize = true;
            lblNiveau.BackColor = Color.Transparent;
            lblNiveau.Font = new Font("Bahnschrift", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNiveau.ForeColor = Color.White;
            lblNiveau.Location = new Point(192, 180);
            lblNiveau.Name = "lblNiveau";
            lblNiveau.Size = new Size(134, 36);
            lblNiveau.TabIndex = 1;
            lblNiveau.Text = "NIVEAU :";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Bahnschrift", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(204, 258);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(122, 36);
            lblScore.TabIndex = 2;
            lblScore.Text = "SCORE :";
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
            btnQuitter.Location = new Point(276, 331);
            btnQuitter.Margin = new Padding(2);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(61, 52);
            btnQuitter.TabIndex = 7;
            btnQuitter.UseVisualStyleBackColor = false;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // lblResultatNiveau
            // 
            lblResultatNiveau.AutoSize = true;
            lblResultatNiveau.BackColor = Color.Transparent;
            lblResultatNiveau.Font = new Font("Bahnschrift SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultatNiveau.ForeColor = Color.Gold;
            lblResultatNiveau.Location = new Point(250, 216);
            lblResultatNiveau.Name = "lblResultatNiveau";
            lblResultatNiveau.Size = new Size(24, 33);
            lblResultatNiveau.TabIndex = 8;
            lblResultatNiveau.Text = "1";
            lblResultatNiveau.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResultatScore
            // 
            lblResultatScore.AutoSize = true;
            lblResultatScore.BackColor = Color.Transparent;
            lblResultatScore.Font = new Font("Bahnschrift SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultatScore.ForeColor = Color.Gold;
            lblResultatScore.Location = new Point(244, 303);
            lblResultatScore.Name = "lblResultatScore";
            lblResultatScore.Size = new Size(30, 33);
            lblResultatScore.TabIndex = 9;
            lblResultatScore.Text = "0";
            lblResultatScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReplay
            // 
            btnReplay.Anchor = AnchorStyles.Top;
            btnReplay.BackColor = Color.Transparent;
            btnReplay.BackgroundImage = Properties.Resources.bouton_carre_play;
            btnReplay.BackgroundImageLayout = ImageLayout.Zoom;
            btnReplay.Cursor = Cursors.PanNW;
            btnReplay.FlatAppearance.BorderColor = Color.White;
            btnReplay.FlatAppearance.BorderSize = 0;
            btnReplay.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnReplay.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnReplay.FlatStyle = FlatStyle.Flat;
            btnReplay.Location = new Point(178, 331);
            btnReplay.Margin = new Padding(2);
            btnReplay.Name = "btnReplay";
            btnReplay.Size = new Size(61, 52);
            btnReplay.TabIndex = 10;
            btnReplay.UseVisualStyleBackColor = false;
            btnReplay.Click += btnReplay_Click;
            // 
            // lblPseudoJoueur
            // 
            lblPseudoJoueur.AutoSize = true;
            lblPseudoJoueur.BackColor = Color.Transparent;
            lblPseudoJoueur.Font = new Font("Bahnschrift SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPseudoJoueur.ForeColor = Color.Gold;
            lblPseudoJoueur.Location = new Point(218, 147);
            lblPseudoJoueur.Name = "lblPseudoJoueur";
            lblPseudoJoueur.Size = new Size(87, 33);
            lblPseudoJoueur.TabIndex = 12;
            lblPseudoJoueur.Text = "Pedro";
            lblPseudoJoueur.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPseudo
            // 
            lblPseudo.AutoSize = true;
            lblPseudo.BackColor = Color.Transparent;
            lblPseudo.Font = new Font("Bahnschrift", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPseudo.ForeColor = Color.White;
            lblPseudo.Location = new Point(192, 100);
            lblPseudo.Name = "lblPseudo";
            lblPseudo.Size = new Size(143, 36);
            lblPseudo.TabIndex = 11;
            lblPseudo.Text = "PSEUDO :";
            // 
            // frmGameOver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fond_game_over;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(514, 394);
            ControlBox = false;
            Controls.Add(lblPseudoJoueur);
            Controls.Add(lblPseudo);
            Controls.Add(btnReplay);
            Controls.Add(lblResultatScore);
            Controls.Add(lblResultatNiveau);
            Controls.Add(btnQuitter);
            Controls.Add(lblScore);
            Controls.Add(lblNiveau);
            Controls.Add(lblGameOver);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "frmGameOver";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Over";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGameOver;
        private Label lblNiveau;
        private Label lblScore;
        private Button btnQuitter;
        private Label lblResultatNiveau;
        private Label lblResultatScore;
        private Button btnReplay;
        private Label lblPseudoJoueur;
        private Label lblPseudo;
    }
}
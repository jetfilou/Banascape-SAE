namespace Banascape
{
    partial class frmNouvellePartie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNouvellePartie));
            btnRetour = new Button();
            btnLancer = new Button();
            txtPseudo = new TextBox();
            lblPseudo = new Label();
            label2 = new Label();
            lblPartie = new Label();
            cmbDifficulte = new ComboBox();
            SuspendLayout();
            // 
            // btnRetour
            // 
            btnRetour.Anchor = AnchorStyles.Top;
            btnRetour.BackColor = Color.Transparent;
            btnRetour.BackgroundImage = Properties.Resources.bouton_retour;
            btnRetour.BackgroundImageLayout = ImageLayout.Zoom;
            btnRetour.Cursor = Cursors.PanNW;
            btnRetour.FlatAppearance.BorderColor = Color.White;
            btnRetour.FlatAppearance.BorderSize = 0;
            btnRetour.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRetour.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.Location = new Point(328, 27);
            btnRetour.Margin = new Padding(2);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(53, 52);
            btnRetour.TabIndex = 1;
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnLancer
            // 
            btnLancer.Anchor = AnchorStyles.Top;
            btnLancer.BackColor = Color.Transparent;
            btnLancer.BackgroundImage = Properties.Resources.Bouton1;
            btnLancer.BackgroundImageLayout = ImageLayout.Zoom;
            btnLancer.Cursor = Cursors.PanNW;
            btnLancer.FlatAppearance.BorderSize = 0;
            btnLancer.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLancer.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLancer.FlatStyle = FlatStyle.Flat;
            btnLancer.Font = new Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLancer.ForeColor = Color.Black;
            btnLancer.Location = new Point(128, 406);
            btnLancer.Margin = new Padding(3, 4, 3, 4);
            btnLancer.Name = "btnLancer";
            btnLancer.Size = new Size(170, 50);
            btnLancer.TabIndex = 2;
            btnLancer.Text = "Lancer";
            btnLancer.UseVisualStyleBackColor = false;
            // 
            // txtPseudo
            // 
            txtPseudo.Anchor = AnchorStyles.Top;
            txtPseudo.BackColor = Color.White;
            txtPseudo.BorderStyle = BorderStyle.FixedSingle;
            txtPseudo.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPseudo.Location = new Point(138, 184);
            txtPseudo.MaxLength = 10;
            txtPseudo.Name = "txtPseudo";
            txtPseudo.Size = new Size(151, 39);
            txtPseudo.TabIndex = 3;
            // 
            // lblPseudo
            // 
            lblPseudo.Anchor = AnchorStyles.Top;
            lblPseudo.AutoSize = true;
            lblPseudo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPseudo.Location = new Point(141, 126);
            lblPseudo.Name = "lblPseudo";
            lblPseudo.Size = new Size(144, 23);
            lblPseudo.TabIndex = 4;
            lblPseudo.Text = "Votre pseudo ?";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(150, 266);
            label2.Name = "label2";
            label2.Size = new Size(127, 23);
            label2.TabIndex = 5;
            label2.Text = "La difficulté ?";
            // 
            // lblPartie
            // 
            lblPartie.Anchor = AnchorStyles.Top;
            lblPartie.AutoSize = true;
            lblPartie.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPartie.Location = new Point(165, 47);
            lblPartie.Name = "lblPartie";
            lblPartie.Size = new Size(97, 32);
            lblPartie.TabIndex = 8;
            lblPartie.Text = "Partie";
            // 
            // cmbDifficulte
            // 
            cmbDifficulte.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDifficulte.FormattingEnabled = true;
            cmbDifficulte.Items.AddRange(new object[] { "Normal", "Difficile" });
            cmbDifficulte.Location = new Point(159, 320);
            cmbDifficulte.Name = "cmbDifficulte";
            cmbDifficulte.Size = new Size(108, 34);
            cmbDifficulte.TabIndex = 11;
            // 
            // frmNouvellePartie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 481);
            ControlBox = false;
            Controls.Add(cmbDifficulte);
            Controls.Add(lblPartie);
            Controls.Add(label2);
            Controls.Add(lblPseudo);
            Controls.Add(txtPseudo);
            Controls.Add(btnLancer);
            Controls.Add(btnRetour);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmNouvellePartie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Banascape";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetour;
        private Button btnLancer;
        private TextBox txtPseudo;
        private Label lblPseudo;
        private Label label2;
        private Label lblPartie;
        private ComboBox cmbDifficulte;
    }
}
namespace Banascape
{
    partial class frmClassement
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
            btnRetour = new Button();
            picTrophee = new PictureBox();
            lblTop1 = new Label();
            lblTop2 = new Label();
            lblTop3 = new Label();
            lblClassement = new Label();
            ((System.ComponentModel.ISupportInitialize)picTrophee).BeginInit();
            SuspendLayout();
            // 
            // btnRetour
            // 
            btnRetour.BackColor = Color.Transparent;
            btnRetour.BackgroundImage = Properties.Resources.bouton_retour;
            btnRetour.BackgroundImageLayout = ImageLayout.Zoom;
            btnRetour.Cursor = Cursors.PanNW;
            btnRetour.FlatAppearance.BorderColor = Color.White;
            btnRetour.FlatAppearance.BorderSize = 0;
            btnRetour.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRetour.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.Location = new Point(133, 348);
            btnRetour.Margin = new Padding(2);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(61, 52);
            btnRetour.TabIndex = 0;
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnRetour_Click;
            // 
            // picTrophee
            // 
            picTrophee.BackColor = Color.Transparent;
            picTrophee.Image = Properties.Resources.trophee;
            picTrophee.Location = new Point(122, 24);
            picTrophee.Margin = new Padding(3, 2, 3, 2);
            picTrophee.Name = "picTrophee";
            picTrophee.Size = new Size(83, 71);
            picTrophee.SizeMode = PictureBoxSizeMode.Zoom;
            picTrophee.TabIndex = 2;
            picTrophee.TabStop = false;
            // 
            // lblTop1
            // 
            lblTop1.AutoSize = true;
            lblTop1.BackColor = Color.Transparent;
            lblTop1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTop1.ForeColor = Color.White;
            lblTop1.Location = new Point(153, 150);
            lblTop1.Name = "lblTop1";
            lblTop1.Size = new Size(21, 24);
            lblTop1.TabIndex = 3;
            lblTop1.Text = "1";
            // 
            // lblTop2
            // 
            lblTop2.AutoSize = true;
            lblTop2.BackColor = Color.Transparent;
            lblTop2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTop2.ForeColor = Color.White;
            lblTop2.Location = new Point(82, 210);
            lblTop2.Name = "lblTop2";
            lblTop2.Size = new Size(21, 24);
            lblTop2.TabIndex = 4;
            lblTop2.Text = "2";
            // 
            // lblTop3
            // 
            lblTop3.AutoSize = true;
            lblTop3.BackColor = Color.Transparent;
            lblTop3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTop3.ForeColor = Color.White;
            lblTop3.Location = new Point(225, 210);
            lblTop3.Name = "lblTop3";
            lblTop3.Size = new Size(21, 24);
            lblTop3.TabIndex = 5;
            lblTop3.Text = "3";
            // 
            // lblClassement
            // 
            lblClassement.AutoSize = true;
            lblClassement.BackColor = Color.Transparent;
            lblClassement.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassement.ForeColor = Color.White;
            lblClassement.Location = new Point(82, 112);
            lblClassement.Name = "lblClassement";
            lblClassement.Size = new Size(164, 20);
            lblClassement.TabIndex = 6;
            lblClassement.Text = "Classement - Top 3";
            // 
            // frmClassement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.Menu_vierge;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(328, 418);
            Controls.Add(lblClassement);
            Controls.Add(lblTop3);
            Controls.Add(lblTop2);
            Controls.Add(lblTop1);
            Controls.Add(btnRetour);
            Controls.Add(picTrophee);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "frmClassement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Classement";
            ((System.ComponentModel.ISupportInitialize)picTrophee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetour;
        private PictureBox picTrophee;
        private Label lblTop1;
        private Label lblTop2;
        private Label lblTop3;
        private Label lblClassement;
    }
}
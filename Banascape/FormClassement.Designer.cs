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
            picMenuClassement = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picMenuClassement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            btnRetour.Location = new Point(165, 464);
            btnRetour.Margin = new Padding(2);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(70, 70);
            btnRetour.TabIndex = 0;
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnRetour_Click;
            // 
            // picMenuClassement
            // 
            picMenuClassement.BackColor = Color.Transparent;
            picMenuClassement.Image = Properties.Resources.Menu_vierge;
            picMenuClassement.Location = new Point(0, 0);
            picMenuClassement.Name = "picMenuClassement";
            picMenuClassement.Size = new Size(401, 558);
            picMenuClassement.SizeMode = PictureBoxSizeMode.StretchImage;
            picMenuClassement.TabIndex = 1;
            picMenuClassement.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.trophee;
            pictureBox1.Location = new Point(153, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // frmClassement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(401, 558);
            Controls.Add(btnRetour);
            Controls.Add(pictureBox1);
            Controls.Add(picMenuClassement);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "frmClassement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Classement";
            ((System.ComponentModel.ISupportInitialize)picMenuClassement).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRetour;
        private PictureBox picMenuClassement;
        private PictureBox pictureBox1;
    }
}
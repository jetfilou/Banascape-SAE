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
            SuspendLayout();
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(645, 376);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(112, 34);
            btnRetour.TabIndex = 0;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += this.btnRetour_Click;
            // 
            // frmClassement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRetour);
            Name = "frmClassement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Classement";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRetour;
    }
}
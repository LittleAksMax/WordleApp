namespace WordleWinForms
{
    partial class GameForm
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
            this.guessTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // guessTxtBox
            // 
            this.guessTxtBox.Location = new System.Drawing.Point(132, 507);
            this.guessTxtBox.Name = "guessTxtBox";
            this.guessTxtBox.Size = new System.Drawing.Size(153, 23);
            this.guessTxtBox.TabIndex = 0;
            this.guessTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guessTxtBox_KeyDown);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 542);
            this.Controls.Add(this.guessTxtBox);
            this.Name = "GameForm";
            this.Text = "Wordle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox guessTxtBox;
    }
}
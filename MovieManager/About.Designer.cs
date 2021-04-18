
namespace MovieManager
{
    partial class FormAbout
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
            this.RTBAbout = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTBAbout
            // 
            this.RTBAbout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBAbout.Location = new System.Drawing.Point(9, 10);
            this.RTBAbout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RTBAbout.Name = "RTBAbout";
            this.RTBAbout.ReadOnly = true;
            this.RTBAbout.Size = new System.Drawing.Size(583, 266);
            this.RTBAbout.TabIndex = 0;
            this.RTBAbout.TabStop = false;
            this.RTBAbout.Text = "Movie Manager Application\n\nThis application displays and manages a database of Mo" +
    "vies.\n\nAuthor:\t\tGeorge, Nick and Jack\nDate:\t\t04/17/2021\nVersion:\t0.1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(535, 337);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 19);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.RTBAbout);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAbout";
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBAbout;
        private System.Windows.Forms.Button btnClose;
    }
}
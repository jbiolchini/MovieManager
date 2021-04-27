
namespace MovieManager
{
    partial class FormUpdateMovie
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
            this.labelUpdateMovieScreen = new System.Windows.Forms.Label();
            this.labelMovieTitleUpdate = new System.Windows.Forms.Label();
            this.tbMovieTitleUpdate = new System.Windows.Forms.TextBox();
            this.btFindUpdate = new System.Windows.Forms.Button();
            this.labelYearUpdate = new System.Windows.Forms.Label();
            this.tbYearUpdate = new System.Windows.Forms.TextBox();
            this.labelDirectorUpdate = new System.Windows.Forms.Label();
            this.tbDirectorUpdate = new System.Windows.Forms.TextBox();
            this.labelGenreUpdate = new System.Windows.Forms.Label();
            this.comboBoxGenreUpdate = new System.Windows.Forms.ComboBox();
            this.labelRottenTomatoesScoreUpdate = new System.Windows.Forms.Label();
            this.tbRottenTomatoesScoreUpdate = new System.Windows.Forms.TextBox();
            this.labelBoxOfficeEarningsUpdate = new System.Windows.Forms.Label();
            this.tbBoxOfficeEarningsUpdate = new System.Windows.Forms.TextBox();
            this.panel1Update = new System.Windows.Forms.Panel();
            this.btCloseUpdate = new System.Windows.Forms.Button();
            this.btClearUpdate = new System.Windows.Forms.Button();
            this.btUpdateUpdate = new System.Windows.Forms.Button();
            this.panel1Update.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUpdateMovieScreen
            // 
            this.labelUpdateMovieScreen.AutoSize = true;
            this.labelUpdateMovieScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateMovieScreen.Location = new System.Drawing.Point(16, 11);
            this.labelUpdateMovieScreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUpdateMovieScreen.Name = "labelUpdateMovieScreen";
            this.labelUpdateMovieScreen.Size = new System.Drawing.Size(320, 36);
            this.labelUpdateMovieScreen.TabIndex = 0;
            this.labelUpdateMovieScreen.Text = "Update Movie Screen";
            // 
            // labelMovieTitleUpdate
            // 
            this.labelMovieTitleUpdate.AutoSize = true;
            this.labelMovieTitleUpdate.Location = new System.Drawing.Point(69, 78);
            this.labelMovieTitleUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMovieTitleUpdate.Name = "labelMovieTitleUpdate";
            this.labelMovieTitleUpdate.Size = new System.Drawing.Size(80, 17);
            this.labelMovieTitleUpdate.TabIndex = 1;
            this.labelMovieTitleUpdate.Text = "Movie Title:";
            // 
            // tbMovieTitleUpdate
            // 
            this.tbMovieTitleUpdate.Location = new System.Drawing.Point(156, 74);
            this.tbMovieTitleUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMovieTitleUpdate.Name = "tbMovieTitleUpdate";
            this.tbMovieTitleUpdate.Size = new System.Drawing.Size(395, 22);
            this.tbMovieTitleUpdate.TabIndex = 2;
            // 
            // btFindUpdate
            // 
            this.btFindUpdate.Location = new System.Drawing.Point(560, 71);
            this.btFindUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btFindUpdate.Name = "btFindUpdate";
            this.btFindUpdate.Size = new System.Drawing.Size(100, 28);
            this.btFindUpdate.TabIndex = 3;
            this.btFindUpdate.Text = "Find";
            this.btFindUpdate.UseVisualStyleBackColor = true;
            this.btFindUpdate.Click += new System.EventHandler(this.btFindUpdate_Click);
            // 
            // labelYearUpdate
            // 
            this.labelYearUpdate.AutoSize = true;
            this.labelYearUpdate.Location = new System.Drawing.Point(105, 127);
            this.labelYearUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYearUpdate.Name = "labelYearUpdate";
            this.labelYearUpdate.Size = new System.Drawing.Size(42, 17);
            this.labelYearUpdate.TabIndex = 4;
            this.labelYearUpdate.Text = "Year:";
            // 
            // tbYearUpdate
            // 
            this.tbYearUpdate.Location = new System.Drawing.Point(156, 123);
            this.tbYearUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbYearUpdate.Name = "tbYearUpdate";
            this.tbYearUpdate.Size = new System.Drawing.Size(153, 22);
            this.tbYearUpdate.TabIndex = 5;
            // 
            // labelDirectorUpdate
            // 
            this.labelDirectorUpdate.AutoSize = true;
            this.labelDirectorUpdate.Location = new System.Drawing.Point(85, 176);
            this.labelDirectorUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDirectorUpdate.Name = "labelDirectorUpdate";
            this.labelDirectorUpdate.Size = new System.Drawing.Size(62, 17);
            this.labelDirectorUpdate.TabIndex = 6;
            this.labelDirectorUpdate.Text = "Director:";
            // 
            // tbDirectorUpdate
            // 
            this.tbDirectorUpdate.Location = new System.Drawing.Point(156, 172);
            this.tbDirectorUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDirectorUpdate.Name = "tbDirectorUpdate";
            this.tbDirectorUpdate.Size = new System.Drawing.Size(249, 22);
            this.tbDirectorUpdate.TabIndex = 7;
            // 
            // labelGenreUpdate
            // 
            this.labelGenreUpdate.AutoSize = true;
            this.labelGenreUpdate.Location = new System.Drawing.Point(96, 225);
            this.labelGenreUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGenreUpdate.Name = "labelGenreUpdate";
            this.labelGenreUpdate.Size = new System.Drawing.Size(52, 17);
            this.labelGenreUpdate.TabIndex = 8;
            this.labelGenreUpdate.Text = "Genre:";
            // 
            // comboBoxGenreUpdate
            // 
            this.comboBoxGenreUpdate.FormattingEnabled = true;
            this.comboBoxGenreUpdate.Location = new System.Drawing.Point(156, 222);
            this.comboBoxGenreUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxGenreUpdate.Name = "comboBoxGenreUpdate";
            this.comboBoxGenreUpdate.Size = new System.Drawing.Size(249, 24);
            this.comboBoxGenreUpdate.TabIndex = 9;
            // 
            // labelRottenTomatoesScoreUpdate
            // 
            this.labelRottenTomatoesScoreUpdate.AutoSize = true;
            this.labelRottenTomatoesScoreUpdate.Location = new System.Drawing.Point(51, 295);
            this.labelRottenTomatoesScoreUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRottenTomatoesScoreUpdate.Name = "labelRottenTomatoesScoreUpdate";
            this.labelRottenTomatoesScoreUpdate.Size = new System.Drawing.Size(162, 17);
            this.labelRottenTomatoesScoreUpdate.TabIndex = 10;
            this.labelRottenTomatoesScoreUpdate.Text = "Rotten Tomatoes Score:";
            // 
            // tbRottenTomatoesScoreUpdate
            // 
            this.tbRottenTomatoesScoreUpdate.Location = new System.Drawing.Point(223, 292);
            this.tbRottenTomatoesScoreUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRottenTomatoesScoreUpdate.Name = "tbRottenTomatoesScoreUpdate";
            this.tbRottenTomatoesScoreUpdate.Size = new System.Drawing.Size(132, 22);
            this.tbRottenTomatoesScoreUpdate.TabIndex = 11;
            // 
            // labelBoxOfficeEarningsUpdate
            // 
            this.labelBoxOfficeEarningsUpdate.AutoSize = true;
            this.labelBoxOfficeEarningsUpdate.Location = new System.Drawing.Point(364, 295);
            this.labelBoxOfficeEarningsUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBoxOfficeEarningsUpdate.Name = "labelBoxOfficeEarningsUpdate";
            this.labelBoxOfficeEarningsUpdate.Size = new System.Drawing.Size(136, 17);
            this.labelBoxOfficeEarningsUpdate.TabIndex = 12;
            this.labelBoxOfficeEarningsUpdate.Text = "Box Office Earnings:";
            // 
            // tbBoxOfficeEarningsUpdate
            // 
            this.tbBoxOfficeEarningsUpdate.Location = new System.Drawing.Point(509, 292);
            this.tbBoxOfficeEarningsUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBoxOfficeEarningsUpdate.Name = "tbBoxOfficeEarningsUpdate";
            this.tbBoxOfficeEarningsUpdate.Size = new System.Drawing.Size(219, 22);
            this.tbBoxOfficeEarningsUpdate.TabIndex = 13;
            // 
            // panel1Update
            // 
            this.panel1Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1Update.Controls.Add(this.btCloseUpdate);
            this.panel1Update.Controls.Add(this.btClearUpdate);
            this.panel1Update.Controls.Add(this.btUpdateUpdate);
            this.panel1Update.Location = new System.Drawing.Point(16, 372);
            this.panel1Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1Update.Name = "panel1Update";
            this.panel1Update.Size = new System.Drawing.Size(768, 70);
            this.panel1Update.TabIndex = 14;
            // 
            // btCloseUpdate
            // 
            this.btCloseUpdate.Location = new System.Drawing.Point(649, 22);
            this.btCloseUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCloseUpdate.Name = "btCloseUpdate";
            this.btCloseUpdate.Size = new System.Drawing.Size(100, 28);
            this.btCloseUpdate.TabIndex = 2;
            this.btCloseUpdate.Text = "Close";
            this.btCloseUpdate.UseVisualStyleBackColor = true;
            // 
            // btClearUpdate
            // 
            this.btClearUpdate.Location = new System.Drawing.Point(140, 22);
            this.btClearUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClearUpdate.Name = "btClearUpdate";
            this.btClearUpdate.Size = new System.Drawing.Size(100, 28);
            this.btClearUpdate.TabIndex = 1;
            this.btClearUpdate.Text = "Clear";
            this.btClearUpdate.UseVisualStyleBackColor = true;
            // 
            // btUpdateUpdate
            // 
            this.btUpdateUpdate.Location = new System.Drawing.Point(7, 22);
            this.btUpdateUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btUpdateUpdate.Name = "btUpdateUpdate";
            this.btUpdateUpdate.Size = new System.Drawing.Size(100, 28);
            this.btUpdateUpdate.TabIndex = 0;
            this.btUpdateUpdate.Text = "Update";
            this.btUpdateUpdate.UseVisualStyleBackColor = true;
            // 
            // FormUpdateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1Update);
            this.Controls.Add(this.tbBoxOfficeEarningsUpdate);
            this.Controls.Add(this.labelBoxOfficeEarningsUpdate);
            this.Controls.Add(this.tbRottenTomatoesScoreUpdate);
            this.Controls.Add(this.labelRottenTomatoesScoreUpdate);
            this.Controls.Add(this.comboBoxGenreUpdate);
            this.Controls.Add(this.labelGenreUpdate);
            this.Controls.Add(this.tbDirectorUpdate);
            this.Controls.Add(this.labelDirectorUpdate);
            this.Controls.Add(this.tbYearUpdate);
            this.Controls.Add(this.labelYearUpdate);
            this.Controls.Add(this.btFindUpdate);
            this.Controls.Add(this.tbMovieTitleUpdate);
            this.Controls.Add(this.labelMovieTitleUpdate);
            this.Controls.Add(this.labelUpdateMovieScreen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormUpdateMovie";
            this.Text = "Update Movie";
            this.Load += new System.EventHandler(this.UpdateMovie_Load);
            this.panel1Update.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUpdateMovieScreen;
        private System.Windows.Forms.Label labelMovieTitleUpdate;
        private System.Windows.Forms.TextBox tbMovieTitleUpdate;
        private System.Windows.Forms.Button btFindUpdate;
        private System.Windows.Forms.Label labelYearUpdate;
        private System.Windows.Forms.TextBox tbYearUpdate;
        private System.Windows.Forms.Label labelDirectorUpdate;
        private System.Windows.Forms.TextBox tbDirectorUpdate;
        private System.Windows.Forms.Label labelGenreUpdate;
        private System.Windows.Forms.ComboBox comboBoxGenreUpdate;
        private System.Windows.Forms.Label labelRottenTomatoesScoreUpdate;
        private System.Windows.Forms.TextBox tbRottenTomatoesScoreUpdate;
        private System.Windows.Forms.Label labelBoxOfficeEarningsUpdate;
        private System.Windows.Forms.TextBox tbBoxOfficeEarningsUpdate;
        private System.Windows.Forms.Panel panel1Update;
        private System.Windows.Forms.Button btCloseUpdate;
        private System.Windows.Forms.Button btClearUpdate;
        private System.Windows.Forms.Button btUpdateUpdate;
    }
}
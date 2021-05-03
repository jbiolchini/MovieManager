
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
            this.labelUpdateMovieScreen.Location = new System.Drawing.Point(12, 9);
            this.labelUpdateMovieScreen.Name = "labelUpdateMovieScreen";
            this.labelUpdateMovieScreen.Size = new System.Drawing.Size(264, 29);
            this.labelUpdateMovieScreen.TabIndex = 0;
            this.labelUpdateMovieScreen.Text = "Update Movie Screen";
            // 
            // labelMovieTitleUpdate
            // 
            this.labelMovieTitleUpdate.AutoSize = true;
            this.labelMovieTitleUpdate.Location = new System.Drawing.Point(52, 63);
            this.labelMovieTitleUpdate.Name = "labelMovieTitleUpdate";
            this.labelMovieTitleUpdate.Size = new System.Drawing.Size(62, 13);
            this.labelMovieTitleUpdate.TabIndex = 1;
            this.labelMovieTitleUpdate.Text = "Movie Title:";
            // 
            // tbMovieTitleUpdate
            // 
            this.tbMovieTitleUpdate.Location = new System.Drawing.Point(117, 60);
            this.tbMovieTitleUpdate.Name = "tbMovieTitleUpdate";
            this.tbMovieTitleUpdate.Size = new System.Drawing.Size(297, 20);
            this.tbMovieTitleUpdate.TabIndex = 2;
            // 
            // btFindUpdate
            // 
            this.btFindUpdate.Location = new System.Drawing.Point(420, 58);
            this.btFindUpdate.Name = "btFindUpdate";
            this.btFindUpdate.Size = new System.Drawing.Size(75, 23);
            this.btFindUpdate.TabIndex = 3;
            this.btFindUpdate.Text = "Find";
            this.btFindUpdate.UseVisualStyleBackColor = true;
            this.btFindUpdate.Click += new System.EventHandler(this.btFindUpdate_Click);
            // 
            // labelYearUpdate
            // 
            this.labelYearUpdate.AutoSize = true;
            this.labelYearUpdate.Location = new System.Drawing.Point(79, 103);
            this.labelYearUpdate.Name = "labelYearUpdate";
            this.labelYearUpdate.Size = new System.Drawing.Size(32, 13);
            this.labelYearUpdate.TabIndex = 4;
            this.labelYearUpdate.Text = "Year:";
            // 
            // tbYearUpdate
            // 
            this.tbYearUpdate.Location = new System.Drawing.Point(117, 100);
            this.tbYearUpdate.Name = "tbYearUpdate";
            this.tbYearUpdate.Size = new System.Drawing.Size(116, 20);
            this.tbYearUpdate.TabIndex = 5;
            // 
            // labelDirectorUpdate
            // 
            this.labelDirectorUpdate.AutoSize = true;
            this.labelDirectorUpdate.Location = new System.Drawing.Point(64, 143);
            this.labelDirectorUpdate.Name = "labelDirectorUpdate";
            this.labelDirectorUpdate.Size = new System.Drawing.Size(47, 13);
            this.labelDirectorUpdate.TabIndex = 6;
            this.labelDirectorUpdate.Text = "Director:";
            // 
            // tbDirectorUpdate
            // 
            this.tbDirectorUpdate.Location = new System.Drawing.Point(117, 140);
            this.tbDirectorUpdate.Name = "tbDirectorUpdate";
            this.tbDirectorUpdate.Size = new System.Drawing.Size(188, 20);
            this.tbDirectorUpdate.TabIndex = 7;
            // 
            // labelGenreUpdate
            // 
            this.labelGenreUpdate.AutoSize = true;
            this.labelGenreUpdate.Location = new System.Drawing.Point(72, 183);
            this.labelGenreUpdate.Name = "labelGenreUpdate";
            this.labelGenreUpdate.Size = new System.Drawing.Size(39, 13);
            this.labelGenreUpdate.TabIndex = 8;
            this.labelGenreUpdate.Text = "Genre:";
            // 
            // comboBoxGenreUpdate
            // 
            this.comboBoxGenreUpdate.FormattingEnabled = true;
            this.comboBoxGenreUpdate.Items.AddRange(new object[] {
            "Animation",
            "Action",
            "Comedy",
            "Drama",
            "Horror",
            "Mystery",
            "Romance",
            "Science Fiction",
            "Western"});
            this.comboBoxGenreUpdate.Location = new System.Drawing.Point(117, 180);
            this.comboBoxGenreUpdate.Name = "comboBoxGenreUpdate";
            this.comboBoxGenreUpdate.Size = new System.Drawing.Size(188, 21);
            this.comboBoxGenreUpdate.TabIndex = 9;
            // 
            // labelRottenTomatoesScoreUpdate
            // 
            this.labelRottenTomatoesScoreUpdate.AutoSize = true;
            this.labelRottenTomatoesScoreUpdate.Location = new System.Drawing.Point(38, 240);
            this.labelRottenTomatoesScoreUpdate.Name = "labelRottenTomatoesScoreUpdate";
            this.labelRottenTomatoesScoreUpdate.Size = new System.Drawing.Size(123, 13);
            this.labelRottenTomatoesScoreUpdate.TabIndex = 10;
            this.labelRottenTomatoesScoreUpdate.Text = "Rotten Tomatoes Score:";
            // 
            // tbRottenTomatoesScoreUpdate
            // 
            this.tbRottenTomatoesScoreUpdate.Location = new System.Drawing.Point(167, 237);
            this.tbRottenTomatoesScoreUpdate.Name = "tbRottenTomatoesScoreUpdate";
            this.tbRottenTomatoesScoreUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbRottenTomatoesScoreUpdate.TabIndex = 11;
            // 
            // labelBoxOfficeEarningsUpdate
            // 
            this.labelBoxOfficeEarningsUpdate.AutoSize = true;
            this.labelBoxOfficeEarningsUpdate.Location = new System.Drawing.Point(273, 240);
            this.labelBoxOfficeEarningsUpdate.Name = "labelBoxOfficeEarningsUpdate";
            this.labelBoxOfficeEarningsUpdate.Size = new System.Drawing.Size(103, 13);
            this.labelBoxOfficeEarningsUpdate.TabIndex = 12;
            this.labelBoxOfficeEarningsUpdate.Text = "Box Office Earnings:";
            // 
            // tbBoxOfficeEarningsUpdate
            // 
            this.tbBoxOfficeEarningsUpdate.Location = new System.Drawing.Point(382, 237);
            this.tbBoxOfficeEarningsUpdate.Name = "tbBoxOfficeEarningsUpdate";
            this.tbBoxOfficeEarningsUpdate.Size = new System.Drawing.Size(165, 20);
            this.tbBoxOfficeEarningsUpdate.TabIndex = 13;
            // 
            // panel1Update
            // 
            this.panel1Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1Update.Controls.Add(this.btCloseUpdate);
            this.panel1Update.Controls.Add(this.btClearUpdate);
            this.panel1Update.Controls.Add(this.btUpdateUpdate);
            this.panel1Update.Location = new System.Drawing.Point(12, 302);
            this.panel1Update.Name = "panel1Update";
            this.panel1Update.Size = new System.Drawing.Size(576, 57);
            this.panel1Update.TabIndex = 14;
            // 
            // btCloseUpdate
            // 
            this.btCloseUpdate.Location = new System.Drawing.Point(487, 18);
            this.btCloseUpdate.Name = "btCloseUpdate";
            this.btCloseUpdate.Size = new System.Drawing.Size(75, 23);
            this.btCloseUpdate.TabIndex = 2;
            this.btCloseUpdate.Text = "Close";
            this.btCloseUpdate.UseVisualStyleBackColor = true;
            this.btCloseUpdate.Click += new System.EventHandler(this.btCloseUpdate_Click);
            // 
            // btClearUpdate
            // 
            this.btClearUpdate.Location = new System.Drawing.Point(105, 18);
            this.btClearUpdate.Name = "btClearUpdate";
            this.btClearUpdate.Size = new System.Drawing.Size(75, 23);
            this.btClearUpdate.TabIndex = 1;
            this.btClearUpdate.Text = "Clear";
            this.btClearUpdate.UseVisualStyleBackColor = true;
            this.btClearUpdate.Click += new System.EventHandler(this.btClearUpdate_Click);
            // 
            // btUpdateUpdate
            // 
            this.btUpdateUpdate.Location = new System.Drawing.Point(5, 18);
            this.btUpdateUpdate.Name = "btUpdateUpdate";
            this.btUpdateUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdateUpdate.TabIndex = 0;
            this.btUpdateUpdate.Text = "Update";
            this.btUpdateUpdate.UseVisualStyleBackColor = true;
            this.btUpdateUpdate.Click += new System.EventHandler(this.btUpdateUpdate_Click);
            // 
            // FormUpdateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
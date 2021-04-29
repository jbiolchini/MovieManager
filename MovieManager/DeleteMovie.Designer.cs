
namespace MovieManager
{
    partial class FormDeleteMovie
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
            this.labelDeleteMovieScreen = new System.Windows.Forms.Label();
            this.labelMovieTitleDelete = new System.Windows.Forms.Label();
            this.tbMovieTitleDelete = new System.Windows.Forms.TextBox();
            this.btFindDelete = new System.Windows.Forms.Button();
            this.labelYearDelete = new System.Windows.Forms.Label();
            this.tbYearDelete = new System.Windows.Forms.TextBox();
            this.labelDirectorDelete = new System.Windows.Forms.Label();
            this.tbDirectorDelete = new System.Windows.Forms.TextBox();
            this.labelGenreDelete = new System.Windows.Forms.Label();
            this.comboBoxGenreDelete = new System.Windows.Forms.ComboBox();
            this.labelRottenTomatoesScoreDelete = new System.Windows.Forms.Label();
            this.tbRottenTomatoesScoreDelete = new System.Windows.Forms.TextBox();
            this.labelBoxOfficeEarningsDelete = new System.Windows.Forms.Label();
            this.tbBoxOfficeEarningsDelete = new System.Windows.Forms.TextBox();
            this.panel1Delete = new System.Windows.Forms.Panel();
            this.btCloseDelete = new System.Windows.Forms.Button();
            this.btClearDelete = new System.Windows.Forms.Button();
            this.btDeleteDelete = new System.Windows.Forms.Button();
            this.panel1Delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDeleteMovieScreen
            // 
            this.labelDeleteMovieScreen.AutoSize = true;
            this.labelDeleteMovieScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteMovieScreen.Location = new System.Drawing.Point(12, 9);
            this.labelDeleteMovieScreen.Name = "labelDeleteMovieScreen";
            this.labelDeleteMovieScreen.Size = new System.Drawing.Size(257, 29);
            this.labelDeleteMovieScreen.TabIndex = 0;
            this.labelDeleteMovieScreen.Text = "Delete Movie Screen";
            // 
            // labelMovieTitleDelete
            // 
            this.labelMovieTitleDelete.AutoSize = true;
            this.labelMovieTitleDelete.Location = new System.Drawing.Point(52, 63);
            this.labelMovieTitleDelete.Name = "labelMovieTitleDelete";
            this.labelMovieTitleDelete.Size = new System.Drawing.Size(62, 13);
            this.labelMovieTitleDelete.TabIndex = 1;
            this.labelMovieTitleDelete.Text = "Movie Title:";
            // 
            // tbMovieTitleDelete
            // 
            this.tbMovieTitleDelete.Location = new System.Drawing.Point(117, 60);
            this.tbMovieTitleDelete.Name = "tbMovieTitleDelete";
            this.tbMovieTitleDelete.Size = new System.Drawing.Size(297, 20);
            this.tbMovieTitleDelete.TabIndex = 2;
            // 
            // btFindDelete
            // 
            this.btFindDelete.Location = new System.Drawing.Point(420, 58);
            this.btFindDelete.Name = "btFindDelete";
            this.btFindDelete.Size = new System.Drawing.Size(75, 23);
            this.btFindDelete.TabIndex = 3;
            this.btFindDelete.Text = "Find";
            this.btFindDelete.UseVisualStyleBackColor = true;
            this.btFindDelete.Click += new System.EventHandler(this.btFindDelete_Click);
            // 
            // labelYearDelete
            // 
            this.labelYearDelete.AutoSize = true;
            this.labelYearDelete.Location = new System.Drawing.Point(79, 103);
            this.labelYearDelete.Name = "labelYearDelete";
            this.labelYearDelete.Size = new System.Drawing.Size(32, 13);
            this.labelYearDelete.TabIndex = 4;
            this.labelYearDelete.Text = "Year:";
            // 
            // tbYearDelete
            // 
            this.tbYearDelete.Location = new System.Drawing.Point(117, 100);
            this.tbYearDelete.Name = "tbYearDelete";
            this.tbYearDelete.Size = new System.Drawing.Size(116, 20);
            this.tbYearDelete.TabIndex = 5;
            // 
            // labelDirectorDelete
            // 
            this.labelDirectorDelete.AutoSize = true;
            this.labelDirectorDelete.Location = new System.Drawing.Point(64, 143);
            this.labelDirectorDelete.Name = "labelDirectorDelete";
            this.labelDirectorDelete.Size = new System.Drawing.Size(47, 13);
            this.labelDirectorDelete.TabIndex = 6;
            this.labelDirectorDelete.Text = "Director:";
            // 
            // tbDirectorDelete
            // 
            this.tbDirectorDelete.Location = new System.Drawing.Point(117, 140);
            this.tbDirectorDelete.Name = "tbDirectorDelete";
            this.tbDirectorDelete.Size = new System.Drawing.Size(188, 20);
            this.tbDirectorDelete.TabIndex = 7;
            // 
            // labelGenreDelete
            // 
            this.labelGenreDelete.AutoSize = true;
            this.labelGenreDelete.Location = new System.Drawing.Point(72, 183);
            this.labelGenreDelete.Name = "labelGenreDelete";
            this.labelGenreDelete.Size = new System.Drawing.Size(39, 13);
            this.labelGenreDelete.TabIndex = 8;
            this.labelGenreDelete.Text = "Genre:";
            // 
            // comboBoxGenreDelete
            // 
            this.comboBoxGenreDelete.FormattingEnabled = true;
            this.comboBoxGenreDelete.Items.AddRange(new object[] {
            "Animation",
            "Action",
            "Comedy",
            "Drama",
            "Horror",
            "Mystery",
            "Romance",
            "Science Fiction",
            "Western"});
            this.comboBoxGenreDelete.Location = new System.Drawing.Point(117, 180);
            this.comboBoxGenreDelete.Name = "comboBoxGenreDelete";
            this.comboBoxGenreDelete.Size = new System.Drawing.Size(188, 21);
            this.comboBoxGenreDelete.TabIndex = 9;
            // 
            // labelRottenTomatoesScoreDelete
            // 
            this.labelRottenTomatoesScoreDelete.AutoSize = true;
            this.labelRottenTomatoesScoreDelete.Location = new System.Drawing.Point(38, 240);
            this.labelRottenTomatoesScoreDelete.Name = "labelRottenTomatoesScoreDelete";
            this.labelRottenTomatoesScoreDelete.Size = new System.Drawing.Size(123, 13);
            this.labelRottenTomatoesScoreDelete.TabIndex = 10;
            this.labelRottenTomatoesScoreDelete.Text = "Rotten Tomatoes Score:";
            // 
            // tbRottenTomatoesScoreDelete
            // 
            this.tbRottenTomatoesScoreDelete.Location = new System.Drawing.Point(167, 237);
            this.tbRottenTomatoesScoreDelete.Name = "tbRottenTomatoesScoreDelete";
            this.tbRottenTomatoesScoreDelete.Size = new System.Drawing.Size(100, 20);
            this.tbRottenTomatoesScoreDelete.TabIndex = 11;
            // 
            // labelBoxOfficeEarningsDelete
            // 
            this.labelBoxOfficeEarningsDelete.AutoSize = true;
            this.labelBoxOfficeEarningsDelete.Location = new System.Drawing.Point(273, 240);
            this.labelBoxOfficeEarningsDelete.Name = "labelBoxOfficeEarningsDelete";
            this.labelBoxOfficeEarningsDelete.Size = new System.Drawing.Size(103, 13);
            this.labelBoxOfficeEarningsDelete.TabIndex = 12;
            this.labelBoxOfficeEarningsDelete.Text = "Box Office Earnings:";
            // 
            // tbBoxOfficeEarningsDelete
            // 
            this.tbBoxOfficeEarningsDelete.Location = new System.Drawing.Point(382, 237);
            this.tbBoxOfficeEarningsDelete.Name = "tbBoxOfficeEarningsDelete";
            this.tbBoxOfficeEarningsDelete.Size = new System.Drawing.Size(165, 20);
            this.tbBoxOfficeEarningsDelete.TabIndex = 13;
            // 
            // panel1Delete
            // 
            this.panel1Delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1Delete.Controls.Add(this.btCloseDelete);
            this.panel1Delete.Controls.Add(this.btClearDelete);
            this.panel1Delete.Controls.Add(this.btDeleteDelete);
            this.panel1Delete.Location = new System.Drawing.Point(12, 302);
            this.panel1Delete.Name = "panel1Delete";
            this.panel1Delete.Size = new System.Drawing.Size(576, 57);
            this.panel1Delete.TabIndex = 14;
            // 
            // btCloseDelete
            // 
            this.btCloseDelete.Location = new System.Drawing.Point(487, 18);
            this.btCloseDelete.Name = "btCloseDelete";
            this.btCloseDelete.Size = new System.Drawing.Size(75, 23);
            this.btCloseDelete.TabIndex = 2;
            this.btCloseDelete.Text = "Close";
            this.btCloseDelete.UseVisualStyleBackColor = true;
            this.btCloseDelete.Click += new System.EventHandler(this.btCloseDelete_Click);
            // 
            // btClearDelete
            // 
            this.btClearDelete.Location = new System.Drawing.Point(105, 18);
            this.btClearDelete.Name = "btClearDelete";
            this.btClearDelete.Size = new System.Drawing.Size(75, 23);
            this.btClearDelete.TabIndex = 1;
            this.btClearDelete.Text = "Clear";
            this.btClearDelete.UseVisualStyleBackColor = true;
            this.btClearDelete.Click += new System.EventHandler(this.btClearDelete_Click);
            // 
            // btDeleteDelete
            // 
            this.btDeleteDelete.Location = new System.Drawing.Point(5, 18);
            this.btDeleteDelete.Name = "btDeleteDelete";
            this.btDeleteDelete.Size = new System.Drawing.Size(75, 23);
            this.btDeleteDelete.TabIndex = 0;
            this.btDeleteDelete.Text = "Delete";
            this.btDeleteDelete.UseVisualStyleBackColor = true;
            this.btDeleteDelete.Click += new System.EventHandler(this.btDeleteDelete_Click);
            // 
            // FormDeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1Delete);
            this.Controls.Add(this.tbBoxOfficeEarningsDelete);
            this.Controls.Add(this.labelBoxOfficeEarningsDelete);
            this.Controls.Add(this.tbRottenTomatoesScoreDelete);
            this.Controls.Add(this.labelRottenTomatoesScoreDelete);
            this.Controls.Add(this.comboBoxGenreDelete);
            this.Controls.Add(this.labelGenreDelete);
            this.Controls.Add(this.tbDirectorDelete);
            this.Controls.Add(this.labelDirectorDelete);
            this.Controls.Add(this.tbYearDelete);
            this.Controls.Add(this.labelYearDelete);
            this.Controls.Add(this.btFindDelete);
            this.Controls.Add(this.tbMovieTitleDelete);
            this.Controls.Add(this.labelMovieTitleDelete);
            this.Controls.Add(this.labelDeleteMovieScreen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDeleteMovie";
            this.Text = "Delete Movie";
            this.panel1Delete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeleteMovieScreen;
        private System.Windows.Forms.Label labelMovieTitleDelete;
        private System.Windows.Forms.TextBox tbMovieTitleDelete;
        private System.Windows.Forms.Button btFindDelete;
        private System.Windows.Forms.Label labelYearDelete;
        private System.Windows.Forms.TextBox tbYearDelete;
        private System.Windows.Forms.Label labelDirectorDelete;
        private System.Windows.Forms.TextBox tbDirectorDelete;
        private System.Windows.Forms.Label labelGenreDelete;
        private System.Windows.Forms.ComboBox comboBoxGenreDelete;
        private System.Windows.Forms.Label labelRottenTomatoesScoreDelete;
        private System.Windows.Forms.TextBox tbRottenTomatoesScoreDelete;
        private System.Windows.Forms.Label labelBoxOfficeEarningsDelete;
        private System.Windows.Forms.TextBox tbBoxOfficeEarningsDelete;
        private System.Windows.Forms.Panel panel1Delete;
        private System.Windows.Forms.Button btDeleteDelete;
        private System.Windows.Forms.Button btCloseDelete;
        private System.Windows.Forms.Button btClearDelete;
    }
}
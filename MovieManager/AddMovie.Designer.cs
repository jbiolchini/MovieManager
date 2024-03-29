﻿
namespace MovieManager
{
    partial class FormAddMovie
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelMovieTitle = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelTomatoes = new System.Windows.Forms.Label();
            this.labelBoxOffice = new System.Windows.Forms.Label();
            this.tbMovieTitleAdd = new System.Windows.Forms.TextBox();
            this.tbYearAdd = new System.Windows.Forms.TextBox();
            this.tbDirectorAdd = new System.Windows.Forms.TextBox();
            this.tbRottenTomatoesScoreAdd = new System.Windows.Forms.TextBox();
            this.tbBoxOfficeEarningsAdd = new System.Windows.Forms.TextBox();
            this.comboBoxGenreAdd = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCloseAdd = new System.Windows.Forms.Button();
            this.btClearAdd = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Movie";
            // 
            // labelMovieTitle
            // 
            this.labelMovieTitle.AutoSize = true;
            this.labelMovieTitle.Location = new System.Drawing.Point(87, 71);
            this.labelMovieTitle.Name = "labelMovieTitle";
            this.labelMovieTitle.Size = new System.Drawing.Size(76, 17);
            this.labelMovieTitle.TabIndex = 1;
            this.labelMovieTitle.Text = "Movie Title";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(127, 133);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(38, 17);
            this.labelYear.TabIndex = 2;
            this.labelYear.Text = "Year";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(107, 194);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(58, 17);
            this.labelDirector.TabIndex = 3;
            this.labelDirector.Text = "Director";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(117, 256);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(48, 17);
            this.labelGenre.TabIndex = 4;
            this.labelGenre.Text = "Genre";
            // 
            // labelTomatoes
            // 
            this.labelTomatoes.AutoSize = true;
            this.labelTomatoes.Location = new System.Drawing.Point(87, 313);
            this.labelTomatoes.Name = "labelTomatoes";
            this.labelTomatoes.Size = new System.Drawing.Size(158, 17);
            this.labelTomatoes.TabIndex = 5;
            this.labelTomatoes.Text = "Rotten Tomatoes Score";
            // 
            // labelBoxOffice
            // 
            this.labelBoxOffice.AutoSize = true;
            this.labelBoxOffice.Location = new System.Drawing.Point(400, 313);
            this.labelBoxOffice.Name = "labelBoxOffice";
            this.labelBoxOffice.Size = new System.Drawing.Size(132, 17);
            this.labelBoxOffice.TabIndex = 6;
            this.labelBoxOffice.Text = "Box Office Earnings";
            // 
            // tbMovieTitleAdd
            // 
            this.tbMovieTitleAdd.Location = new System.Drawing.Point(195, 68);
            this.tbMovieTitleAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMovieTitleAdd.Name = "tbMovieTitleAdd";
            this.tbMovieTitleAdd.Size = new System.Drawing.Size(337, 22);
            this.tbMovieTitleAdd.TabIndex = 7;
            // 
            // tbYearAdd
            // 
            this.tbYearAdd.Location = new System.Drawing.Point(195, 129);
            this.tbYearAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbYearAdd.Name = "tbYearAdd";
            this.tbYearAdd.Size = new System.Drawing.Size(100, 22);
            this.tbYearAdd.TabIndex = 8;
            // 
            // tbDirectorAdd
            // 
            this.tbDirectorAdd.Location = new System.Drawing.Point(195, 191);
            this.tbDirectorAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDirectorAdd.Name = "tbDirectorAdd";
            this.tbDirectorAdd.Size = new System.Drawing.Size(199, 22);
            this.tbDirectorAdd.TabIndex = 9;
            // 
            // tbRottenTomatoesScoreAdd
            // 
            this.tbRottenTomatoesScoreAdd.Location = new System.Drawing.Point(252, 309);
            this.tbRottenTomatoesScoreAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRottenTomatoesScoreAdd.Name = "tbRottenTomatoesScoreAdd";
            this.tbRottenTomatoesScoreAdd.Size = new System.Drawing.Size(141, 22);
            this.tbRottenTomatoesScoreAdd.TabIndex = 10;
            // 
            // tbBoxOfficeEarningsAdd
            // 
            this.tbBoxOfficeEarningsAdd.Location = new System.Drawing.Point(539, 309);
            this.tbBoxOfficeEarningsAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBoxOfficeEarningsAdd.Name = "tbBoxOfficeEarningsAdd";
            this.tbBoxOfficeEarningsAdd.Size = new System.Drawing.Size(168, 22);
            this.tbBoxOfficeEarningsAdd.TabIndex = 11;
            // 
            // comboBoxGenreAdd
            // 
            this.comboBoxGenreAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenreAdd.FormattingEnabled = true;
            this.comboBoxGenreAdd.Items.AddRange(new object[] {
            "Animation",
            "Action",
            "Comedy",
            "Drama",
            "Horror",
            "Mystery",
            "Romance",
            "Science Fiction",
            "Western"});
            this.comboBoxGenreAdd.Location = new System.Drawing.Point(195, 252);
            this.comboBoxGenreAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGenreAdd.Name = "comboBoxGenreAdd";
            this.comboBoxGenreAdd.Size = new System.Drawing.Size(199, 24);
            this.comboBoxGenreAdd.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btCloseAdd);
            this.panel1.Controls.Add(this.btClearAdd);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Location = new System.Drawing.Point(16, 372);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 70);
            this.panel1.TabIndex = 13;
            // 
            // btCloseAdd
            // 
            this.btCloseAdd.Location = new System.Drawing.Point(649, 22);
            this.btCloseAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCloseAdd.Name = "btCloseAdd";
            this.btCloseAdd.Size = new System.Drawing.Size(100, 28);
            this.btCloseAdd.TabIndex = 2;
            this.btCloseAdd.Text = "Close";
            this.btCloseAdd.UseVisualStyleBackColor = true;
            this.btCloseAdd.Click += new System.EventHandler(this.btCloseAdd_Click);
            // 
            // btClearAdd
            // 
            this.btClearAdd.Location = new System.Drawing.Point(140, 22);
            this.btClearAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClearAdd.Name = "btClearAdd";
            this.btClearAdd.Size = new System.Drawing.Size(100, 28);
            this.btClearAdd.TabIndex = 1;
            this.btClearAdd.Text = "Clear";
            this.btClearAdd.UseVisualStyleBackColor = true;
            this.btClearAdd.Click += new System.EventHandler(this.btClearAdd_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(7, 22);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 28);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // FormAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxGenreAdd);
            this.Controls.Add(this.tbBoxOfficeEarningsAdd);
            this.Controls.Add(this.tbRottenTomatoesScoreAdd);
            this.Controls.Add(this.tbDirectorAdd);
            this.Controls.Add(this.tbYearAdd);
            this.Controls.Add(this.tbMovieTitleAdd);
            this.Controls.Add(this.labelBoxOffice);
            this.Controls.Add(this.labelTomatoes);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelMovieTitle);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddMovie";
            this.Text = "Add Movie";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMovieTitle;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelTomatoes;
        private System.Windows.Forms.Label labelBoxOffice;
        private System.Windows.Forms.TextBox tbMovieTitleAdd;
        private System.Windows.Forms.TextBox tbYearAdd;
        private System.Windows.Forms.TextBox tbDirectorAdd;
        private System.Windows.Forms.TextBox tbRottenTomatoesScoreAdd;
        private System.Windows.Forms.TextBox tbBoxOfficeEarningsAdd;
        private System.Windows.Forms.ComboBox comboBoxGenreAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCloseAdd;
        private System.Windows.Forms.Button btClearAdd;
        private System.Windows.Forms.Button btAdd;
    }
}
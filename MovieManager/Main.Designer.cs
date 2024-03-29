﻿
namespace MovieManager
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAddMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUpdateMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDeleteMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.DGVMain = new System.Windows.Forms.DataGridView();
            this.formMainBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.formMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formMainBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formMainBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formMainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formMainBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemMaintenance,
            this.menuItemAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1408, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRefresh,
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(46, 24);
            this.menuItemFile.Text = "File";
            // 
            // menuItemRefresh
            // 
            this.menuItemRefresh.Name = "menuItemRefresh";
            this.menuItemRefresh.Size = new System.Drawing.Size(141, 26);
            this.menuItemRefresh.Text = "Refresh";
            this.menuItemRefresh.Click += new System.EventHandler(this.menuItemRefresh_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(141, 26);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemMaintenance
            // 
            this.menuItemMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAddMovie,
            this.menuItemUpdateMovie,
            this.menuItemDeleteMovie});
            this.menuItemMaintenance.Name = "menuItemMaintenance";
            this.menuItemMaintenance.Size = new System.Drawing.Size(108, 24);
            this.menuItemMaintenance.Text = "Maintenance";
            // 
            // menuItemAddMovie
            // 
            this.menuItemAddMovie.Name = "menuItemAddMovie";
            this.menuItemAddMovie.Size = new System.Drawing.Size(186, 26);
            this.menuItemAddMovie.Text = "Add Movie";
            this.menuItemAddMovie.Click += new System.EventHandler(this.addMovieToolStripMenuItem_Click);
            // 
            // menuItemUpdateMovie
            // 
            this.menuItemUpdateMovie.Name = "menuItemUpdateMovie";
            this.menuItemUpdateMovie.Size = new System.Drawing.Size(186, 26);
            this.menuItemUpdateMovie.Text = "Update Movie";
            this.menuItemUpdateMovie.Click += new System.EventHandler(this.menuItemUpdateMovie_Click);
            // 
            // menuItemDeleteMovie
            // 
            this.menuItemDeleteMovie.Name = "menuItemDeleteMovie";
            this.menuItemDeleteMovie.Size = new System.Drawing.Size(186, 26);
            this.menuItemDeleteMovie.Text = "Delete Movie";
            this.menuItemDeleteMovie.Click += new System.EventHandler(this.menuItemDeleteMovie_Click);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(64, 24);
            this.menuItemAbout.Text = "About";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // DGVMain
            // 
            this.DGVMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMain.Location = new System.Drawing.Point(13, 32);
            this.DGVMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVMain.Name = "DGVMain";
            this.DGVMain.RowHeadersWidth = 51;
            this.DGVMain.Size = new System.Drawing.Size(1382, 569);
            this.DGVMain.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 614);
            this.Controls.Add(this.DGVMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Movie Manager Application";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formMainBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formMainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formMainBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemRefresh;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemMaintenance;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddMovie;
        private System.Windows.Forms.ToolStripMenuItem menuItemUpdateMovie;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeleteMovie;
        private System.Windows.Forms.DataGridView DGVMain;
        private System.Windows.Forms.BindingSource formMainBindingSource;
        private System.Windows.Forms.BindingSource formMainBindingSource1;
        private System.Windows.Forms.BindingSource formMainBindingSource2;
    }
}


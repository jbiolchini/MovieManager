using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //Launches instance of Add Movie Form when Maintenance-> Add Movie is clicked in menu
        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddMovie addMovie = new FormAddMovie();
            addMovie.ShowDialog();
        }

        //Launches instance of Update Movie form when Maintenance->Update Movie is clicked in menu
        private void menuItemUpdateMovie_Click(object sender, EventArgs e)
        {
            FormUpdateMovie updateMovie = new FormUpdateMovie();
            updateMovie.ShowDialog();
        }
        //Launches instance of Delete Movie form when Maintenance->Delete Movie is clicked in menu
        private void menuItemDeleteMovie_Click(object sender, EventArgs e)
        {
            FormDeleteMovie deleteMovie = new FormDeleteMovie();
            deleteMovie.ShowDialog();
        }
        //Launches instance of About form when About is clicked in menu
        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        //Closes the program when File->Exit is clicked
        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}

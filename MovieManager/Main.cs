using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieManager
{
    
    public partial class FormMain : Form
    {
        //SQL command to return all movies from db with title/year/director/genre/score/revenue
        string populateString = "SELECT Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned FROM Movies ORDER BY Title";
        public FormMain()
        {
            InitializeComponent();
            // Initial Population of DataGridView
            Movie movie = new Movie();
            List<Movie> movies = movie.QueryMovieData(populateString);
            DGVMain.DataSource = movies;
            
        }

        // Refresh list of movies in DataGridView
        private void menuItemRefresh_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            List<Movie> movies = movie.QueryMovieData(populateString);
            DGVMain.DataSource = movies;
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

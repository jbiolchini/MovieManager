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
       
        // DataGridView Population Methods
       /* public List<Movie> GetMovieData()
        {
            List<Movie> movies = new List<Movie>();
            try
            {
                using (SqlConnection connection = new SqlConnection(
                    @"Data Source=coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433;Initial Catalog=CSCI1630;User ID=rw1630;Password=Project!;"))
                using (SqlCommand command = new SqlCommand(
                    "SELECT Id, Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned FROM Movies ORDER BY Title", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Movie movie = new Movie();

                            int titleIndex = reader.GetOrdinal(nameof(Movie.Title));
                            movie.Title = reader.GetString(titleIndex);

                            int yearIndex = reader.GetOrdinal(nameof(Movie.Year));
                            movie.Year = reader.GetInt32(yearIndex);

                            int directorIndex = reader.GetOrdinal(nameof(Movie.Director));
                            movie.Director = reader.GetString(directorIndex);

                            int genreIndex = reader.GetOrdinal(nameof(Movie.Genre));
                            movie.Genre = movie.GetGenreString(reader.GetInt32(genreIndex));

                            int scoreIndex = reader.GetOrdinal(nameof(Movie.RottenTomatoesScore));
                            if (!reader.IsDBNull(scoreIndex))
                                movie.RottenTomatoesScore = reader.GetInt32(scoreIndex);

                            int revenueIndex = reader.GetOrdinal(nameof(Movie.TotalEarned));
                            if (!reader.IsDBNull(revenueIndex))
                                movie.TotalEarned = reader.GetDecimal(revenueIndex);

                            movies.Add(movie);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while opening a connection tothe database: { ex.Message }");
            }
            return movies;
        }*/
    }
}

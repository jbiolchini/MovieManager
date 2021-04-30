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
    public partial class FormUpdateMovie : Form
    {
        //Initializes form
        public FormUpdateMovie()
        {
            InitializeComponent();
        }

        private void UpdateMovie_Load(object sender, EventArgs e)
        {

        }

        //Finds the movie in database, if movie exists, fills in all text fields with values from DB
        private void btFindUpdate_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            SqlCommand queryExistence = new SqlCommand("SELECT Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned FROM Movies where Title = @Title",
                movie.Connection());
            queryExistence.Parameters.AddWithValue("Title", tbMovieTitleUpdate.Text);
            List<Movie> movieExists = movie.QueryMovieData(queryExistence);
            if (!movieExists.Any())
                MessageBox.Show("Movie does not exist in the current database");
            else
            {
                tbYearUpdate.Text = movieExists[0].Year.ToString();
                tbDirectorUpdate.Text = movieExists[0].Director;
                comboBoxGenreUpdate.Text = movieExists[0].Genre;
                tbRottenTomatoesScoreUpdate.Text = movieExists[0].RottenTomatoesScore.ToString();
                tbBoxOfficeEarningsUpdate.Text = movieExists[0].TotalEarned.ToString();
            }        
        }

        //Closes instance of Update Movie Form
        private void btCloseUpdate_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Updates movie (if movie exists), checks for count of movies first, if 0, returns error messagebox, else continues performing the SQL UPDATE command
        private void btUpdateUpdate_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            SqlCommand countCommand = new SqlCommand("SELECT COUNT(*) FROM Movies WHERE Title = @Title", movie.Connection());
            countCommand.Parameters.AddWithValue("Title", tbMovieTitleUpdate.Text);
            int count = movie.MovieCount(countCommand);
            if (count == 0)
            {
                MessageBox.Show("Movie does not exist in the database");
            }
            else
            {
                try
                {
                    //checks for genre category selection
                    if (comboBoxGenreUpdate.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a genre category.");
                        return;
                    }

                    //checks to make sure year can be parsed as an int
                    if (!int.TryParse(tbYearUpdate.Text.ToString(), out int a))
                    {
                        MessageBox.Show("Year field only accepts numeric values");
                        tbYearUpdate.Text = "";
                        return;
                    }
                    SqlCommand updateMovie = new SqlCommand($"UPDATE Movies SET Title = @Title, Year = @Year, Director = @Director, Genre=@Genre, RottenTomatoesScore = @RottenTomatoesScore, TotalEarned = @TotalEarned " +
                        $"WHERE Title ='{tbMovieTitleUpdate.Text}'", movie.Connection());
                    updateMovie.Parameters.AddWithValue("Title", tbMovieTitleUpdate.Text);
                    updateMovie.Parameters.AddWithValue("Year", tbYearUpdate.Text);
                    updateMovie.Parameters.AddWithValue("Director", tbDirectorUpdate.Text);
                    int genreInt = movie.GetGenreInt(comboBoxGenreUpdate.SelectedItem.ToString());
                    updateMovie.Parameters.AddWithValue("Genre", genreInt);
                    object score = tbRottenTomatoesScoreUpdate.Text;
                    if ((string)score == "")
                        score = DBNull.Value;
                    else score = int.Parse(score.ToString());
                    updateMovie.Parameters.Add("RottenTomatoesScore", SqlDbType.Int).Value = score;
                    object earnings = tbBoxOfficeEarningsUpdate.Text;
                    if ((string)earnings == "")
                        earnings = DBNull.Value;
                    else
                        earnings = decimal.Parse(earnings.ToString());
                    updateMovie.Parameters.Add("TotalEarned", SqlDbType.Decimal).Value = earnings;
                    movie.QueryMovieData(updateMovie);
                    MessageBox.Show("Movie Update Successfully");
                }
                catch (Exception inputException)
                {
                    MessageBox.Show($"Error: At least one field was entered incorrectly {inputException.Message}");
                }
             }

        }
    }
}

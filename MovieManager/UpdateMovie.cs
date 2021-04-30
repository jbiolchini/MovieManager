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
        public FormUpdateMovie()
        {
            InitializeComponent();
        }

        private void UpdateMovie_Load(object sender, EventArgs e)
        {

        }

        private void btFindUpdate_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();

            SqlCommand queryExistence = new SqlCommand("SELECT Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned FROM Movies where Title = @Title",
                movie.Connection());
            queryExistence.Parameters.AddWithValue("Title", tbMovieTitleUpdate.Text);

            List<Movie> movieExists = movie.QueryMovieData(queryExistence);
            tbYearUpdate.Text = movieExists[0].Year.ToString();
            tbDirectorUpdate.Text = movieExists[0].Director;
            comboBoxGenreUpdate.Text = movieExists[0].Genre;
            tbRottenTomatoesScoreUpdate.Text = movieExists[0].RottenTomatoesScore.ToString();
            tbBoxOfficeEarningsUpdate.Text = movieExists[0].TotalEarned.ToString();
        }

        private void btCloseUpdate_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btUpdateUpdate_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            SqlCommand updateMovie = new SqlCommand($"UPDATE Movies SET Title = @Title, Year = @Year, Director = @Director, Genre=@Genre, RottenTomatoesScore = @RottenTomatoesScore, TotalEarned = @TotalEarned " +
                $"WHERE Title ='{tbMovieTitleUpdate.Text}'", movie.Connection());
            updateMovie.Parameters.AddWithValue("Title", tbMovieTitleUpdate.Text);
            updateMovie.Parameters.AddWithValue("Year", tbYearUpdate.Text);
            updateMovie.Parameters.AddWithValue("Director", tbDirectorUpdate.Text);
            int genreInt = movie.GetGenreInt(comboBoxGenreUpdate.SelectedItem.ToString());
            updateMovie.Parameters.AddWithValue("Genre", genreInt);
            object score = tbRottenTomatoesScoreUpdate.Text;
            if (score == null)
                score = DBNull.Value;
            else score = int.Parse(score.ToString());
            updateMovie.Parameters.Add("RottenTomatoesScore", SqlDbType.Int).Value = score;
            object earnings = tbBoxOfficeEarningsUpdate.Text;
            if (earnings == null)
                earnings = DBNull.Value;
            else
                earnings = decimal.Parse(earnings.ToString());
            updateMovie.Parameters.Add("TotalEarned", SqlDbType.Decimal).Value = earnings;
            movie.QueryMovieData(updateMovie);
            MessageBox.Show("Movie Update Successfully");
        }
    }
}

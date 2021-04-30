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
    public partial class FormDeleteMovie : Form
    {
        //initializes form
        public FormDeleteMovie()
        {
            InitializeComponent();
        }

        //Deletes movie from database, pass sql statement into QueryMovieData method, checks for movie existence in database
        //shows messagebox if movie doesn't exist, performs sql command
        private void btDeleteDelete_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            SqlCommand countCommand = new SqlCommand("SELECT COUNT (*) FROM Movies WHERE Title = @Title",
                movie.Connection());
            countCommand.Parameters.AddWithValue("Title", tbMovieTitleDelete.Text);
            int count = movie.MovieCount(countCommand);
            if (count == 0)
            {
                MessageBox.Show("Movie does not exist in the database");
                return;
            }
            else
            {
                SqlCommand deleteCommand = new SqlCommand("DELETE FROM Movies WHERE Title = @Title",
                movie.Connection());
                deleteCommand.Parameters.AddWithValue("Title", tbMovieTitleDelete.Text);
                movie.QueryMovieData(deleteCommand);
                MessageBox.Show("Movie Deleted");
            }
            textBoxClearMethod();   
        }

        //Clears textboxes when clear button is clicked
        private void btClearDelete_Click(object sender, EventArgs e)
        {
            textBoxClearMethod();
        }

        //Closes form instance when close button is clicked
        private void btCloseDelete_Click(object sender, EventArgs e)
        {
            Close();
        }

        //method to clear textboxes on form
        public void textBoxClearMethod()
        {
            tbMovieTitleDelete.Text = "";
            tbYearDelete.Text = "";
            tbDirectorDelete.Text = "";
            comboBoxGenreDelete.ResetText();
            tbRottenTomatoesScoreDelete.Text = "";
            tbBoxOfficeEarningsDelete.Text = "";
        }

        private void btFindDelete_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();

            SqlCommand queryExistence = new SqlCommand("SELECT Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned FROM Movies where Title = @Title",
                movie.Connection());
            queryExistence.Parameters.AddWithValue("Title", tbMovieTitleDelete.Text);

            List<Movie> movieExists = movie.QueryMovieData(queryExistence);
            if (!movieExists.Any())
                MessageBox.Show("Movie does not exist in the database, please try your search again");
            else
            {
                tbYearDelete.Text = movieExists[0].Year.ToString();
                tbDirectorDelete.Text = movieExists[0].Director;
                comboBoxGenreDelete.Text = movieExists[0].Genre;
                tbRottenTomatoesScoreDelete.Text = movieExists[0].RottenTomatoesScore.ToString();
                tbBoxOfficeEarningsDelete.Text = movieExists[0].TotalEarned.ToString();
            }        
        }
    }
}

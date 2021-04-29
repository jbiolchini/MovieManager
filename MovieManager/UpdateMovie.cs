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
    }
}

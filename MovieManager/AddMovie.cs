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
    public partial class FormAddMovie : Form
    {
        public FormAddMovie()
        {
            InitializeComponent();
        }

        //Clear Add Form Text fields
        private void btClearAdd_Click(object sender, EventArgs e)
        {
            textBoxClearMethod();
        }

        //Close Add Form
        private void btCloseAdd_Click(object sender, EventArgs e)
        {
            Close();
        }

        //adds movie to database by constructing a sql statement from textboxes and passing it into Querymoviedata method
        private void btAdd_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            try
            {
                // check for genre category selection
                if (comboBoxGenreAdd.SelectedItem == null)
                {
                    MessageBox.Show("Please select a genre category.");
                    return;
                }
                int genreInt = movie.GetGenreInt(comboBoxGenreAdd.SelectedItem.ToString());

                // create SqlCommand, check for null values in score and earnings
                SqlCommand addCommand = new SqlCommand("INSERT INTO Movies (Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned) " +
                    "VALUES(@Title, @Year, @Director, @Genre, @RottenTomatoesScore, @TotalEarned)",
                    movie.Connection());
                addCommand.Parameters.AddWithValue("Title", tbMovieTitleAdd.Text);
                addCommand.Parameters.AddWithValue("Year", tbYearAdd.Text);
                addCommand.Parameters.AddWithValue("Director", tbDirectorAdd.Text);
                addCommand.Parameters.AddWithValue("Genre", genreInt);
                object score = tbRottenTomatoesScoreAdd.Text;
                if (score == null)
                    score = DBNull.Value;
                else score = int.Parse(tbRottenTomatoesScoreAdd.Text);
                addCommand.Parameters.Add("RottenTomatoesScore", SqlDbType.Int).Value = score;
                object earnings = tbBoxOfficeEarningsAdd.Text;
                if (earnings == null)
                    earnings = DBNull.Value;
                else earnings = decimal.Parse(tbBoxOfficeEarningsAdd.Text);
                addCommand.Parameters.Add("TotalEarned", SqlDbType.Decimal).Value = earnings;

                movie.QueryMovieData(addCommand);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Some required fields were entered incorrectly or left blank" + ex.Message);
                return;
            }
            MessageBox.Show("Movie Added");
            textBoxClearMethod();
        }

        //method to clear textboxes
        public void textBoxClearMethod()
        {
            tbMovieTitleAdd.Text = "";
            tbYearAdd.Text = "";
            tbDirectorAdd.Text = "";
            tbRottenTomatoesScoreAdd.Text = "";
            comboBoxGenreAdd.SelectedIndex = -1;
            tbBoxOfficeEarningsAdd.Text = "";
        }
    }
}

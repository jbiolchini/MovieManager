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
        //Initializes form
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

                //checks to make sure year can be parsed as an int
                if (!int.TryParse(tbYearAdd.Text.ToString(), out int a))
                {
                    MessageBox.Show("Year field only accepts numeric values");
                    tbYearAdd.Text = "";
                    return;
                }

                //returns the integer representation of the specified genre as required by the database
                int genreInt = movie.GetGenreInt(comboBoxGenreAdd.SelectedItem.ToString());

                // create SqlCommand, parameterizes the SQL string to prevent injection, then checks for score/earnings null
                //stores those properly and then parameterizes the null value or the value taht was entered. 
                //If all tests pass, adds movie to database, and displays confirmation messagebox, followed by text boxes being cleared
                SqlCommand addCommand = new SqlCommand("INSERT INTO Movies (Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned) " +
                    "VALUES(@Title, @Year, @Director, @Genre, @RottenTomatoesScore, @TotalEarned)",
                    movie.Connection());
                addCommand.Parameters.AddWithValue("Title", tbMovieTitleAdd.Text);
                addCommand.Parameters.AddWithValue("Year", tbYearAdd.Text);
                addCommand.Parameters.AddWithValue("Director", tbDirectorAdd.Text);
                addCommand.Parameters.AddWithValue("Genre", genreInt);
                object score = tbRottenTomatoesScoreAdd.Text;
                if ((string)score == "")
                    score = DBNull.Value;
                else 
                    score = int.Parse(score.ToString());
                addCommand.Parameters.Add("RottenTomatoesScore", SqlDbType.Int).Value = score;
                object earnings = tbBoxOfficeEarningsAdd.Text;
                if ((string)earnings == "")
                    earnings = DBNull.Value;
                else
                    earnings = decimal.Parse(earnings.ToString());
                addCommand.Parameters.Add("TotalEarned", SqlDbType.Decimal).Value = earnings;
                movie.QueryMovieData(addCommand);
            }
            catch (Exception inputException)
            {
                //catches if a field was left blank (except for score and earnings, and catches if user input was inccorect
                MessageBox.Show("Error: Some required fields were entered incorrectly or left blank " + inputException.Message);
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

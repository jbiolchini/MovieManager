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
    public partial class FormDeleteMovie : Form
    {
        public FormDeleteMovie()
        {
            InitializeComponent();
        }

        //Deltes movie from database, pass sql statement into QueryMovieData method, 
        private void btDeleteDelete_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            string countString = $"SELECT COUNT (*) FROM Movies WHERE Title = '{tbMovieTitleDelete.Text}'";
            int count = movie.MovieCount(countString);
            MessageBox.Show($"{count}");
            string deleteString = $"DELETE FROM Movies WHERE Title = '{tbMovieTitleDelete.Text}'";
            if (count == 0)
            {
                MessageBox.Show("Movie does not exist in the database");
                
            }
            else
            {
                movie.QueryMovieData(deleteString);
                MessageBox.Show("Movie Deleted");
            }
            //Confirmatino of Movie deletion
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
    }
}

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

        private void btDeleteDelete_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            string deleteString = $"DELETE FROM Movies WHERE Title = '{tbMovieTitleDelete.Text}'";
            movie.QueryMovieData(deleteString);
            MessageBox.Show("Movie Deleted");
            textBoxClearMethod();
            
        }

        private void btClearDelete_Click(object sender, EventArgs e)
        {
            textBoxClearMethod();
        }

        private void btCloseDelete_Click(object sender, EventArgs e)
        {
            Close();
        }
        
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

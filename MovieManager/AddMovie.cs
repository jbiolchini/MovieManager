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
            int genreInt = movie.GetGenreInt(comboBoxGenreAdd.SelectedItem.ToString());
            string addString = $"INSERT INTO Movies VALUES('{tbMovieTitleAdd.Text}',{tbYearAdd.Text},'{tbDirectorAdd.Text}',{genreInt},{int.Parse(tbRottenTomatoesScoreAdd.Text)},{decimal.Parse(tbBoxOfficeEarningsAdd.Text)})";
            movie.QueryMovieData(addString);
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
            comboBoxGenreAdd.ResetText();
            tbBoxOfficeEarningsAdd.Text = "";
        }
    }
}

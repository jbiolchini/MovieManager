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
        public FormMain()
        {
            InitializeComponent();
            try
            {
                using (SqlConnection connection = new SqlConnection(
                @"Data Source=coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433;Initial Catalog=CSCI1630;User ID=rw1630;Password=Project!;"))
                {
                    connection.Open();
                    
                }
                MessageBox.Show("Successfully opened the database.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while opening a connection tothe database: { ex.Message }");
            }
            
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

       
    }
}

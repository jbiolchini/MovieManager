using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MovieManager
{
    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public int RottenTomatoesScore { get; set; }
        public decimal TotalEarned { get; set; }

        // Genre int to string
        public string GetGenreString(int genreCode)
        {
            string genreString = null;
            switch (genreCode)
            {
                case 1:
                    genreString = "Animation";
                    break;
                case 2:
                    genreString = "Action";
                    break;
                case 3:
                    genreString = "Comedy";
                    break;
                case 4:
                    genreString = "Drama";
                    break;
                case 5:
                    genreString = "Horror";
                    break;
                case 6:
                    genreString = "Mystery";
                    break;
                case 7:
                    genreString = "Romance";
                    break;
                case 8:
                    genreString = "Science Fiction";
                    break;
                case 9:
                    genreString = "Western";
                    break;
            }
            return genreString;
        }
        //GenreString back to int to pass back into database for adding/updating movies
        public int GetGenreInt(string genreEntered)
        {
            
            int genreint = 0;
            if (genreEntered == "Animation")
                genreint = 1;
            else if (genreEntered == "Action")
                genreint = 2;
            else if (genreEntered == "Comedy")
                genreint = 3;
            else if (genreEntered == "Drama")
                genreint = 4;
            else if (genreEntered == "Horror")
                genreint = 5;
            else if (genreEntered == "Mystery")
                genreint = 6;
            else if (genreEntered == "Romance")
                genreint = 7;
            else if (genreEntered == "Science Fiction")
                genreint = 8;
            else if (genreEntered == "Western")
                genreint = 9;
            return genreint;

        }
        //Connection String MAKE SURE TO CLOSE CONNECTION IN ANY OTHER CREATED METHODS
        public SqlConnection Connection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com";
            builder.InitialCatalog = "CSCI1630";
            builder.UserID = "rw1630";
            builder.Password = "Project!";
            SqlConnection connection = new SqlConnection(builder.ToString());
            connection.Open();
            return connection;
        }
        public int MovieCount(string queryString)
        {
            try
            {
                SqlConnection databaseConnection = Connection();
                SqlCommand queryText = databaseConnection.CreateCommand();
                queryText.CommandText = queryString;
                int movieCount = (int)queryText.ExecuteScalar();
                databaseConnection.Close();
                return movieCount;
            }
            catch (Exception)
            {
                MessageBox.Show("Database Connection Error");
                return 0;
            }
        }
        //Connects to database with connection method, receives querey string from caller, checks if it is a Select querey, or not
        //performs the Sql command.
        public List<Movie> QueryMovieData(string queryString)
        {
            List<Movie> movies = new List<Movie>();
            try
            {
                SqlConnection databaseConnection = Connection();
                SqlCommand queryText = databaseConnection.CreateCommand();
                queryText.CommandText = queryString;
                if (queryString.Contains("SELECT"))
                {
                    SqlDataReader reader = queryText.ExecuteReader();
                    while (reader.Read())
                    {
                        Movie movie = new Movie();
                        movie.Title = reader[0].ToString();
                        movie.Year = int.Parse(reader[1].ToString());
                        movie.Director = reader[2].ToString();
                        movie.Genre = movie.GetGenreString((int)reader[3]);
                        if (!reader.IsDBNull(4))
                            movie.RottenTomatoesScore = (int)reader[4];
                        if (!reader.IsDBNull(5))
                            movie.TotalEarned = (decimal)reader[5];
                        movies.Add(movie);
                    }
                }
                else
                {
                    queryText.ExecuteNonQuery();
                }
                databaseConnection.Close();
                return movies;
            }
            catch (Exception)
            {
                MessageBox.Show("Database Connection Error");
                movies.Add(new Movie());
                return movies;
            }
        }
    }
}
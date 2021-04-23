using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
            switch(genreCode)
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
        public List<Movie> GetMovieData(string queryString)
        {
            List<Movie> movies = new List<Movie>();
            using (SqlConnection connection = new SqlConnection(
                    @"Data Source=coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433;Initial Catalog=CSCI1630;User ID=rw1630;Password=Project!;"))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Movie movie = new Movie();

                    int titleIndex = reader.GetOrdinal(nameof(Movie.Title));
                    movie.Title = reader.GetString(titleIndex);

                    int yearIndex = reader.GetOrdinal(nameof(Movie.Year));
                    movie.Year = reader.GetInt32(yearIndex);

                    int directorIndex = reader.GetOrdinal(nameof(Movie.Director));
                    movie.Director = reader.GetString(directorIndex);

                    int genreIndex = reader.GetOrdinal(nameof(Movie.Genre));
                    movie.Genre = movie.GetGenreString(reader.GetInt32(genreIndex));

                    int scoreIndex = reader.GetOrdinal(nameof(Movie.RottenTomatoesScore));
                    if (!reader.IsDBNull(scoreIndex))
                        movie.RottenTomatoesScore = reader.GetInt32(scoreIndex);

                    int revenueIndex = reader.GetOrdinal(nameof(Movie.TotalEarned));
                    if (!reader.IsDBNull(revenueIndex))
                        movie.TotalEarned = reader.GetDecimal(revenueIndex);

                    movies.Add(movie);
                }
                return movies;
            }
        } 
        
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}

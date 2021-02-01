using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeanaiRoberts_FinalProject
{
    public class movieData
    {
        string movieTitle;
        string relased;
        string rated;
        string runtime;
        string genre;
        string plot;

        public string MovieTitle
        {
            get { return movieTitle; }

            set { movieTitle = value; }
        }

        public string ReleaseDate
        {
            get { return relased; }

            set { relased = value; }
        }

        public string Rated
        {
            get { return rated; }

            set { rated = value; }
        }

        public string Runtime
        {
            get { return runtime; }

            set { runtime = value; }
        }

        public string Genre
        {
            get { return genre; }

            set { genre = value; }
        }

        public string Plot
        {
            get { return plot; }

            set { plot = value; }
        }

        public override string ToString()
        {
            return $" {MovieTitle} Runtime: {runtime}";
        }
    }
}

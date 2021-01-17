using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeanaiRoberts_CE02
{
    public class MovieObject
    {
        string mTitle;
        decimal mRYear;
        string mPublisher;
        string mAuthor;
        string mGenre;
        int imgIndex;

        public string Title
        {
            get { return mTitle; }

            set { mTitle = value; }
        }

        public decimal Year
        {
            get { return mRYear; }

            set { mRYear = value; }
        }

        public string Publisher
        {
            get { return mPublisher; }

            set { mPublisher = value; }
        }

        public string Author
        {
            get { return mAuthor; }

            set { mAuthor = value; }
        }

        public string Genre
        {
            get { return mGenre; }

            set { mGenre = value; }
        }

        public int Index
        {
            get { return imgIndex; }

            set { imgIndex = value; }
        }

        public override string ToString()
        {
            return $"{Title}";
        }
    }
}

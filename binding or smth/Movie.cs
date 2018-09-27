using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binding_or_smth
{
    class Movie
    {
        private int id;
        private string title;
        private DateTime releaseDate;
        private string director;
        private bool isColor;
        private string ratio;
        private string genre;

        public Movie(int id, string title, DateTime releaseDate, string director, bool isColor, string ratio, string genre)
        {
            Genre = genre;
            Ratio = ratio;
            IsColor = isColor;
            Director = director;
            ReleaseDate = releaseDate;
            Title = title;
            ID = id;
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public string Ratio
        {
            get { return ratio; }
            set { ratio = value; }
        }

        public bool IsColor
        {
            get { return isColor; }
            set { isColor = value; }
        }

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        public int ID
        {
            get { return id; }
            set { id = value; }
        }

    }
}

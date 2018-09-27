using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binding_or_smth
{
    class Movie
    {
        private int id = 0;
        private string title;
        private DateTime releaseDate;
        private string director;
        private bool isColor;
        private string format;
        private string genre;

        public Movie(string title, DateTime releaseDate, string director, bool isColor, string ratio, string genre)
        {
            Genre = genre;
            Format = ratio;
            IsColor = isColor;
            Director = director;
            ReleaseDate = releaseDate;
            Title = title;
            this.id = id++;
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public string Format
        {
            set { format = value; }
            get { return format; }
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
        }

    }
}

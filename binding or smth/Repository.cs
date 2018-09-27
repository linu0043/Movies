using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binding_or_smth
{
    class Repository
    {
        List<Movie> movieList = new List<Movie>();

        public Repository()
        {
            movieList.Add(new Movie("2001: A Space Odyssey", new DateTime(2018, 4, 3), "Stanley Kubrick", true, "2.20:1", "SciFi"));
            movieList.Add(new Movie("Avengers: Infinity War", new DateTime(1968, 4, 27), "Anthony Russo, Joe Russo", true, "2.39:1", "Action"));
        }

        public List<Movie> GetAllMovies()
        {
            return movieList;
        }
        public void AddMovie(Movie movie)
        {
            movieList.Add(movie);
        }
        public void UpdateMovie(Movie movieToUpdate)
        {
            foreach (Movie movie in movieList)
            {
                if (movie.ID == movieToUpdate.ID)
                {
                    movieList.Remove(movie);
                    movieList.Add(movieToUpdate);
                    break;
                }
            }
        }
    }
}

using Sessions.Model;

namespace Sessions.Model
{
    //Класс получения данных(для примера)
    public class MovieSessionService
    {
        static readonly Movie Movie1 = new Movie("movie_name1", "movie_director1", "movie_style1", "movie_description1");
        static readonly Movie Movie2 = new Movie("movie_name2", "movie_director2", "movie_style2", "movie_description2");
        static readonly Movie Movie3 = new Movie("movie_name3", "movie_director3", "movie_style3", "movie_description3");
        static readonly IDictionary<string, Movie> MovieList = new Dictionary<string, Movie>
               {
                   {Movie1.Name, Movie1},
                   {Movie2.Name, Movie2},
                   {Movie3.Name, Movie3}
               };
        public readonly IDictionary<string, List<Session>> SessionList = new Dictionary<string, List<Session>>
               {
                   {Movie1.Name, new List<Session>{new Session("10.10.2010", "12:00"), new Session("10.10.2010", "16:00")}},
                   {Movie2.Name, new List<Session>{new Session("11.11.2011", "12:00"), new Session("11.11.2010", "16:00")}},
                   {Movie3.Name, new List<Session>{new Session("12.12.2012", "12:00"), new Session("12.12.2010", "16:00")}}
               };
        public Movie GetMovie(string name)
        {
            MovieList.TryGetValue(name, out Movie movie);
            return movie;
        }
    }
}

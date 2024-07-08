namespace Sessions.Model
{
    public class Movie
    {
        public string Name { get; }
        public string Director { get; }
        public string Style { get; }
        public string Description { get; }
        public Movie(string name, string director, string style, string description)
        {
            Name = name;
            Director = director;
            Style = style;
            Description = description;
        }
    }
}

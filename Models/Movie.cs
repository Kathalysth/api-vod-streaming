namespace Models
{
    public class Movie
    {
        public long Id { get; set; }
        public required string Title { get; set; }
        public required string Year { get; set; }
        public required string Poster { get; set; }
    }
}
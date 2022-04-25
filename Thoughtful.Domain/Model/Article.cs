namespace Thoughtful.Domain.Model
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Subtitle { get; set; }
        public string Body { get; set; } = null!;

        public int AuthorId { get; set; }
        public Author? Author { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }
        public int NumberOfLikes { get; set; }
        public int NumberOfShares { get; set; }

        public ICollection<Category> Categories { get; set; } = new List<Category>();
    }
}

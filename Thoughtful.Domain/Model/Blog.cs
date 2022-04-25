namespace Thoughtful.Domain.Model
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public int AuthorId { get; set; }

        public Author Owner { get; set; }

        public ICollection<Author> Contributors { get; set; } = new List<Author>();
    }
}

namespace Thoughtful.Domain.Model
{
    public class Author
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public DateTime DateOfBirth { get; set; }

        public string? Bio { get; set; }

        //public ICollection<Blog> BlogContributions { get; set; } = new List<Blog>();
    }
}

﻿namespace Thoughtful.Domain.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Article> Articles { get; set; } = new List<Article>();
    }
}

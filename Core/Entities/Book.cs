using System.Collections.Generic;

namespace Core.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public PublishingCompany PublishingCompany { get; set; }
        public List<BookAuthor> AuthorsLink { get; set; }
    }
}

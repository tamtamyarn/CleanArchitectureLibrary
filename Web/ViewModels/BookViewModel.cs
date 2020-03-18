using Core.Entities;
using System.Collections.Generic;

namespace Web.ViewModels
{
    public class BookViewModel
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public PublishingCompany PublishingCompany { get; set; }
        public List<Author> Authors { get; set; }
    }
}

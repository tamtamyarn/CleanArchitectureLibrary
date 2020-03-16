using Core.Entities;

namespace Web.ViewModels
{
    public class BookViewModel
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public PublishingCompany PublishingCompany { get; set; }
    }
}

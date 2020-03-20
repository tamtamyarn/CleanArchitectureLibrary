using System.Collections.Generic;

namespace Web.InputModels
{
    public class BookInputModel
    {
        public string Title { get; set; }
        public int PublishingCompanyId { get; set; }
        //public int AuthorId { get; set; }
        public List<int> AuthorIds { get; set; }
    }
}

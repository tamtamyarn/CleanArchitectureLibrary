using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Entities;
using Web.InputModels;
using Web.ViewModels;

namespace Web.Common
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<PublishingCompany, PublishingComapnyViewModel>();
            CreateMap<PublishingCompanyInputModel, PublishingCompany>();
            CreateMap<Book, BookViewModel>();
            CreateMap<BookInputModel, Book>();
            CreateMap<Author, AuthorViewModel>();
            CreateMap<AuthorInputModel, Author>();
        }
    }
}

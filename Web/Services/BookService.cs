using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.InputModels;
using Web.Interfaces;
using Web.ViewModels;

namespace Web.Services
{
    public class BookService : IBookService
    {
        private readonly IMapper mapper;
        private readonly IBookRepository repository;
        private readonly IPublishingCompanyRepository publishingCompanyRepository;

        public BookService(IMapper mapper, IBookRepository repository, IPublishingCompanyRepository publishingCompanyRepository)
        {
            this.mapper = mapper;
            this.repository = repository;
            this.publishingCompanyRepository = publishingCompanyRepository;
        }

        public async Task<BookViewModel> AddAsync(BookInputModel bookInputModel)
        {
            var book = mapper.Map<Book>(bookInputModel);
            book.PublishingCompany = await publishingCompanyRepository.GetAsync(bookInputModel.PublishingCompanyId);
            var result = await repository.AddAsync(book);
            var bookViewModel = mapper.Map<BookViewModel>(result);
            return bookViewModel;
        }

        public async Task<BookViewModel> GetAsync(int id)
        {
            var book = await repository.GetAsync(id);
            var bookViewModel = mapper.Map<BookViewModel>(book);
            return bookViewModel;
        }

        public async Task<List<BookViewModel>> ListAsync()
        {
            var books = await repository.ListAsync();
            var booksViewModel = mapper.Map<List<BookViewModel>>(books);
            return booksViewModel;
        }
    }
}

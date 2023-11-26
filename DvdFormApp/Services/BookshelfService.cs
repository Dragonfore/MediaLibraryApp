﻿using DvdFormApp.DataTransferObjects;
using DvdFormApp.Repositories;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace DvdFormApp.Services
{
    public class BookshelfService : IBookshelfService
    {
        private IBookshelfRepository _bookshelfRepository;
        private ILoggerFactory _logger;

        public BookshelfService(IBookshelfRepository bookshelfRepository, ILoggerFactory logger)
        {
            _bookshelfRepository = bookshelfRepository;
            _logger = logger;
        }

        public IQueryable<Bookshelf> GetBookshelves()
        {
            return _bookshelfRepository.GetBookshelves();
        }

        public Bookshelf CreateBookshelf(BookshelfDto bookshelfDto)
        {
            return _bookshelfRepository.CreateBookshelf(bookshelfDto);
        }
    }
}

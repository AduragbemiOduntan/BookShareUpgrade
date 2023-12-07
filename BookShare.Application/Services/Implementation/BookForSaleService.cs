using AutoMapper;
using BookShare.Application.Services.Abstraction;
using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Domain.Model;
using BookShare.Infrastructure.Repository.Abstraction;
using BookShare.Infrastructure.Repository.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Application.Services.Implementation
{
    public class BookForSaleService : IBookForSaleService
    {
        private readonly IRepositoryBase<BookForSale> _repository;
        private readonly IMapper _mapper;

        public BookForSaleService(IRepositoryBase<BookForSale> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<StandardResponse<ICollection<BookDto>>> GetAllBooksAsync()
        {
            var books =await _repository.FindAll(false).ToListAsync();
            var booksReturned = _mapper.Map<ICollection<BookDto>>(books);
            return StandardResponse<ICollection<BookDto>>.Success($"Request successful ", booksReturned, 200);
        }
    }
}

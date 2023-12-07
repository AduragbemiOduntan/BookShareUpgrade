using AutoMapper;
using BookShare.Application.Services.Abstraction;
using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Domain.Model;
using BookShare.Infrastructure.Repository.Abstraction;
using BookShare.Infrastructure.Repository.Implementation;
using Microsoft.EntityFrameworkCore;

namespace BookShare.Application.Services.Implementation
{
    public class DeliveryService : IDeliveryService
    {
        private readonly IRepositoryBase<BookForSale> _repository;
        private readonly IMapper _mapper;

        public DeliveryService(IRepositoryBase<BookForSale> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<StandardResponse<ICollection<DeliveryDto>>> GetAllBooksAsync()
        {
            var books = await _repository.FindAll(false).ToListAsync();
            var booksReturned = _mapper.Map<ICollection<DeliveryDto>>(books);
            return StandardResponse<ICollection<DeliveryDto>>.Success($"Request successful ", booksReturned, 200);
        }
    }
}

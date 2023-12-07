using AutoMapper;
using BookShare.Application.Services.Abstraction;
using BookShare.Domain.Model;
using BookShare.Infrastructure.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Application.Services.Implementation
{
    internal class KycService : IKycService
    {
        private readonly IRepositoryBase<Book> _repository;
        private readonly IMapper _mapper;

        public KycService(IRepositoryBase<Book> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}

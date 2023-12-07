using AutoMapper;
using BookShare.Application.Services.Abstraction;
using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Common.Enum;
using BookShare.Domain.Model;
using BookShare.Infrastructure.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BookShare.Application.Services.Implementation
{
    public class TransporterService : ITransporterService
    {
        private readonly IRepositoryBase<Transporter> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<TransporterService> _logger;

        public TransporterService(IRepositoryBase<Transporter> repository, IMapper mapper, ILogger<TransporterService> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<StandardResponse<TransportResponseDto>> UpdateTransporterAsync(string id,bool trackChanges, TransporterRequestDto requestDto)
        {
            var transporter = await _repository.FindByCondition(t => t.TransporterId ==id, false).SingleOrDefaultAsync();
            if (transporter == null)
            {
                _logger.LogInformation("Attempting to update a transporter");
                var errorMessage = $"Transporter does not exist";
                return StandardResponse<TransportResponseDto>.Failed(errorMessage, 400);
            }
            var updateTransporter = _mapper.Map<Transporter>(requestDto);
            _repository.Update(updateTransporter);
            await _repository.SaveChangesAync();
            var transporterUpdated = _mapper.Map<TransportResponseDto>(updateTransporter);
            return StandardResponse<TransportResponseDto>.Success($"Successfully updated Transporter", transporterUpdated, 200);
        }
        public async Task<StandardResponse<TransportResponseDto>> FindTransporterByIdAsync(string id)
        {
            var transporter = await _repository.FindByCondition(t => t.TransporterId == id, false).SingleOrDefaultAsync();
            if (transporter == null)
            {
                _logger.LogInformation("Attempting to find transporter by Id");
                var errorMessage = $"Transporter does not exist";
                return StandardResponse<TransportResponseDto>.Failed(errorMessage, 400);
            }
            var transporterReturned = _mapper.Map<TransportResponseDto>(transporter);
            return StandardResponse<TransportResponseDto>.Success($"Successfully retrieved a transporter", transporterReturned, 200);
        }
        public async Task<StandardResponse<IEnumerable<TransportResponseDto>>> FindAllTransportersAsync()
        {
            _logger.LogInformation("Attempting to get all transporters");
            var transporters = await _repository.FindAll(false).ToListAsync();
            var transporterReturned = _mapper.Map<IEnumerable<TransportResponseDto>>(transporters);
            return StandardResponse<IEnumerable<TransportResponseDto>>.Success($"Request successful", transporterReturned, 200);
        }
        public async Task<StandardResponse<TransportResponseDto>> DeleteTransporterAsync(string id)
        {
            var transporter = await _repository.FindByCondition(t =>t.TransporterId ==id, false).SingleOrDefaultAsync();
            if (transporter == null)
            {
                _logger.LogInformation("Attempting to delete a transporter");
                var errorMessage = $"Transporter does not exist";
                return StandardResponse<TransportResponseDto>.Failed(errorMessage, 400);
            }
            _repository.Delete(transporter);
            await _repository.SaveChangesAync();
            var transporterReturned = _mapper.Map<TransportResponseDto>(transporter);
            return StandardResponse<TransportResponseDto>.Success($"Successfully retrieved a transporter", transporterReturned, 200);
        }
        public async Task<StandardResponse<IEnumerable<TransportResponseDto>>> FindTransporterByCompanyNameAsync(string companyName)
        {
            _logger.LogInformation("Attempting to get transporter by company name");
            var transporter = await _repository.FindByCondition(t =>t.CompanyName ==companyName, true).ToListAsync();
            var transporterReturned = _mapper.Map<IEnumerable<TransportResponseDto>>(transporter);
            return StandardResponse<IEnumerable<TransportResponseDto>>.Success($"Successful", transporterReturned, 200);
        }       
        public async Task<StandardResponse<TransportResponseDto>> FindTransporterByLocationIdAsync(string locationId)
        {
           var transporter = await _repository.FindByCondition(t => t.LocationId == locationId, false).SingleOrDefaultAsync();
           if (transporter == null)
           {
               _logger.LogInformation("Attempting to get transporter with a location Id");
                var errorMessage = $"Transporter not found";
               return StandardResponse<TransportResponseDto>.Failed(errorMessage, 400);
           }
           var locationReturned = _mapper.Map<TransportResponseDto>(transporter);
           return StandardResponse<TransportResponseDto>.Success($"Successfully retrieved transporter with location", locationReturned, 200);
        }  
    }
}
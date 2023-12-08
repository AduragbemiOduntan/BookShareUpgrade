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

        public TransporterService(IRepositoryBase<Transporter> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<StandardResponse<TransporterResponseDto>> CreateTransporterAsync(TransporterRequestDto requestDto)
        {
            if (requestDto is null)
            {
                var errorMessage = $"Transporter cannot be null";
                return StandardResponse<TransporterResponseDto>.Failed(errorMessage, 400);
            }
            var transporter = _mapper.Map<Transporter>(requestDto);
            await _repository.CreateAsync(transporter);
            await _repository.SaveChangesAync();
            var transporterReturned = _mapper.Map<TransporterResponseDto>(transporter);
            return StandardResponse<TransporterResponseDto>.Success("Transporter created, successfully", transporterReturned, 200);
        }
        public async Task<StandardResponse<TransporterResponseDto>> UpdateTransporterAsync(string id,bool trackChanges, TransporterRequestDto requestDto)
        {
            var transporter = await _repository.FindByCondition(t => t.TransporterId ==id, false).SingleOrDefaultAsync();
            if (transporter is null)
            {
                var errorMessage = $"Transporter does not exist";
                return StandardResponse<TransporterResponseDto>.Failed(errorMessage, 400);
            }
            var updateTransporter = _mapper.Map<Transporter>(requestDto);
            _repository.Update(updateTransporter);
            await _repository.SaveChangesAync();
            var transporterUpdated = _mapper.Map<TransporterResponseDto>(updateTransporter);
            return StandardResponse<TransporterResponseDto>.Success($"Successfully updated Transporter", transporterUpdated, 200);
        }
        public async Task<StandardResponse<TransporterResponseDto>> FindTransporterByIdAsync(string id)
        {
            var transporter = await _repository.FindByCondition(t => t.TransporterId == id, false).SingleOrDefaultAsync();
            if (transporter is null)
            {
                var errorMessage = $"Transporter does not exist";
                return StandardResponse<TransporterResponseDto>.Failed(errorMessage, 400);
            }
            var transporterReturned = _mapper.Map<TransporterResponseDto>(transporter);
            return StandardResponse<TransporterResponseDto>.Success($"Successfully retrieved a transporter", transporterReturned, 200);
        }
        public async Task<StandardResponse<IEnumerable<TransporterResponseDto>>> FindAllTransportersAsync()
        {
            var transporters = await _repository.FindAll(false).ToListAsync();
            var transporterReturned = _mapper.Map<IEnumerable<TransporterResponseDto>>(transporters);
            return StandardResponse<IEnumerable<TransporterResponseDto>>.Success($"Request successful", transporterReturned, 200);
        }
        public async Task<StandardResponse<IEnumerable<TransporterResponseDto>>> FindTransporterByLocation(string city, string state)
        {
            var transporter = await _repository.FindByCondition(r => r.Location.City == city && r.Location.State == state, true).Include(city => city).ToListAsync();
            if (transporter is null)
            {
                var errorMessage = $"City and State do not exist";
                return StandardResponse<IEnumerable<TransporterResponseDto>>.Failed(errorMessage, 400);
            }
            var transporterReturned = _mapper.Map<IEnumerable<TransporterResponseDto>>(transporter);
            return StandardResponse<IEnumerable<TransporterResponseDto>>.Success("Successful", transporterReturned, 200);

        }
        public async Task<StandardResponse<IEnumerable<TransporterResponseDto>>> FindTransporterByCompanyNameAsync(string companyName)
        {
            var transporter = await _repository.FindByCondition(t =>t.CompanyName ==companyName, true).ToListAsync();
            if (transporter is null)
            {
                var errorMessage = $"Company name not found";
                return StandardResponse<IEnumerable<TransporterResponseDto>>.Failed(errorMessage, 400);
            }
            var transporterReturned = _mapper.Map<IEnumerable<TransporterResponseDto>>(transporter);
            return StandardResponse<IEnumerable<TransporterResponseDto>>.Success($"Successful", transporterReturned, 200);
        }
        public async Task<StandardResponse<TransporterResponseDto>> DeleteTransporterAsync(string id)
        {
            var transporter = await _repository.FindByCondition(t => t.TransporterId == id, false).SingleOrDefaultAsync();
            if (transporter is null)
            {
                var errorMessage = $"Transporter does not exist";
                return StandardResponse<TransporterResponseDto>.Failed(errorMessage, 400);
            }
            _repository.Delete(transporter);
            await _repository.SaveChangesAync();
            var transporterReturned = _mapper.Map<TransporterResponseDto>(transporter);
            return StandardResponse<TransporterResponseDto>.Success($"Successfully retrieved a transporter", transporterReturned, 200);
        }
    }
}
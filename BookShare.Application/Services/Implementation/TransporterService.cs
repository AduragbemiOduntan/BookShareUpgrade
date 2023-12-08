using AutoMapper;
using BookShare.Application.Services.Abstraction;
using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Domain.Model;
using BookShare.Infrastructure.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;

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
                return StandardResponse<TransporterResponseDto>.Failed(errorMessage, 401);
            }
            Transporter transporter = new Transporter();
            {
                transporter.CompanyName = requestDto.CompanyName;
                transporter.PhoneNumber = requestDto.PhoneNumber;
                transporter.LogoUrl = requestDto.LogoUrl;
                transporter.UserId = requestDto.UserId;
            };
            //var transporter = _mapper.Map<Transporter>(requestDto);
            await _repository.CreateAsync(transporter);
            await _repository.SaveChangesAync();
            var transporterReturned = _mapper.Map<TransporterResponseDto>(transporter);
            return StandardResponse<TransporterResponseDto>.Success("Transporter created, successfully", transporterReturned, 200);
        }
        public async Task<StandardResponse<TransporterResponseDto>> UpdateTransporterAsync(string id,bool trackChanges, TransporterRequestDto requestDto)
        {
            var transporter = await _repository.FindByCondition(t => t.UserId ==id, false).SingleOrDefaultAsync();
            if (transporter is null)
            {
                var errorMessage = $"Transporter does not exist";
                return StandardResponse<TransporterResponseDto>.Failed(errorMessage, 404);
            }
            var updateTransporter = _mapper.Map<Transporter>(requestDto);
            _repository.Update(updateTransporter);
            await _repository.SaveChangesAync();
            var transporterUpdated = _mapper.Map<TransporterResponseDto>(updateTransporter);
            return StandardResponse<TransporterResponseDto>.Success($"Successfully updated Transporter", transporterUpdated, 200);
        }
        public async Task<StandardResponse<TransporterResponseDto>> FindTransporterByIdAsync(string id)
        {
            var transporter = await _repository.FindByCondition(t => t.UserId == id, false).SingleOrDefaultAsync();
            if (transporter is null)
            {
                var errorMessage = $"Transporter does not exist";
                return StandardResponse<TransporterResponseDto>.Failed(errorMessage, 404);
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
        public async Task<StandardResponse<IEnumerable<TransporterResponseDto>>> FindTransporterByLocationAsync(string city, string state)
        {
            /*if (string.IsNullOrWhiteSpace(city))
            {
                var errorMessage = "Company name cannot be empty or null";
                return StandardResponse<IEnumerable<TransporterResponseDto>>.Failed(errorMessage, 400);
            }*/
            var transporter = await _repository.FindByCondition(r => r.Location.City.Contains(city) && r.Location.State.Contains(state), true).Include(t=>t.Location).ToListAsync();
            if (transporter is null)
            {
                var errorMessage = $"Enter city and state";
                return StandardResponse<IEnumerable<TransporterResponseDto>>.Failed(errorMessage, 401);
            }
            var transporterReturned = _mapper.Map<IEnumerable<TransporterResponseDto>>(transporter);
            return StandardResponse<IEnumerable<TransporterResponseDto>>.Success("Successful", transporterReturned, 200);
        }
        public async Task<StandardResponse<IEnumerable<TransporterResponseDto>>> FindTransporterByCompanyNameAsync(string companyName)
        {
            /*if(string.IsNullOrWhiteSpace(companyName))
            {
                var errorMessage = "Company name cannot be empty or null";
                return StandardResponse<IEnumerable<TransporterResponseDto>>.Failed(errorMessage, 400);
            }*/
            var transporter = await _repository.FindByCondition(t =>t.CompanyName ==companyName, true).ToListAsync();
            if (transporter is null)
            {
                var errorMessage = $"Enter company name";
                return StandardResponse<IEnumerable<TransporterResponseDto>>.Failed(errorMessage, 401);
            }
            var transporterReturned = _mapper.Map<IEnumerable<TransporterResponseDto>>(transporter);
            return StandardResponse<IEnumerable<TransporterResponseDto>>.Success($"Successful", transporterReturned, 200);
        }
        public async Task<StandardResponse<TransporterResponseDto>> DeleteTransporterAsync(string id)
        {
            var transporter = await _repository.FindByCondition(t => t.UserId == id, false).SingleOrDefaultAsync();
            if (transporter is null)
            {
                var errorMessage = $"Transporter does not exist";
                return StandardResponse<TransporterResponseDto>.Failed(errorMessage, 404);
            }
            _repository.Delete(transporter);
            await _repository.SaveChangesAync();
            var transporterReturned = _mapper.Map<TransporterResponseDto>(transporter);
            return StandardResponse<TransporterResponseDto>.Success($"Successfully retrieved a transporter", transporterReturned, 200);
        }
    }
}
using AutoMapper;
using BookShare.Application.Services.Abstraction;
using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Common.Exceptions;
using BookShare.Domain.Model;
using BookShare.Infrastructure.Repository.Abstraction;
using BookShare.Infrastructure.Repository.Implementation;
using Microsoft.EntityFrameworkCore;

namespace BookShare.Application.Services.Implementation
{
    public class DeliveryService : IDeliveryService
    {
        private readonly IRepositoryBase<Delivery> _repository;
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly IMapper _mapper;

        public DeliveryService(IRepositoryBase<Delivery> repository, IMapper mapper, IDeliveryRepository deliveryRepository)
        {
            _repository = repository;
            _mapper = mapper;
            _deliveryRepository = deliveryRepository;
        }

        public async Task<DeliveryDto> CreateDelivery(DeliveryCreationDto deliveryCreationDto)
        {
            var deliveryToCreate = _mapper.Map<Delivery>(deliveryCreationDto);

            _deliveryRepository.CreateDelivery(deliveryToCreate);
           await _repository.SaveChangesAync();

            var deliveryToReturnDto = _mapper.Map<DeliveryDto>(deliveryToCreate);

            return deliveryToReturnDto;
        }

        public async Task DeleteDelivery(string deliveryId, bool trackChanges)
        {
            var deliveryDb = await CheckIfDeliveryExists(deliveryId, trackChanges);

             _deliveryRepository.DeleteDelivery(deliveryDb);
            await _repository.SaveChangesAync();
        }

        public async Task<IEnumerable<DeliveryDto>> GetAllDeliveriesAsync(bool trackChanges)
        {
            var deliveriesDb = await _deliveryRepository.GetAllDeliveriesAsync(trackChanges);

            var deliveriesDto = _mapper.Map<IEnumerable<DeliveryDto>>(deliveriesDb);

            return deliveriesDto;
        }

        public async Task<IEnumerable<DeliveryDto>> GetAllDeliveriesByRequestId(string requestId, bool trackChanges)
        {
            var deliveriesDb = await _deliveryRepository.GetAllDeliveriesByRequestIdAsync(requestId, trackChanges);
            if (deliveriesDb == null)
                throw new DeliveryNotFoundException(requestId);

            var deliveriesDto = _mapper.Map<IEnumerable<DeliveryDto>>(deliveriesDb);

            return deliveriesDto;
        }

        public async Task<IEnumerable<DeliveryDto>> GetAllDeliveriesByTransporterId(string transporterId, bool trackChanges)
        {
            var deliveriesDb =await _deliveryRepository.GetAllDeliveriesByTransporterId(transporterId, trackChanges);
            if (deliveriesDb == null)
                throw new DeliveryNotFoundException(transporterId);

            var deliveriesDto = _mapper.Map<IEnumerable<DeliveryDto>>(deliveriesDb);

            return deliveriesDto;

        }

        public async Task<IEnumerable<DeliveryDto>> GetAllDeliveriesByUserId(string userId, bool trackChanges)
        {
            var deliveriesDb = await _deliveryRepository.GetAllDeliveriesByUserId(userId, trackChanges);

            if(deliveriesDb == null)
                throw new DeliveryNotFoundException(userId);

            var deliveriesDto = _mapper.Map<IEnumerable<DeliveryDto>>(deliveriesDb);

            return deliveriesDto;
        }

        public async Task<DeliveryDto> GetDeliveryByDeliveryId(string deliveryId, bool trackChanges)
        {
            var deliveryDb = await CheckIfDeliveryExists(deliveryId, trackChanges);

            var deliveryDto = _mapper.Map<DeliveryDto>(deliveryDb);

            return deliveryDto;
        }

        public async Task UpdateDelivery(string deliveryId, DeliveryUpdateDto deliveryUpdateDto, bool trackChanges)
        {
            var deliveryDb = await CheckIfDeliveryExists(deliveryId, trackChanges);

            _mapper.Map(deliveryUpdateDto, deliveryDb);
            await _repository.SaveChangesAync();
        }


        private async Task<Delivery> CheckIfDeliveryExists(string deliveryId, bool trackChanges)
        {
            var deliveryDb = await _deliveryRepository.GetDeliveryByDeliveryIdAsync(deliveryId, trackChanges);
            if (deliveryDb != null)
            {
                throw new DeliveryNotFoundException(deliveryId);
            }

            return deliveryDb;
        }
    }
}

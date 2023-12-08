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

        public DeliveryService(IRepositoryBase<Delivery> repository, IMapper mapper, 
            IDeliveryRepository deliveryRepository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<StandardResponse<DeliveryDto>> CreateDelivery(DeliveryCreationDto deliveryCreationDto)
        {
            var deliveryToCreate = _mapper.Map<Delivery>(deliveryCreationDto);

            _deliveryRepository.CreateDelivery(deliveryToCreate);
           await _repository.SaveChangesAync();

            var deliveryToReturnDto = _mapper.Map<DeliveryDto>(deliveryToCreate);

            return StandardResponse<DeliveryDto>.Success("created", deliveryToReturnDto, 201);
        }

        public async Task<StandardResponse<string>> DeleteDelivery(string deliveryId, bool trackChanges)
        {
            var deliveryDb = await _deliveryRepository.GetDeliveryByDeliveryIdAsync(deliveryId, trackChanges);

            if (deliveryDb == null)
            {
                return StandardResponse<string>.Failed($"There is no delivery with id: {deliveryId}");
            }

             _deliveryRepository.DeleteDelivery(deliveryDb);
            await _repository.SaveChangesAync();

            return StandardResponse<string>.Success("Delivery has been deleted.", "deleted", 200);
        }

        public async Task<StandardResponse<IEnumerable<DeliveryDto>>> GetAllDeliveriesAsync(bool trackChanges)
        {
            var deliveriesDb = await _deliveryRepository.GetAllDeliveriesAsync(trackChanges);

            var deliveriesDto = _mapper.Map<IEnumerable<DeliveryDto>>(deliveriesDb);

            return StandardResponse<IEnumerable<DeliveryDto>>.Success("All deliveries", deliveriesDto, 200);
        }

        public async Task<StandardResponse<IEnumerable<DeliveryDto>>> GetAllDeliveriesByRequestId(string requestId, bool trackChanges)
        {
            var deliveriesDb = await _deliveryRepository.GetAllDeliveriesByRequestIdAsync(requestId, trackChanges);
            if (deliveriesDb == null)
            {
                //throw new DeliveryNotFoundException(requestId);
                return StandardResponse<IEnumerable<DeliveryDto>>.Failed($"Delivery with id: {requestId} does not exist.");

            }

            var deliveriesDto = _mapper.Map<IEnumerable<DeliveryDto>>(deliveriesDb);

            return StandardResponse<IEnumerable<DeliveryDto>>.Success($"All deliveries by request id: {requestId}", deliveriesDto, 200);
        }

        public async Task<StandardResponse<IEnumerable<DeliveryDto>>> GetAllDeliveriesByTransporterId(string transporterId, bool trackChanges)
        {
            var deliveriesDb =await _deliveryRepository.GetAllDeliveriesByTransporterId(transporterId, trackChanges);
            if (deliveriesDb == null)
            {
                //throw new DeliveryNotFoundException(transporterId);
                return StandardResponse<IEnumerable<DeliveryDto>>.Failed($"Delivery with id: {transporterId} does not exist.");
            }

            var deliveriesDto = _mapper.Map<IEnumerable<DeliveryDto>>(deliveriesDb);

            return StandardResponse<IEnumerable<DeliveryDto>>.Success($"All deliveries by transporter id: {transporterId}", deliveriesDto, 200);

        }

        public async Task<StandardResponse<IEnumerable<DeliveryDto>>> GetAllDeliveriesByUserId(string userId, bool trackChanges)
        {
            var deliveriesDb = await _deliveryRepository.GetAllDeliveriesByUserId(userId, trackChanges);

            if(deliveriesDb == null)
            {
                //throw new DeliveryNotFoundException(userId);
                return StandardResponse<IEnumerable<DeliveryDto>>.Failed($"Delivery with id: {userId} does not exist.");
            }

            var deliveriesDto = _mapper.Map<IEnumerable<DeliveryDto>>(deliveriesDb);

            return StandardResponse<IEnumerable<DeliveryDto>>.Success($"All deliveries with user id: {userId}", deliveriesDto, 200);
        }

        public async Task<StandardResponse<DeliveryDto>> GetDeliveryByDeliveryId(string deliveryId, bool trackChanges)
        {
            var deliveryDb = await _deliveryRepository.GetDeliveryByDeliveryIdAsync(deliveryId, trackChanges);
            if(deliveryDb == null)
            {
                return StandardResponse<DeliveryDto>.Failed($"There is no delivery with delivery id: {deliveryId}");
            }

            var deliveryDto = _mapper.Map<DeliveryDto>(deliveryDb);

            return StandardResponse<DeliveryDto>.Success($"Delivery by delivery id: {deliveryId} found.", deliveryDto, 200);
        }

        public async Task<StandardResponse<string>> UpdateDelivery(string deliveryId, DeliveryUpdateDto deliveryUpdateDto, bool trackChanges)
        {
            var deliveryDb = await _deliveryRepository.GetDeliveryByDeliveryIdAsync(deliveryId, trackChanges);

            if(deliveryDb == null)
            {
                return StandardResponse<string>.Failed($"There is no delivery with id: {deliveryId}.");
            }

            _mapper.Map(deliveryUpdateDto, deliveryDb);
            await _repository.SaveChangesAync();

            return StandardResponse<string>.Success("Delivery updated successfully", "deleted", 200);
        }


       /* private async Task<Delivery> CheckIfDeliveryExists(string deliveryId, bool trackChanges)
        {
            var deliveryDb = await _deliveryRepository.GetDeliveryByDeliveryIdAsync(deliveryId, trackChanges);
            if (deliveryDb != null)
            {
                throw new DeliveryNotFoundException(deliveryId);
            }

            return deliveryDb;
        }*/
    }
}

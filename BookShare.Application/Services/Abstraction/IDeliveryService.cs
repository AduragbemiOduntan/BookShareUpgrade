using BookShare.Common.Dto.Request;

namespace BookShare.Application.Services.Abstraction
{
    public interface IDeliveryService
    {
        Task<DeliveryDto> CreateDelivery(DeliveryCreationDto deliveryCreationDto);
        Task DeleteDelivery(string deliveryId);
        Task<IEnumerable<DeliveryDto>> GetAllDeliveriesAsync(bool trackChanges);
        Task<IEnumerable<DeliveryDto>> GetAllDeliveriesByRequestId(string requestId, bool trackChanges);
        Task<IEnumerable<DeliveryDto>> GetAllDeliveriesByTransporterId(string transporterId, bool trackChanges);
        Task<IEnumerable<DeliveryDto>> GetAllDeliveriesByUserId(string  userId, bool trackChanges);
        Task<DeliveryDto> GetDeliveryByDeliveryId(string deliveryId, bool trackChanges);
        Task UpdateDelivery(DeliveryUpdateDto deliveryUpdateDto);

    }
}

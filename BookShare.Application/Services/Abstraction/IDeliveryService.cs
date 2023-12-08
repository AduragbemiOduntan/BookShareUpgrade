namespace BookShare.Application.Services.Abstraction
{
    public interface IDeliveryService
    {
        Task<StandardResponse<DeliveryDto>> CreateDelivery(DeliveryCreationDto deliveryCreationDto);
        Task<StandardResponse<string>> DeleteDelivery(string deliveryId, bool trackChanges);
        Task<StandardResponse<IEnumerable<DeliveryDto>>> GetAllDeliveriesAsync(bool trackChanges);
        Task<StandardResponse<IEnumerable<DeliveryDto>>> GetAllDeliveriesByRequestId(string requestId, bool trackChanges);
        Task<StandardResponse<IEnumerable<DeliveryDto>>> GetAllDeliveriesByTransporterId(string transporterId, bool trackChanges);
        Task<StandardResponse<IEnumerable<DeliveryDto>>> GetAllDeliveriesByUserId(string  userId, bool trackChanges);
        Task<StandardResponse<DeliveryDto>> GetDeliveryByDeliveryId(string deliveryId, bool trackChanges);
        Task<StandardResponse<string>> UpdateDelivery(string deliveryId, DeliveryUpdateDto deliveryUpdateDto, bool trackChanges);

    }
}

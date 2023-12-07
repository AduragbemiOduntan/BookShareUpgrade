using BookShare.Common.Dto.Request;
using BookShare.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Infrastructure.Repository.Abstraction
{
    public interface IDeliveryRepository
    {
        Task<IEnumerable<Delivery>> GetAllDeliveriesAsync(bool trackChanges);
        Task<Delivery> GetDeliveryByDeliveryIdAsync(string  deliveryId, bool trackChanges);
        Task<IEnumerable<Delivery>> GetAllDeliveriesByRequestIdAsync(string requestId, bool trackChanges);
        Task<IEnumerable<Delivery>> GetAllDeliveriesByTransporterId(string transporterId, bool trackChanges);
        Task<IEnumerable<Delivery>> GetAllDeliveriesByUserId(string userId, bool trackChanges);

        void CreateDelivery( Delivery delivery);
        void UpdateDelivery(Delivery delivery);
        void DeleteDelivery(Delivery delivery);
    }
}

using BookShare.Common.Dto.Request;
using BookShare.Domain.Model;
using BookShare.Infrastructure.ApplicationContext;
using BookShare.Infrastructure.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Infrastructure.Repository.Implementation
{
    public class DeliveryRepository : RepositoryBase<Delivery>, IDeliveryRepository
    {
        public DeliveryRepository(BookShareContext bookshareContext) 
            : base(bookshareContext)
        {
            
        }

        public void CreateDelivery(Delivery delivery)
        {
            CreateAsync(delivery);
        }

        public void DeleteDelivery(Delivery delivery)
        {
            Delete(delivery);
        }

        public async Task<IEnumerable<Delivery>> GetAllDeliveriesAsync(bool trackChanges)
        {
             return await FindAll(trackChanges)
                .ToListAsync();

        }

        public async Task<IEnumerable<Delivery>> GetAllDeliveriesByRequestIdAsync(string requestId, bool trackChanges)
        {
            return await FindByCondition(d => d.RequestId.Equals(requestId), trackChanges)
                .ToListAsync();
        }

        public async Task<IEnumerable<Delivery>> GetAllDeliveriesByTransporterId(string transporterId, bool trackChanges)
        {
            return await FindByCondition(d => d.TransporterId.Equals(transporterId), trackChanges)
                .ToListAsync();
        }

        public async Task<IEnumerable<Delivery>> GetAllDeliveriesByUserId(string userId, bool trackChanges)
        {
            return await FindByCondition(d => d.UserId.Equals(userId), trackChanges)
                .ToListAsync();
        }

        public async Task<Delivery> GetDeliveryByDeliveryIdAsync(string deliveryId, bool trackChanges)
        {
            return await FindByCondition(d => d.DeliveryId.Equals(deliveryId), trackChanges)
                .SingleOrDefaultAsync();
        }

        public void UpdateDelivery(Delivery delivery)
        {
            Update(delivery);
        }

       
    }
}

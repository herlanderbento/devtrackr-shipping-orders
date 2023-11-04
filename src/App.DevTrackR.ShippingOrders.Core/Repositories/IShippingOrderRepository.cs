using App.DevTrackR.ShippingOrders.Core.Entities;

namespace App.DevTrackR.ShippingOrders.Core.Repositories
{
    public interface IShippingOrderRepository
    {
        Task<ShippingOrder> GetByCodeAsync(string code);
        Task AddAsync(ShippingOrder shippingOrder);
    }
}
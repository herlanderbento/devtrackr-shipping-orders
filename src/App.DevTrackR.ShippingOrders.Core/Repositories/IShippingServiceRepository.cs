using App.DevTrackR.ShippingOrders.Core.Entities;

namespace App.DevTrackR.ShippingOrders.Core.Repositories
{
    public interface IShippingServiceRepository
    {
        Task<List<ShippingService>> GetAllAsync();
    }
}
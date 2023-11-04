using App.DevTrackR.ShippingOrders.Application.ViewModels;

namespace App.DevTrackR.ShippingOrders.Application.Services
{
    public interface IShippingServiceService
    {
        Task<List<ShippingServiceViewModel>> GetAll();
    }
}
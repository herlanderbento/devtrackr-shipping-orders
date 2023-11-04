using App.DevTrackR.ShippingOrders.Application.InputModels;
using App.DevTrackR.ShippingOrders.Application.ViewModels;

namespace App.DevTrackR.ShippingOrders.Application.Services
{
    public interface IShippingOrderService
    {
        Task<string> Add(AddShippingOrderInputModel model);
        Task<ShippingOrderViewModel> GetByCode(string trackingCode);
    }
}
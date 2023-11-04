namespace App.DevTrackR.ShippingOrders.Application.Services
{
    public class ShippingOrderService : IShippingOrderService
    {
        public Task<string> Add(AddShippingOrderInput model)
        {
            var shippingOrder = model.ToEntity();
            var shippingServices = model
            .Services
            .Select(s => s.ToEntity())
            .ToList();

            shippingOrder.SetupServices(shippingServices);

            Console.WriteLine(JsonSerializer.Serialize(shippingOrder));

            return Task.FromResult(shippingOrder.TrackingCode);
        }
    }
}
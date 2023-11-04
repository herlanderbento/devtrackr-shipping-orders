namespace App.DevTrackR.ShippingOrders.Application.ViewModels
{
    public class ShippingOrderViewModel
    {
        public ShippingOrderViewModel(string trackingCode, string description, )
        {
            TrackingCode = GenerateTrackingCode();
            Description = description;
            PostedAt = DateTime.Now;
            WeightInKg = weightInKg;
            DeliveryAddress = deliveryAddress;
        }

        public string TrackingCode { get; private set; }

        public string Description { get; private set; }

        public DateTime PostedAt { get; private set; }

        public decimal WeightInKg { get; private set; }

        public string FullAddress { get; private set; }

        public static ShippingOrderViewModel FromEntity(ShippingOrders shippingOrders)
        {
            var address = shippingOrders.DeliveryAddress;

            return new ShippingOrderViewModel(
                shippingOrders.TrackingCode,
                shippingOrders.Description,
                shippingOrders.PostedAt,
                shippingOrders.WeightInKg,
                $"{address.Street}, {address.Number}, {address.ZipCode}, {address.City}, {address.State}, {address.Country}"
            );
        }
    }
}
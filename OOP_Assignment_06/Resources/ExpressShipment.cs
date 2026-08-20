namespace OOP_Assignment_06.Resources
{
    public class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        decimal extraFee;
        decimal estimatedCost;
        public decimal ExtraFee
        {
            get => extraFee;
            set => extraFee = value >= 0 ? value : 0;
        }
        public ExpressShipment(string trackingCode, string description, double weight, decimal deliveryFee, decimal extrafee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extrafee;
        }
        public override decimal EstimatedCost { get => DeliveryFee + (decimal)(Weight * 5) + ExtraFee; set => estimatedCost = estimatedCost >= 0 ? value : 0; }

        public decimal CalculateInsurance()
        {
            return 0.08m * EstimatedCost;
        }

        public new string GetTrackingStatus()
        {
            return ($"Shipment {TrackingCode} is Out for Delivery.\n");

        }

        public override void PrintShipment()
        {
            Console.WriteLine("\nExpress Shipment\n");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine("---------------------------------------------");
        }
    }
}

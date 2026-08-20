namespace OOP_Assignment_06.Resources
{
    public class StandardShipment : Shipment, ITrackable, IInsurable
    {
        decimal estimatedCost;
        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
        public override decimal EstimatedCost { get => DeliveryFee + (decimal)(Weight * 5); set => estimatedCost = estimatedCost >= 0 ? value : 0; }

        public decimal CalculateInsurance()
        {
            return 0.05m * EstimatedCost;
        }

        public new string GetTrackingStatus()
        {
            return ($"Shipment {TrackingCode} is Ready.\n");

        }
        public override void PrintShipment()
        {
            //Console.WriteLine("=======================================");
            Console.WriteLine("\nStandard Shipment\n");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Destination: {Destination}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
            Console.WriteLine("---------------------------------------------");
        }

    }
}

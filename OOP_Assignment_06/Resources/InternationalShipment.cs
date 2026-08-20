namespace OOP_Assignment_06.Resources
{
    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        string destinationCountry = default!;
        decimal customsFee;
        decimal estimatedCost;

        public InternationalShipment(string destinationcountry, string trackingCode, string description, double weight, decimal deliveryFee, decimal customsfee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationcountry;
            CustomsFee = customsfee;
        }
        public string DestinationCountry
        {
            get => destinationCountry;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
                else
                {
                    destinationCountry = "Unknown";
                }
            }
        }

        public decimal CustomsFee
        {
            get => customsFee;
            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
                else
                {
                    customsFee = 0;
                }
            }
        }

        public override decimal EstimatedCost { get => DeliveryFee + (decimal)(Weight * 5) + customsFee; set => estimatedCost = estimatedCost >= 0 ? value : 0; }

        virtual public void GenerateCustomsReport()
        {
            Console.WriteLine("Generating standard customs report...");
        }

        public decimal CalculateInsurance()
        {
            return 0.12m * EstimatedCost;
        }

        public new string GetTrackingStatus()
        {
            return ($"Shipment {TrackingCode}  has been Delivered.\n");

        }

        public override void PrintShipment()
        {
            Console.WriteLine("\nInternational Shipment\n");
            Console.WriteLine($"Tracking Code        : {TrackingCode}");
            Console.WriteLine($"Description           : {Description}");
            Console.WriteLine($"Weight                : {Weight} KG");
            Console.WriteLine($"Delivery Fee          : {DeliveryFee} EGP");
            Console.WriteLine($"Destination Country   : {DestinationCountry}");
            Console.WriteLine($"Customs Fee           : {CustomsFee} EGP");
            Console.WriteLine($"Estimated Cost        : {EstimatedCost} EGP");
            Console.WriteLine("---------------------------------------------");
        }
    }
}

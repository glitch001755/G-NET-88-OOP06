namespace OOP_Assignment_06.Resources
{
    public abstract partial class Shipment
    {
        string trackingCode = default!;
        string description = default!;
        double weight;
        decimal deliveryFee;
        public static int TotalShipmentsCreated;

        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
            TotalShipmentsCreated++;
        }
        public Shipment(string trackingCode) : this(trackingCode, "Unknown", 1, 50, new DeliveryAddress("Unknown", "Unknown", 0))
        {

        }

        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("\nShipment System Initialized\n");
        }

        public override string ToString()
        {
            return $"Tracking Code : {TrackingCode}\nDescription   : {Description}\nWeight        : {Weight} KG\nDelivery Fee  : {DeliveryFee} EGP\nEstimated Cost: {EstimatedCost} EGP";
        }
        public DeliveryAddress Destination { get; set; }
        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }
                else
                {
                    trackingCode = "Unknown";
                }

            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
                else
                {
                    description = "Unknown";
                }
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    weight = 1;
                }
            }
        }
        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }
            set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
                else
                {
                    deliveryFee = 50;
                }
            }
        }
        public abstract decimal EstimatedCost { get; set; }


        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }

        }
        public abstract void PrintShipment();

        public void UpdateWeight(double newWeight)
        {
            weight = newWeight;
        }
        public void UpdateWeight(double newWeight, double packingWeight)
        {
            weight = newWeight + packingWeight;
        }

        public Shipment CopyShipment()
        {
            return (Shipment)MemberwiseClone();
        }
        public Shipment ShallowCopy()
        {
            return (Shipment)MemberwiseClone();
        }
        public Shipment DeepCopy()
        {
            Shipment Result = (Shipment)MemberwiseClone();
            Result.Destination = new DeliveryAddress(Destination.city, Destination.street, Destination.buildingNumber);
            return Result;
        }

        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }

    }
}

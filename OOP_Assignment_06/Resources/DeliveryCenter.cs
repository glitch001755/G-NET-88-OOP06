namespace OOP_Assignment_06.Resources
{
    public class DeliveryCenter
    {
        string centerName = default!;
        public string Driver { get; set; } = default!;
        Shipment[] shipments;
        int count = -1;

        public string CenterName
        {
            get { return centerName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    centerName = value;
                }
                else
                {
                    centerName = "Unknown";
                }
            }
        }
        public DeliveryCenter(string centername)
        {
            shipments = new Shipment[20];
            count = 0;
            CenterName = centername;
        }

        public Shipment this[int position]
        {
            get
            {
                if (shipments != null && position < count && position >= 0)
                {
                    return shipments[position];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (position < 0 || position >= shipments.Length)
                    throw new ArgumentOutOfRangeException(nameof(position), "Index is out of range.");


                if (position < count)
                {
                    shipments[position] = value;
                }

                else if (position == count)
                {
                    shipments[position] = value;
                    count++;
                }
                else
                {

                    throw new InvalidOperationException("Cannot insert at this index because previous indices are empty.");
                }

            }
        }

        public Shipment this[string name]
        {
            get
            {
                if (shipments != null)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (shipments[i].TrackingCode != null && shipments[i].TrackingCode.Equals(name, StringComparison.OrdinalIgnoreCase))
                        {
                            return shipments[i];
                        }
                    }
                }
                throw new InvalidOperationException();
            }

        }

        public bool AddShipment(Shipment shipment)
        {
            if (shipments == null || count == -1)
            {
                shipments = new Shipment[20];
                count = 0;
            }
            if (count < shipments.Length)
            {
                shipments[count] = shipment;
                count++;
                Console.WriteLine("Shipment Added Successfully.");
                return true;
            }
            Console.WriteLine("Failed to Add Shipment.");
            return false;


        }
        public bool RemoveShipment(string trackingcodeship)
        {
            if (shipments == null || count == 0)
            {
                Console.WriteLine("Shipment Already Empty !!!!! ");
                return false;
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    if (shipments[i].TrackingCode != null && shipments[i].TrackingCode.Equals(trackingcodeship, StringComparison.OrdinalIgnoreCase))
                    {
                        shipments[i] = shipments[count - 1];
                        shipments[count - 1] = default!;
                        count--;
                        return true;
                    }
                }
            }
            return false;
        }
        public void PrintAllShipments()
        {
            Console.WriteLine($"DeliveryCenter : {centerName}");
            Console.WriteLine("=============================================");
            if (!string.IsNullOrEmpty(Driver))
            {
                Console.WriteLine($"\nDriver : {Driver}\n");
                Console.WriteLine("------------------------------------------");
            }
            foreach (Shipment s in shipments)
            {
                if (s != null)
                {
                    s.PrintShipment();
                    Console.WriteLine("---------------------------------------------");
                }
            }
        }

        public void PrintTrackingStatuses()
        {
            foreach (ITrackable t in shipments)
            {
                Console.WriteLine(t.GetTrackingStatus());
            }
        }
        public void PrintInsurance()
        {
            foreach (IInsurable i in shipments)
            {
                Console.WriteLine($"insurance = {i.CalculateInsurance()}");
            }
        }

    }
}

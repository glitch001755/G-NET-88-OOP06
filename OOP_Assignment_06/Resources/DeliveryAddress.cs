namespace OOP_Assignment_06.Resources
{
    public class DeliveryAddress
    {
        public string city;
        public string street;
        public int buildingNumber;

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            this.city = city;
            this.street = street;
            this.buildingNumber = buildingNumber;
        }
        public override string ToString() => $"{buildingNumber} {street} , {city}";
        public string GetFullAddress()
        {
            return ($"{buildingNumber} {street} , {city}");
        }
    }
}

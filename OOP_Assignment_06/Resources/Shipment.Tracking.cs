namespace OOP_Assignment_06.Resources
{
    public partial class Shipment : ITrackable
    {
        protected string trackingStatus = "In Transit";
        public string GetTrackingStatus() => trackingStatus;
        partial void OnTrackingStatusChanged(string newStatus);
        public void UpdateTrackingStatus(string newStatus)
        {
            trackingStatus = newStatus;
            OnTrackingStatusChanged(newStatus);
        }

        partial void OnTrackingStatusChanged(string newStatus)
        {
            System.Console.WriteLine($"Tracking status changed to: {newStatus}");
        }
    }
}

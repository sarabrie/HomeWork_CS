public class DeviceIdentity
{
    public string SerialNumber { get; }
    public int ProductionYear { get; }
    public string PurchaseDate { get; }
    public string StoreName { get; }
    public DeviceIdentity(string serialNumber, int productionYear, string purchaseDate, string storeName)
    {
        SerialNumber = serialNumber;
        ProductionYear = productionYear;
        PurchaseDate = purchaseDate;
        StoreName = storeName;
    }
}
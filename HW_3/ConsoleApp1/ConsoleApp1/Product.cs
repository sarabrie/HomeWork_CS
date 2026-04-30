public abstract class product:IControllable
{
    public string Name { get; }
    public DeviceIdentity deviceIdentity { get; }
    public bool IsOn { get; protected set; }
    public void TurnOn()
    {
    }
    public void TurnOff()
    {
    }
    public string ToString()
    {
        return $"Product Name: {Name}, Serial Number: {deviceIdentity.SerialNumber}, Production Year: {deviceIdentity.ProductionYear}, Purchase Date: {deviceIdentity.PurchaseDate}, Store Name: {deviceIdentity.StoreName}, Is On: {IsOn}";
    }
    public void ToPrint()
    {
        Console.WriteLine(ToString());
    }

}
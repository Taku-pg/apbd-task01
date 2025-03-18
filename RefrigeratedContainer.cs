namespace apbd_tut3;

public class RefrigeratedContainer : Container
{
    public String ProductType { get; set; }
    public double Temperature { get; set; }

    public RefrigeratedContainer(String productType, double temperature)
    {
        Temperature = temperature;
        Type = 'C';
    }

    public void Load(double massOfProduct, double temperatureOfProduct, string productType)
    {
        if (AvailablePayload == MaxPayload)
        {
            productType = ProductType;
        }
        
        if (massOfProduct > AvailablePayload || Temperature < temperatureOfProduct || !ProductType.Equals(productType))
        {
            Console.WriteLine("You cannot load this cargo to this container.");
        }
        else
        {
            AvailablePayload -= massOfProduct;
        }
    }
}
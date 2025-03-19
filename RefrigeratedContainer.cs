namespace apbd_tut3;

public class RefrigeratedContainer : Container
{
    public String ProductType { get; set; }
    public double Temperature { get; set; }
    private static int _number;

    public RefrigeratedContainer(int height,int tareWeight,int depth,
        double maxPayload,string productType,double temperature)
        :base(height,tareWeight,depth,maxPayload)
    {
        ProductType = productType;
        Temperature = temperature;
        _number++;
        Type = 'C';
        SerialNumber = "KON"+"-"+Type+"-"+_number;
    }

    public void Load(double massOfProduct, double temperatureOfProduct, string productType)
    {
        if (massOfProduct > MaxPayload || Temperature < temperatureOfProduct || !ProductType.Equals(productType))
        {
            Console.WriteLine("You cannot load this cargo to container "+SerialNumber);
        }
        else
        {
            Mass= massOfProduct;
            Console.WriteLine("success to load");
        }
    }

    public override string ToString()
    {
        return base.ToString()+" Product type :"+ProductType+" Temperature :"+Temperature;
    }
}
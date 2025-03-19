namespace apbd_tut3;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; set; }
    private static int _number;

    public GasContainer(int height,int tareWeight,int depth,double maxPayload,double pressure) 
        : base(height,tareWeight,depth,maxPayload)
    {
        Pressure = pressure;
        _number++;
        Type = 'G';
        SerialNumber = "KON"+"-"+Type+"-"+_number;
    }

    public void Notify()
    {
        Console.WriteLine("Hazard with "+SerialNumber);
    }

    public override void Empty()
    {
        Mass *= 0.05;
    }

    public void Load(double massOfProduct)
    {
        if(massOfProduct > MaxPayload)
            Notify();
        else
        {
            Mass = massOfProduct;
            Console.WriteLine("success to load");
        }
    }

    public override string ToString()
    {
        return base.ToString()+" Pressure :"+Pressure;
    }
}
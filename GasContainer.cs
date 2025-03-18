namespace apbd_tut3;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; set; }
    private static int _number;

    public GasContainer(int height,int tareWeight,int depth,double maxPayload) : base(height,tareWeight,depth,maxPayload)
    {
        _number++;
        Type = 'G';
        SerialNumber = "KON"+"-"+Type+"-"+_number;
    }

    public void Notify()
    {
        Console.WriteLine("Hazard with"+SerialNumber);
    }

    public override void Empty()
    {
        MaxPayload *= 0.95;
        AvailablePayload = MaxPayload;
        Mass *= 0.05;
    }

    public void Load(double massOfProduct)
    {
        if(massOfProduct > AvailablePayload)
            Notify();
        else
        {
            AvailablePayload -= massOfProduct;
        }
    }
    
}
namespace apbd_tut3;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; set; }

    public GasContainer()
    {
        Type = 'G';
    }

    public void Notify()
    {
        Console.WriteLine("Hazard with"+SerialNumber);
    }

    public void Empty()
    {
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
namespace apbd_tut3;

public class Container
{
    //total mass of all cargo
    public double Mass { get; set; }
    public int Height { get; set; }
    public int TareWeight { get; set; }
    public int Depth { get; set; }
    public char Type { get; set; }
    public String SerialNumber { get; set; }
    public double MaxPayload { get; set; }
    public double AvailablePayload { get; set; }

    public Container(int height, int tareWeight, int depth,double maxPayload)
    {
        MaxPayload = maxPayload;
        AvailablePayload = maxPayload;
        Height = height;
        TareWeight = tareWeight;
        Depth = depth;
    }

    public virtual void Empty()
    {
        Mass = 0;
        AvailablePayload = MaxPayload;
    }
    
}
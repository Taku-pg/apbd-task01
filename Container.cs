namespace apbd_tut3;

public class Container
{
    public double Mass { get; set; }
    public int Height { get; set; }
    public int TareWeight { get; set; }
    public int Depth { get; set; }
    public char Type { get; set; }
    public String SerialNumber { get; set; }
    public double MaxPayload { get; set; }

    public Container(int height, int tareWeight, int depth,double maxPayload)
    {
        MaxPayload = maxPayload;
        Height = height;
        TareWeight = tareWeight;
        Depth = depth;
    }

    public virtual void Empty()
    {
        Mass = 0;
    }

    public override string ToString()
    {
        return "Mass :"+Mass+"kg Height :"+Height+"cm Tare weight :"+TareWeight+
               "kg Depth :"+Depth+"cm Serial number :"+SerialNumber+" Max payload: "+MaxPayload+"kg";
    }
}
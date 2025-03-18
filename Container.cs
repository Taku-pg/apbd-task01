namespace apbd_tut3;

public class Container
{
    //total mass of all cargo
    public double Mass { get; set; }
    public int Height { get; set; }
    public int TareWeight { get; set; }
    public int Depth { get; set; }
    public char Type { get; set; }
    public int Number { get; set; }
    private int _number=0;
    public String SerialNumber { get; set; }
    public double MaxPayload { get; set; }
    public double AvailablePayload { get; set; }

    public Container(int height, int tareWeight, int depth,double maxPayload)
    {
        _number++;
        Number++;
        MaxPayload = maxPayload;
        Height = height;
        TareWeight = tareWeight;
        Depth = depth;
        SerialNumber = "KON"+"-"+Type+"-"+_number;
    }

    public void Empty()
    {
        Mass = 0;
        AvailablePayload = MaxPayload;
    }
    public void Load(){}
    
}
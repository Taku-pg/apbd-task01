using System.Transactions;

namespace apbd_tut3;

public class LiquidContainer: Container, IHazardNotifier
{

    private int _number = 0;
    public double AvailablePayload{ get; set; }
    public LiquidContainer(int height,int tareWeight,int depth,double maxPayload) 
        : base(height,tareWeight,depth,maxPayload)
    {
        AvailablePayload = maxPayload;
        _number++;
        Type = 'L';
        SerialNumber = "KON"+"-"+Type+"-"+_number;
    }
    
    public void Notify()
    {
        Console.WriteLine("Hazard with "+SerialNumber);
    }

    public override void Empty()
    {
        Mass = 0;
        AvailablePayload=MaxPayload;
    }

    public void Load(int dangerFlag,int massOfProducts)
    {
        if (AvailablePayload == MaxPayload)
        {
             if (dangerFlag == 0) 
             { 
                 AvailablePayload *= 0.9;
             }else if (dangerFlag == 1) 
             { 
                 AvailablePayload *= 0.5;
             }
        }
       

        if (massOfProducts > AvailablePayload)
        {
            Notify();
        }
        else
        {
            Mass = massOfProducts;
            Console.WriteLine("success to load");
        }
    }
}
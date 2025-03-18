using System.Transactions;

namespace apbd_tut3;

public class LiquidContainer: Container, IHazardNotifier
{

    private int _number = 0;
    public LiquidContainer(int height,int tareWeight,int depth,double maxPayload) : base(height,tareWeight,depth,maxPayload)
    {
        _number++;
        Type = 'L';
        SerialNumber = "KON"+"-"+Type+"-"+_number;
    }
    
    public void Notify()
    {
        Console.WriteLine("Hazard with "+SerialNumber);
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
            AvailablePayload -= massOfProducts;
        }
    }
}
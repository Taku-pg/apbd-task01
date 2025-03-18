using System.Transactions;

namespace apbd_tut3;

public class LiquidContainer: Container, IHazardNotifier
{
    public LiquidContainer(int height,int tareWeight,int depth,double maxPayload)
    {
        this.Type = 'L';
        
    }
    
    public void Notify()
    {
        Console.WriteLine("Hazard with"+this.SerialNumber);
    }

    public void Load(int dangerFlag,int massOfProducts)
    {
        if (dangerFlag == 0)
        {
            this.MaxPayload *= 0.9;
        }else if (dangerFlag == 1)
        {
            this.MaxPayload *= 0.5;
        }

        if (massOfProducts > MaxPayload)
        {
            Notify();
        }
        else
        {
            AvailablePayload -= massOfProducts;
        }
    }
}
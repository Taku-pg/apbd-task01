﻿namespace apbd_tut3;

public class RefrigeratedContainer : Container
{
    public String ProductType { get; set; } = "";
    public double Temperature { get; set; }
    private static int _number;

    public RefrigeratedContainer(int height,int tareWeight,int depth,double maxPayload):base(height,tareWeight,depth,maxPayload)
    {
        _number++;
        Type = 'C';
        SerialNumber = "KON"+"-"+Type+"-"+_number;
    }

    public void Load(double massOfProduct, double temperatureOfProduct, string productType)
    {
        if (AvailablePayload == MaxPayload)
        {
            Temperature = temperatureOfProduct;
            productType = ProductType;
        }
        
        if (massOfProduct > AvailablePayload || Temperature < temperatureOfProduct || !ProductType.Equals(productType))
        {
            Console.WriteLine("You cannot load this cargo to container "+SerialNumber);
        }
        else
        {
            AvailablePayload -= massOfProduct;
        }
    }
}
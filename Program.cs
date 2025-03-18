// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using apbd_tut3;

Console.WriteLine("Hello, World!");

var lContainer = new LiquidContainer(1000,1000,1000,10000);
var gContainer = new GasContainer(1000,1000,1000,10000);
var rContainer = new RefrigeratedContainer(1000,1000,1000,10000);

lContainer.Load(1,1000);
lContainer.Load(1,4000);
Console.WriteLine("Emptying");
lContainer.Empty();
lContainer.Load(0,9000);

gContainer.Load(10000);
gContainer.Empty();
gContainer.Load(10000);

rContainer.Load(5000,5,"Cold");
rContainer.Load(400,4, "Cold");

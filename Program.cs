// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using apbd_tut3;

Console.WriteLine("Hello, World!");

var lContainer = new LiquidContainer(1000,1000,1000,10000);
var gContainer = new GasContainer(1000,1000,1000,10000);
var rContainer = new RefrigeratedContainer(1000,1000,1000,10000);

lContainer.Load(1,1000);
lContainer.Load(1,3000);

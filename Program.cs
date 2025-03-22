// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using apbd_tut3;

//create container given type
var lContainer = new LiquidContainer(2000,3000,1500,10000);
var gContainer = new GasContainer(2000,3000,1500,10000,400);
var rContainer = new RefrigeratedContainer(1500,2500,800,6000,"cold",5d);
var gContainer2 = new GasContainer(500,500,500,1000,200);

//load cargo into a given container
lContainer.Load(1,1000);
gContainer.Load(10000);
gContainer2.Load(10000);
rContainer.Load(5000,5,"cold");
Console.WriteLine();

//load container onto a ship
var ship1 = new Ship(10,100,400);
var ship2 = new Ship(5,200,400);
ship1.AddContainer(lContainer);
Console.WriteLine();

//load list of containers
var containers = new List<apbd_tut3.Container>();
containers.Add(lContainer);
containers.Add(gContainer);
containers.Add(rContainer);
ship2.AddContainers(containers);
Console.WriteLine();

//remove container from ship
Console.WriteLine("Before remove : "+ship1.Containers.Count());
ship1.RemoveContainer(lContainer);
Console.WriteLine("After remove : "+ship1.Containers.Count());
Console.WriteLine();

//unload container
Console.WriteLine("Before empty : "+lContainer.Mass);
lContainer.Empty();
Console.WriteLine("After empty : "+lContainer.Mass);
Console.WriteLine();

//replace container
Console.WriteLine("Before replace : "+ship2.Containers.IndexOf(lContainer));
ship2.Replace(lContainer,gContainer);
Console.WriteLine("After replace : "+ship2.Containers.IndexOf(lContainer));
Console.WriteLine();

//transfer container
Console.WriteLine("Before transfer ship1 : "+ship1.Containers.Count());
Console.WriteLine("Before transfer ship2 : "+ship2.Containers.Count());
ship2.Transfer(ship1);
Console.WriteLine("After transfer ship1 : "+ship1.Containers.Count);
Console.WriteLine("After transfer ship2 : "+ship2.Containers.Count);
Console.WriteLine();

//print container info
Console.WriteLine(lContainer);
Console.WriteLine(gContainer);
Console.WriteLine(gContainer2);
Console.WriteLine(rContainer);
Console.WriteLine();

//print ship info
Console.WriteLine(ship1);
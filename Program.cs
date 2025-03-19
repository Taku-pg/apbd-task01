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

//load container onto a ship
var ship1 = new Ship(10,100,400);
var ship2 = new Ship(5,200,400);
ship1.AddContainer(lContainer);
//load list of containers
var containers = new List<apbd_tut3.Container>();
containers.Add(lContainer);
containers.Add(gContainer);
containers.Add(rContainer);
ship2.AddContainers(containers);
//remove container from ship
ship1.RemoveContainer(lContainer);
//unload container
lContainer.Empty();
//replace container
ship2.Replace(lContainer,gContainer);
//transfer container
ship1.Transfer(ship2);
//print container info
Console.WriteLine(lContainer);
Console.WriteLine(gContainer);
Console.WriteLine(gContainer2);
Console.WriteLine(rContainer);
//print ship info
Console.WriteLine(ship1);
namespace apbd_tut3;

public class Ship
{
    public List<Container> Containers { get; set; }
    public double Speed { get; set; }
    public int MaxNumberOfContainers { get; set; }
    //in tons
    public double CurrentWeight { get; set; }
    public double MaxWeightOfContainers { get; set; }

    public void AddContainer(Container container)
    {
        if (Containers.Count <= MaxNumberOfContainers && MaxWeightOfContainers >= CurrentWeight + container.Mass)
        {
            Containers.Add(container);
            CurrentWeight += container.Mass;
        }
        else
        {
            Console.WriteLine("You cannot load this container!");
        }
    }

    public void Transfer(Ship ship)
    {
        for (var i = 0; i < Containers.Count; i++)
        {
            ship.AddContainer(Containers[i]);
            Containers.Remove(Containers[i]);
        }
    }
    
}
namespace apbd_tut3;

public class Ship
{
    public List<Container> Containers { get; set; }=new List<Container>();
    public double Speed { get; set; }
    public int MaxNumberOfContainers { get; set; }
    //in tons
    public double CurrentWeight { get; set; }
    public double MaxWeightOfContainers { get; set; }

    public Ship(double speed, int maxNumberOfContainers, double maxWeightOfContainers)
    {
        Speed = speed;
        MaxNumberOfContainers = maxNumberOfContainers;
        MaxWeightOfContainers = maxWeightOfContainers;
    }

    public void AddContainer(Container container)
    {
        var weight = (container.Mass + container.TareWeight) / 1000;
        if (Containers.Count+1 <= MaxNumberOfContainers && MaxWeightOfContainers >= CurrentWeight + weight)
        {
            Containers.Add(container);
            CurrentWeight += weight;
            Console.WriteLine("success to load container");
        }
        else
        {
            Console.WriteLine("You cannot load this container!");
        }
    }

    public void AddContainers(List<Container> containers)
    {
        var totalWeight=0d;
        foreach (var container in containers)
        {
            totalWeight += (container.Mass + container.TareWeight) / 1000;
        }
        if (Containers.Count+containers.Count <= MaxNumberOfContainers 
            && MaxWeightOfContainers >= CurrentWeight + totalWeight)
        {
            foreach (var container in containers)
            {
                Containers.Add(container);
            }
            CurrentWeight += totalWeight;
            Console.WriteLine("success to load containers");
        }
        else
        {
            Console.WriteLine("You cannot load this container!");
        }
    }

    public void RemoveContainer(Container container)
    {
        Containers.Remove(container);
        Console.WriteLine("remove container");
    }

    public void Replace(Container container1, Container container2)
    {
        var first=Containers.IndexOf(container1);
        var second=Containers.IndexOf(container2);
        (Containers[first], Containers[second]) = (container2, container1);
        Console.WriteLine("replace container");
    }

    public void Transfer(Ship ship)
    {
        int count=Containers.Count;
        for (var i = 0; i < count; i++)
        {
            ship.AddContainer(Containers[0]);
            Containers.Remove(Containers[0]);
            Console.WriteLine("transfer containers");
        }
    }

    public override string ToString()
    {
        return "Speed :"+Speed+" Max number of container :"
               +MaxNumberOfContainers+" Max available weight :"+MaxWeightOfContainers
               +" Current number of containers :"+Containers.Count;
    }
}
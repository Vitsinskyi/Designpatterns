namespace Prototype;

class Program
{
    static void Main(string[] args)
    {
        Virus parent = new Virus("Parent", "Type1", 1.0, 10);
        Virus child1 = new Virus("Child1", "Type2", 0.5, 5);
        Virus child2 = new Virus("Child2", "Type3", 0.3, 3);

        parent.AddChild(child1);
        parent.AddChild(child2);

        Virus clone = (Virus)parent.Clone();

        Console.WriteLine($"Parent: {parent.Name}, Children number: {parent.Children.Count}, Children name: {child1.Name}, {child2.Name}");
        Console.WriteLine($"Clone: {clone.Name}, Children number: {clone.Children.Count}, Children name: {child1.Name}, {child2.Name}");
    }
}
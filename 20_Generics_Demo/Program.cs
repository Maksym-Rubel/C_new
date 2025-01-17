
class Person:IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public int CompateTo(Person? other)
    {
        return this.Age.CompareTo(other.Age);
    }
    virtual public void Busy()
    {
        Console.WriteLine($"Person {Name} is busy .......");

    }
    public override string ToString()
    {
        return $"Name :: {Name,-10} Age :: {Age}";
    }
class Employye:Person
    {
        public override void Busy()
        {
            Console.WriteLine($"Person {Name} is working");
        }
    }
}
internal class Program
{
    static T Max <T>(T one, T two) where T : IComparable<T>
    {
        return one.CompareTo(two) > 0 ? one : two;
    }
    static void CheckBusy<T>(T person) where T : Person
    {
        person.Busy();
    }
    private static void Main(string[] args)
    {
        int a = 10, b = 15;
        Console.WriteLine($"Max {a}, {b} = {Max(a,b)}");
    }
   
}

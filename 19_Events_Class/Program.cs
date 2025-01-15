using _19_Events_Class;

internal class Program
{
    private static void Main(string[] args)
    {
       Person person = new Person();

        
       person.PropertyChanged += person.Subsribe;
       person.Name = "John";
       person.LastName = "Doe";
       person.Born = "Rivne";

     



    }
}
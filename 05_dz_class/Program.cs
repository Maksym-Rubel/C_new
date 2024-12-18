using _05_dz_class;

internal class Program
{
    private static void Main(string[] args)
    {
        Wed_Site google = new Wed_Site("Google","www.google.com","for search",192168110);
        google.Print();
        google.Entersite();
        google.Print();
        Console.WriteLine();
        Zhurnal news = new Zhurnal("News",2024,"news",0977982404,"rubelmaksum2404@gmail.com");
        news.Print();
        news.Enterg();
        news.Print();
    }
}
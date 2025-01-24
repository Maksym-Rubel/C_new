using _34_SerClass;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Song> songs = new List<Song>
            {
                new Song("Song1", "03:45", "Pop"),
                new Song("Song2", "04:20", "Rock"),
                new Song("Song3", "02:50", "Jazz")
            };
        Album myAlbum = new Album("Greatest Hits", "John Doe", 2023, "45:00", "Dream Studio", songs);

        myAlbum.Print();
        string fname = "../../../Album.json";
        //myAlbum.SerializeAlbum(fname, myAlbum);

        Console.WriteLine();
        Album al = myAlbum.DeSerializeAlbum(fname);
        al.Print();


        Album myAl = new Album();

        myAl = myAl.EnterAll();

        myAl.Print();

        AlbumMas mas = new AlbumMas();

        mas.AddnewAlb(mas, myAlbum);
        mas.AddnewAlb(mas, al);
        mas.AddnewAlb(mas, myAl);


        mas.Print();


        string fname_1 = "../../../MasAlbum.json";

        mas.SerializeAlbum1(fname_1, mas);



    }
}
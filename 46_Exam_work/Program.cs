using _46_Exam_work;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        Hero hero = new Hero("Мандрівник");
        string[] pole = new string[]
        {
            "####################              #######",
            "#.....W..........W.#              #..T..#",
            "#.............G....#              #.....#",
            "#.G................################.....#########################",
            "#...............................................................#",
            "#...............................................................#",
            "#..............A.........M.................................B....#",
            "#...............................................................#",
            "#.D.............................................................#",
            "#..................##############################################",
            "#...G..........W...#",
            "####################"
        };
        bool running = false;
        Console.WriteLine("Використовуйте стрілки для переміщення героя. Натисніть 'Esc' для виходу з гри.");
        Console.WriteLine("Ти хочеш почати гру? (Y/N)");

        string ch = Console.ReadLine()!;
        if (ch[0] == 'Y')
        {
            
            running = true;
        }
      
   
        int heroX = 1;
        int heroY = 5;
        while (running)
        {
            

            DrawMap(pole, heroX, heroY);
            hero.Print();
            Game(hero,pole, heroX, heroY);
            ChechWIn(pole);
            ConsoleKey key = Console.ReadKey(true).Key; 

            if (key == ConsoleKey.Escape) 
            {
                running = false;
                Console.WriteLine("Гра завершена.");
                break;
            }
            int prevX = heroX;
            int prevY = heroY;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    heroY--;
                    break;
                case ConsoleKey.DownArrow:
                    heroY++;
                    break;
                case ConsoleKey.LeftArrow:
                    heroX--;
                    break;
                case ConsoleKey.RightArrow:
                    heroX++;
                    break;
                case ConsoleKey.D1:
                    ResWG(hero);
                    break;
                case ConsoleKey.D2:
                    ResD(hero);
                    break;
                
            }
            if (pole[heroY][heroX] == '#')
            {
               
                heroX = prevX;
                heroY = prevY;
            }
            
        }
    }
    static void DrawMap(string[] map, int heroX, int heroY)
    {
        Console.Clear();
        Console.WriteLine("1 - heal 20(1 wood,1 gold) 2 - heal 50(1 diamond)");
        for (int y = 0; y < map.Length; y++)
        {
            for (int x = 0; x < map[y].Length; x++)
            {
                if (x == heroX && y == heroY)
                {
                    Console.Write('H');
                }
                else
                {
                    Console.Write(map[y][x]);
                }
            }
            Console.WriteLine();
        }
        
    }
    static public void ResWG(Hero hero)
    {
        if (hero.Iventory["wood"] >= 1 && hero.Iventory["gold"] >= 1)
        {
            hero.Health += 20;
            hero.Iventory["wood"] -= 1;
            hero.Iventory["gold"] -= 1;

        }
    }
    static public void ResD(Hero hero)
    {
        if (hero.Iventory["diamonds"] >= 1)
        {
            hero.Health += 50;
            hero.Iventory["diamonds"] -= 1;
          

        }
    }
    static void ChechWIn(string[] map)
    {
       
    }
    static void Game(Hero hero,string[] map, int heroX, int heroY)
    {
        bool won = true;
        
        for (int y = 0; y < map.Length; y++)
        {
            for (int x = 0; x < map[y].Length; x++)
            {
                if (map[y][x] == 'G' && heroX == x && heroY == y)
                {
                    hero.Iventory["gold"] += 1; 
                    Console.WriteLine("You collected 1 gold!");

                    char[] row = map[y].ToCharArray();
                    row[x] = '.';
                    map[y] = new string(row);

                }
                else if (map[y][x] == 'W' && heroX == x && heroY == y)
                {
                    hero.Iventory["wood"] += 1;
                    Console.WriteLine("You collected 1 wood!");

                    char[] row = map[y].ToCharArray();
                    row[x] = '.';
                    map[y] = new string(row);

                }
                else if (map[y][x] == 'T' && heroX == x && heroY == y)
                {
                    hero.Iventory["wood"] += 2;
                    hero.Iventory["gold"] += 2;

                    hero.Iventory["diamonds"] += 2;

                    Console.WriteLine("You collected treasures!");

                    char[] row = map[y].ToCharArray();
                    row[x] = '.';
                    map[y] = new string(row);

                }
                else if (map[y][x] == 'D' && heroX == x && heroY == y)
                {
                    hero.Iventory["diamonds"] += 1;
                    Console.WriteLine("You collected 1 diamond!");

                    char[] row = map[y].ToCharArray();
                    row[x] = '.';
                    map[y] = new string(row);

                }
                else if (map[y][x] == 'M' && heroX == x && heroY == y)
                {
                    Console.WriteLine();
                    Console.WriteLine();

                    Random rand = new Random();
                    int helt = rand.Next(80, 101);
                    int pow = rand.Next(1, 11);
                    int ag = rand.Next(1, 11);
                    Monster m1 = new Monster(helt, pow, ag);
                    hero.Print();
                    m1.Print();
                    for (int i = 0; i < 20; i++)
                    {
                        hero.Health -= m1.Strength;
                        m1.Health -= hero.Strength;
                        if (hero.Health < 0 || m1.Health < 0)
                        {
                            break;
                        }
                    }
                    if (m1.Health > hero.Health)
                    {
                        won = false;
                        Console.WriteLine("Ти програв");
                    }
                    else if (m1.Health < hero.Health)
                    {
                        Console.WriteLine("Ти виграв");
                        hero.Health += helt = rand.Next(1, 11); 
                        hero.Strength += pow = rand.Next(1, 3);
                        hero.Agility += ag = rand.Next(1, 3);
                    }

                    char[] row = map[y].ToCharArray();
                    row[x] = '.';
                    map[y] = new string(row);

                }
                else if (map[y][x] == 'A' && heroX == x && heroY == y)
                {
                    Console.WriteLine();
                    Console.WriteLine();

                    Random rand = new Random();
                    int helt = rand.Next(80, 101);
                    int pow = rand.Next(1, 11);
                    int ag = rand.Next(1, 11);
                    Animals m1 = new Animals(helt, pow, ag);
                    hero.Print();
                    m1.Print();
                    for (int i = 0; i < 20; i++)
                    {
                        hero.Health -= m1.Strength;
                        m1.Health -= hero.Strength;
                        if (hero.Health < 0 || m1.Health < 0)
                        {
                            break;
                        }
                    }
                    if (m1.Health > hero.Health)
                    {
                        won = false;
                        Console.WriteLine("Ти програв");
                    }
                    else if (m1.Health < hero.Health)
                    {
                        Console.WriteLine("Ти виграв");
                        hero.Health += helt = rand.Next(1, 11);
                        hero.Strength += pow = rand.Next(1, 3);
                        hero.Agility += ag = rand.Next(1, 3);
                    }

                    char[] row = map[y].ToCharArray();
                    row[x] = '.';
                    map[y] = new string(row);

                }
                else if (map[y][x] == 'B' && heroX == x && heroY == y)
                {
                    Dragon d1 = new Dragon(500, 20, 0);
                    Console.WriteLine();
                    int Damage = 0;
                    Console.WriteLine("Встигни натиснути кнопку (Q) 30 за 10 секунд");
                    int dt = (DateTime.Now.Minute * 60) + DateTime.Now.Second;
                 
                    while (true)
                    {
                        
                        ConsoleKey key1 = Console.ReadKey(true).Key;
                        if (key1 == ConsoleKey.Q)
                        {

                            Damage++;
                            Console.WriteLine($"Q Pressed: {Damage}/30");
                        }
                        if (Damage >= 30)
                        {
                            int dt1 = (DateTime.Now.Minute * 60) + DateTime.Now.Second;
                          

                            if (dt1 - dt  < 10)
                            {
                                Console.WriteLine("Ти переміг");
                            }
                            if (dt1 - dt >= 10)
                            {
                                won = false;
                               
                          
                            }
                            break;
                        }

                    }

                    char[] row = map[y].ToCharArray();
                    row[x] = '.';
                    map[y] = new string(row);

                }

            }
            
        }
        
        bool isFull = false;
        for (int y = 0; y < map.Length; y++)
        {
            for (int x = 0; x < map[y].Length; x++)
            {
                if (map[y][x] == 'M' || map[y][x] == 'B' || map[y][x] == 'A')
                {
                    isFull = true;

                }

            }

        }
        if(won == false)
        {
            Console.WriteLine("__   __            _                          ");
            Console.WriteLine("\\ \\ / /           | |                         ");
            Console.WriteLine(" \\ V /___  _   _  | |     ___   ___  ___  ___ ");
            Console.WriteLine("  \\ // _ \\| | | | | |    / _ \\ / _ \\/ __|/ _ \\");
            Console.WriteLine("  | | (_) | |_| | | |___| (_) | (_) \\__ \\  __/");
            Console.WriteLine("  \\_/\\___/ \\__,_| \\_____/\\___/ \\___/|___/\\___|");
            Console.WriteLine("");
            Console.WriteLine("");
     
        }
        if (!isFull && won == true)
        {
            Console.WriteLine("__   __            _    _ _____      ");
            Console.WriteLine("\\ \\ / /           | |  | |_   _|     ");
            Console.WriteLine(" \\ V /___  _   _  | |  | | | | _ __  ");
            Console.WriteLine("  \\ // _ \\| | | | | |/\\| | | || '_ \\ ");
            Console.WriteLine("  | | (_) | |_| | \\  /\\  /_| || | | |");
            Console.WriteLine("  \\_/\\___/ \\__,_|  \\/  \\/ \\___/_| |_|");
            Console.WriteLine("");
            Console.WriteLine("");

        }

    }

}
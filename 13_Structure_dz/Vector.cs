using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Structure_dz
{
    struct Vectors
    {
        public int[,,] Vector1 { get; set; }
        public int X, Y, Z;

        public Vectors(int x, int y, int z)
        {
            X = x; Y = y; Z = z;
            Vector1 = new int[X, Y, Z];

        }

        public void Enter()
        {
            Random random = new Random();
            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {
                    for (int z = 0; z < Z; z++)
                    {
                        Vector1[x, y, z] = random.Next(1, 10 + 1);

                    }
                }
            }
        }
        public void Print()
        {
            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {
                    for (int z = 0; z < Z; z++)
                    {
                        Console.WriteLine($"Вектор[{x},{y},{z}] = {Vector1[x, y, z]}");
                    }
                }
            }
        }
        public void Mnoz(int number)
        {
            Random random = new Random();
            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {
                    for (int z = 0; z < Z; z++)
                    {
                        Vector1[x, y, z] *= number;

                    }
                }
            }
        }
        public Vectors Add(Vectors vect1, Vectors vect2)
        {

            if (vect1.X != vect2.X || vect1.Y != vect2.Y || vect1.Z != vect2.Z)
            {
                throw new ArgumentException("Розміри векторів повинні бути однаковими");
            }


            Vectors result = new Vectors(vect1.X, vect1.Y, vect1.Z);

            for (int x = 0; x < vect1.X; x++)
            {
                for (int y = 0; y < vect1.Y; y++)
                {
                    for (int z = 0; z < vect1.Z; z++)
                    {

                        result.Vector1[x, y, z] = vect1.Vector1[x, y, z] + vect2.Vector1[x, y, z];
                    }
                }
            }

            return result;

        }
        public Vectors Min1(Vectors vect1, Vectors vect2)
        {

            if (vect1.X != vect2.X || vect1.Y != vect2.Y || vect1.Z != vect2.Z)
            {
                throw new ArgumentException("Розміри векторів повинні бути однаковими");
            }


            Vectors result = new Vectors(vect1.X, vect1.Y, vect1.Z);

            for (int x = 0; x < vect1.X; x++)
            {
                for (int y = 0; y < vect1.Y; y++)
                {
                    for (int z = 0; z < vect1.Z; z++)
                    {

                        result.Vector1[x, y, z] = vect1.Vector1[x, y, z] - vect2.Vector1[x, y, z];
                    }
                }
            }

            return result;

        }
    }
   

}


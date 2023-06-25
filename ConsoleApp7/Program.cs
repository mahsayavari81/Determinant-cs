using System;

class Program
{
    static void Main(string[] args)
    {
        //initialize 3x3 array
        int[,] a = new int[3, 3];

        //get values input
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter value for [{i}, {j}]: ");
                int val = int.Parse(Console.ReadLine()!);
                a[i, j] = val;
            }
        }

        // calculate determinant
        int determinant = (a[0, 0] * a[1, 1] * a[2, 2]
                    + a[0, 1] * a[1, 2] * a[2, 0]
                    + a[0, 2] * a[1, 0] * a[2, 1])
                    - (a[0, 2] * a[1, 1] * a[2, 0]
                    + a[0, 1] * a[1, 0] * a[2, 2]
                    + a[0, 0] * a[1, 2] * a[2, 1]);

        //output determinant
        Console.WriteLine("Determinant: " + determinant);
    }
}
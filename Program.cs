using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());

        bool jePravokutni = (x > 0 && y > 0 && z > 0) && 
                            (x * x + y * y == z * z || x * x + z * z == y * y || y * y + z * z == x * x);

        if (jePravokutni)
            Console.WriteLine("Jest pravokutni trokut.");
        else
            Console.WriteLine("Nije pravokutni trokut (ili vrijednosti nisu veće od 0).");
    }
}

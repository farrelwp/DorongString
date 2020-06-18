using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Segitiga Siku Siku");
            //int number = int.Parse(Console.ReadLine());

            int number = 5;
            Segitiga.Siku(number);

            Segitiga.Siku2(number);

            Segitiga.Number(number);

            Console.WriteLine("Diamond");
            Segitiga.Diamond();
        }
    }
}

class Segitiga
{
    public static void Siku(int val)
    {

        int i, j, k;
        for (i = 1; i <= val; i++)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write("");
            }
            for (k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        Console.ReadLine();
    }

    public static void Diamond()
    {
        int i, j, count = 1, number;
        Console.Write("Enter number of rows:");
        number = int.Parse(Console.ReadLine());
        count = number - 1;
        for (j = 1; j <= number; j++)
        {
            for (i = 1; i <= count; i++)
                Console.Write(" ");
            count--;
            for (i = 1; i <= 2 * j - 1; i++)
                Console.Write("*");
            Console.WriteLine();
        }
        count = 1;
        for (j = 1; j <= number - 1; j++)
        {
            for (i = 1; i <= count; i++)
                Console.Write(" ");
            count++;
            for (i = 1; i <= 2 * (number - j) - 1; i++)
                Console.Write("*");
            Console.WriteLine();
        }
        Console.ReadLine();
    }

    public static void Siku2(int val)
    {
        int i, j, k;
        for (i = 1; i <= val; i++)
        {
            for (j = 1; j <= val - i; j++)
            {
                Console.Write(" ");
            }
            for (k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        Console.ReadLine();
    }

    public static void Number(int n)
    {
        int i, j, k, l;

        for (i = 1; i <= n; i++)
        {
            for (j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            for (k = 1; k <= i; k++)
            {
                Console.Write(k);
            }
            for (l = i - 1; l >= 1; l--)
            {
                Console.Write(l);
            }
            Console.Write("\n");
        }
    }

    public static void fizzbuzz(int range)
    {
        for (int i = 1; i <= range; i++)
        {
            string str = "";
            if (i % 3 == 0)
            {
                str += "Fizz";
            }
            if (i % 5 == 0)
            {
                str += "Buzz";
            }
            if (str.Length == 0)
            {
                str = i.ToString();
            }
            Console.WriteLine(str);

        }
    }
}

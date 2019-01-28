using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t = 0; t < T; t++)
            {
                string line = Console.ReadLine();
                string[] space = line.Split(' ');
                int a = int.Parse(space[0]);
                int b = int.Parse(space[1]);
                int i, x;
                for(x = nextPrime(a); x < b; x++)
                {
                    for (i = 2; i < x; i++)
                        if (x % i == 0)
                            break;
                    if(x==i)
                        Console.Write($"{x} ");
                }
                Console.WriteLine();
            }
            
        }
        static int nextPrime(int a)
        {
            do
            {
                a++;
            } while (!isPrime(a));
            return a;
        }
        static bool isPrime(int n)
        {
            int i;
            for (i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}

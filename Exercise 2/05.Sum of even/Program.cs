﻿namespace _05.Sum_of_even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    sum+=i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
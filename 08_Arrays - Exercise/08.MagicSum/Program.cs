﻿using System;
using System.Linq;

namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = i + 1; j < n.Length; j++)
                {
                    if (n[i] + n[j] == magicNum)
                    {
                        Console.WriteLine($"{n[i]} {n[j]}");
                    }
                }
            }
        }
    }
}

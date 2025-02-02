﻿using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1.WinningTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(", \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

            Regex winningPattern = new Regex(@"([$]{6,10}|[@]{6,10}|[#]{6,10}|[\^]{6,10})");

            foreach (string ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string leftMatch = winningPattern.Match(ticket, 0, 10).Value;
                string rightMatch = winningPattern.Match(ticket, 10).Value;

                if (leftMatch.Length > 0 && rightMatch.Length > 0)
                {
                    if (leftMatch.Length == 10 && leftMatch.Equals(rightMatch))
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10{leftMatch[0]} Jackpot!");
                    }
                    else if (leftMatch.Contains(rightMatch) || rightMatch.Contains(leftMatch))
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftMatch.Length, rightMatch.Length)}{leftMatch[0]}");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}

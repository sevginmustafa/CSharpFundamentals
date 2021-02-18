using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections.Generic;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "Season end")
            {
                string[] splittedInput = input.Split();

                string sign = splittedInput[1];

                if (sign == "->")
                {
                    splittedInput = input.Split(" -> ");

                    string player = splittedInput[0];
                    string position = splittedInput[1];
                    int skill = int.Parse(splittedInput[2]);

                    if (!players.ContainsKey(player))
                    {
                        players.Add(player, new Dictionary<string, int>());
                    }

                    if (!players[player].ContainsKey(position))
                    {
                        players[player].Add(position, skill);
                    }

                    if (skill > players[player][position])
                    {
                        players[player][position] = skill;
                    }
                }
                else
                {
                    splittedInput = input.Split(" vs ");

                    string player1 = splittedInput[0];
                    string player2 = splittedInput[1];

                    if (players.ContainsKey(player1) && players.ContainsKey(player2))
                    {
                        string playerToRemove = string.Empty;

                        foreach (var position1 in players[player1])
                        {
                            foreach (var position2 in players[player2])
                            {
                                if (position1.Key == position2.Key)
                                {
                                    if (players[player1].Values.Sum() > players[player2].Values.Sum())
                                    {
                                        playerToRemove = player2;
                                    }
                                    else if (players[player1].Values.Sum() < players[player2].Values.Sum())
                                    {
                                        playerToRemove = player1;
                                    }
                                }
                            }
                        }
                        players.Remove(playerToRemove);
                    }
                }
            }

            foreach (var player in players.OrderByDescending(x => x.Value.Sum(x => x.Value)).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Sum(x => x.Value)} skill");

                foreach (var position in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
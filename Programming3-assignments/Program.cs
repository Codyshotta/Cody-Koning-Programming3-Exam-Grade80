using System;
using System.Collections.Generic;

namespace Programming3_assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Program MyProgram = new Program();
            MyProgram.Start();
        }
        void Start()
        {
            Assignment6();
        }
        void Assignment1()
        {
            Player player = new Player("Alice", Lane.Center, 100);
            Console.WriteLine($"{player}");
        }
        void Assignment2()
        {
            Player player1 = new Player("Tom", Lane.Right, 70);
            Player player2 = new Player("John", Lane.Left, 56);
            PayingPlayer payingPlayer1 = new PayingPlayer("Bob", Lane.Center, 85, 0.5);
            PayingPlayer payingPlayer2 = new PayingPlayer("Laura", Lane.Right, 95, 0.8);
            List<Player> players = new List<Player>();
            players.Add(player1);
            players.Add(player2);
            players.Add(payingPlayer1);
            players.Add(payingPlayer2);
            foreach (Player player in players)
                Console.WriteLine(player);
        }
        void Assignment3()
        {
            Team team = new Team("team1", DateTime.Now);
            Player player1 = new Player("Tom", Lane.Right, 70);
            Player player2 = new Player("John", Lane.Left, 56);
            PayingPlayer payingPlayer1 = new PayingPlayer("Bob", Lane.Center, 85, 0.5);
            PayingPlayer payingPlayer2 = new PayingPlayer("Laura", Lane.Right, 95, 0.8);
            team.players.Add(player1);
            team.players.Add(player2);
            team.players.Add(payingPlayer1);
            team.players.Add(payingPlayer2);
            Console.WriteLine($"total score of team '{team.Name}' = {team.TotalScore}");
        }
        void Assignment5()
        {
            PickupManager manager = new PickupManager();
            Player player = new Player("Jan", Lane.Left, 85);
            for (int i = 0; i < 2; i++)
                manager.AssignPickupToPlayer(player);
        }
        void Assignment6()
        {
            PickupManager manager = new PickupManager();
            Player player1 = new Player("Tom", Lane.Left, 85);
            PayingPlayer player2 = new PayingPlayer("Bob", Lane.Center, 95,0.5);
            for (int i = 0; i < 3; i++)
            {
                manager.AssignPickupToPlayer(player1);
                manager.AssignPickupToPlayer(player2);
            }
            manager.DisplayPickupAssignments();
        }
    }
}

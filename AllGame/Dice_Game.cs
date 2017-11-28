using System;
using Dice;

namespace AllGame
{
    public class Dice_Game:Game
    {
        public static string Name { get { return "摇色子游戏"; } }
        Player[] players;
        public Dice_Game()
        {
            players = new Player[2];
            players[0] = new Player("玩家");
            players[1] = new Player("电脑");
        }
        public Player Winner()
        {
            for (int i = 0; i < 2; i++)
            {
                players[i].Play();
                Console.WriteLine(players[i].ToString());
                Console.ReadKey();
                Console.WriteLine();
            }
            if (players[0] > players[1])
                return players[0];
            if (players[1] > players[0])
                return players[1];
            return null;
        }
        public override  void Play()
        {
            Player winner = Winner();
            Console.Write("\t\t");
            if (winner == null)
                Console.WriteLine("平局！");
            else
                Console.WriteLine(winner.Name + "胜利！");
        }
    }
}

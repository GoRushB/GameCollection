using MonkeyBanana;
using System;
namespace AllGame
{
    public class MonkeyBanana_Game:Game
    {
        public static string Name { get { return "猴子香蕉游戏"; } }
        public Player[] Players;
        public MonkerBanana_Game_Round Round;
        public MonkeyBanana_Game()
        {
            Players = new Player[2];
            Players[0] = new People("玩家");
            Players[1] = new Bot("电脑");

        }
        public override void Play()
        {
            Player winer;
            do
            {
                Round = new MonkerBanana_Game_Round(Players);
                winer = Round.Start();
                Reset();
                Console.ReadKey();
                Console.Clear();
            } while (winer == null);
            Console.WriteLine("游戏结束，" + winer.Name + "获得胜利！");
        }
        public void Reset()
        {
            foreach (var player in Players)
                player.DMG = player.AC = 0;
        }
    }
}
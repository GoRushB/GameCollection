using MonkeyBanana;
using System;

namespace AllGame
{
    public class MonkerBanana_Game_Round
    {
        private Player people;
        private Player bot;

        public MonkerBanana_Game_Round(Player[] Players)
        {
            people = Players[0];
            bot = Players[1];
        }
        public void LookSkill()
        {
            Console.WriteLine("*********");
            Console.WriteLine("技能列表:");
            for (int i = 0; i < 5; i++)
                Console.Write((i + 1) + people.Skills[i].Name + "  ");
            Console.WriteLine();
        }

        public int UseSkill()
        {
            LookSkill();
            do
            {
                Console.WriteLine();
                Console.Write("选择要施放的技能:");
                ConsoleKey Num = Console.ReadKey().Key;
                Console.WriteLine();
                switch (Num)
                {
                    case ConsoleKey.NumPad1: return 0;
                    case ConsoleKey.NumPad2: return 1;
                    case ConsoleKey.NumPad3: return 2;
                    case ConsoleKey.NumPad4: return 3;
                    case ConsoleKey.NumPad5: return 4;
                }
                Console.Write("输入内容错误，请重新输入:");
            } while (true);
        }
        public Player Start()
        {
            String botskill, peopleskill;
            botskill = bot.CastSkill(people.MP);
            peopleskill = people.CastSkill(UseSkill());
            Console.WriteLine(peopleskill);
            Console.WriteLine(botskill);
            if (people.Bomb())
            {
                Console.WriteLine("玩家因强行施放技能而死亡！");
                return bot;
            }
            if (people > bot)
                return people;
            if (bot > people)
                return bot;
            return null;
        }
    }
}

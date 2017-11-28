using System;
using System.Collections.Generic;

namespace AllGame
{
    public class Program
    {
        static List<string> GameNames = new List<string>()
        {
            Dice_Game.Name,
            MonkeyBanana_Game.Name,
            Number2048_Game.Name,
        };
        static Game Select()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("选择想要开始的游戏：");
                for (int i = 1; i <= GameNames.Count; i++)
                    Console.WriteLine("ID：" + i + "\t" + GameNames[i - 1]);
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.NumPad1: return new Dice_Game();
                    case ConsoleKey.NumPad2: return new MonkeyBanana_Game();
                    case ConsoleKey.NumPad3: return new Number2048_Game();
                }
                Console.Write("输入内容错误，请重新输入:");
            } while (true);
        }
        static void Main()
        {
            Game Game = null;
            do
            {
                Game = Select();
                Console.Clear();
                Console.WriteLine("\t\t游戏开始！");
                Console.ReadKey();
                Game.Play();
                Console.WriteLine();
                Console.WriteLine("按“Esc”结束游戏，按任一键开始新的游戏");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
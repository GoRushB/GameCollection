using System;
using Number2048;

namespace AllGame
{
    public class Number2048_Game:Game
    {
        public static string Name { get { return "2048数字游戏"; } }
        private Matrix Table { get; set; }
        public Number2048_Game()
        {
            Table = new Matrix();
        }
        private void LookTable()
        {
            Console.WriteLine("—————————————————————————————————");
            for (int i = 0; i < Matrix.Size; i++)
            {
                Console.Write("|");
                for (int j = 0; j < Matrix.Size; j++)
                    Console.Write("\t" + Table.Cells[i, j].ToString() + "\t" + "|");
                Console.WriteLine();
                Console.WriteLine("—————————————————————————————————");
                Console.WriteLine();
            }
        }
        public override void Play()
        {
            do
            {
                Table.NewNum();
                Console.Clear();
                LookTable();
                if (Table.Over())
                    break;
                while (!Table.Move(Console.ReadKey().Key))
                { }
                Table.Reset();
                Console.Clear();
                LookTable();
            } while (true);
        }
    }
}

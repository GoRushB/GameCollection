using System.Collections.Generic;
using System.Linq;

namespace Dice
{
    public class Player
    {
        public string Name { get; set; }
        public List<int> Num { get; set; }
        public int Sum { get; set; }
        public Dice Dice { get; set; }
        public int Rank { get; set; }
        public Player(string Name)
        {
            this.Name = Name;
            Num = new List<int>();
            Sum = 0;
            Dice = new Dice();
            Rank = 1;
        }
        public void Play()
        {
            for (int i = 0; i < 3; i++)
            {
                Num.Add(Dice.Use());
                Sum += Num[Num.Count - 1];
            }
            Num = Num.OrderBy(x => x).ToList();
            RankUp();
        }
        public void RankUp()
        {
            for (int i = 0; i < 2; i++)
                if (Num[i] == Num[i + 1])
                    Rank++;
        }
        public static bool operator >(Player a, Player b)
        {
            if (a.Rank > b.Rank)
                return true;
            else if (a.Rank < b.Rank)
                return false;
            else
                return a.Sum > b.Sum;
        }
        public static bool operator <(Player a, Player b)
        {
            if (a.Rank < b.Rank)
                return true;
            else if (a.Rank > b.Rank)
                return false;
            else
                return a.Sum < b.Sum;
        }
        public override string ToString()
        {
            string str = Name + "：";
            switch (Rank)
            {
                case 1: str += "单点:"; break;
                case 2: str += "对子:"; break;
                case 3: str += "豹子:"; break;
            }
            for (int i = 0; i < 3; i++)
                str += "\t" + Num[i];
            str += "\n" + "和：" + Sum;
            return str;
        }
    }
}

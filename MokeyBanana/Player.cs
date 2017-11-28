using System.Collections.Generic;

namespace MonkeyBanana
{
    public abstract class Player
    {
        public string Name { get; set; }
        public List<Skill> Skills { get; set; }
        public int MP { get; set; }
        public int AC { get; set; }
        public int DMG { get; set; }
        public Player(string TheName)
        {
            Name = TheName;
            MP = DMG = AC = 0;
        }
        public abstract string CastSkill(int a);
        public static bool operator >(Player p1, Player p2)
        {
            if (p1.DMG > p2.DMG + p2.AC)
                return true;
            return false;
        }
        public static bool operator <(Player p1, Player p2)
        {
            if (p1.DMG + p1.AC < p2.DMG)
                return true;
            return false;
        }
        public bool Bomb()
        {
            return MP < 0;
        }
    }
}

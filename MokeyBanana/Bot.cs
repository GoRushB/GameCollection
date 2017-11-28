using System;
using System.Collections.Generic;

namespace MonkeyBanana
{
    public class Bot : Player
    {
        public Bot(string TheName) : base(TheName)
        {
            Skills = new List<Skill>()
            {
                {new Banana() },
                {new Wave() },
                {new Boxing() },
            };
        }
        public Dictionary<int, Skill> CanDidCastSkliis(int PlayerMP)
        {
            var dictionary = new Dictionary<int, Skill>();
            if (MP - 3 >= PlayerMP * 3)
            {
                dictionary.Add(dictionary.Count, new Boxing());
                return dictionary;
            }
            foreach (var Skill in Skills)
                if (MP >= Skill.Cost)
                    dictionary.Add(dictionary.Count, Skill);
            if (PlayerMP >= 1)
            {
                dictionary.Add(dictionary.Count, new Defense());
                if (PlayerMP >= 3 && MP >= 1)
                    dictionary.Add(dictionary.Count, new Dodge());
            }
            return dictionary;
        }
        public override string CastSkill(int PlayerMP)
        {
            var Skills = CanDidCastSkliis(PlayerMP);
            Random r = new System.Random(System.Guid.NewGuid().GetHashCode());
            return Skills[r.Next(Skills.Count)].Cast(this);
        }
    }
}

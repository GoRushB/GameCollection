using System.Collections.Generic;

namespace MonkeyBanana
{
    public class People : Player
    {
        public People(string TheName) : base(TheName)
        {
            Skills = new List<Skill>()
            {
                {new Banana() },
                {new Defense() },
                {new Dodge() },
                {new Wave() },
                {new Boxing() },
            };
        }
        public override string CastSkill(int UseSkillNum)
        {
            return Skills[UseSkillNum].Cast(this);
        }
    }
}

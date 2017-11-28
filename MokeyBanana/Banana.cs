namespace MonkeyBanana
{
    public class Banana : Skill
    {
        public Banana()
        {
            Name = "香蕉";
            Cost = 0;
        }

        public override string Cast(Player player)
        {
            player.MP++;
            return player.Name + "使用技能：" + Name;
        }
    }
}
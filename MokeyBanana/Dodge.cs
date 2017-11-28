namespace MonkeyBanana
{
    public class Dodge : Skill
    {
        public Dodge()
        {
            Name = "闪";
            Cost = 1;
        }

        public override string Cast(Player player)
        {
            player.MP -= Cost;
            player.AC = 3;
            return player.Name + "使用技能：" + Name;
        }
    }
}

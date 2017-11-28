namespace MonkeyBanana
{
    public class Wave : Skill
    {
        public Wave()
        {
            Name = "波";
            Cost = 1;
        }

        public override string Cast(Player player)
        {
            player.MP -= Cost;
            player.DMG = 1;
            return player.Name + "使用技能：" + Name;
        }
    }
}

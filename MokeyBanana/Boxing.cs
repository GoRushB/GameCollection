namespace MonkeyBanana
{
    public class Boxing : Skill
    {
        public Boxing()
        {
            Name = "拳";
            Cost = 3;
        }

        public override string Cast(Player player)
        {
            player.MP -= Cost;
            player.DMG = 3;
            return player.Name + "使用技能：" + Name;
        }
    }
}

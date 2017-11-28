namespace MonkeyBanana
{
    public class Defense : Skill
    {
        public Defense()
        {
            Name = "挡";
            Cost = 0;
        }

        public override string Cast(Player player)
        {
            player.AC = 1;
            return player.Name + "使用技能：" + Name;
        }
    }
}

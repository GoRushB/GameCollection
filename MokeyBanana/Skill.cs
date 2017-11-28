namespace MonkeyBanana
{
    public abstract class Skill
    {
        public int Cost { get; protected set; }
        public string Name { get; protected set; }
        public abstract string Cast(Player player);
    }
}

using System;

namespace Dice
{
    public class Dice
    {
        Random r;
        public Dice()
        {
            r = new Random(Guid.NewGuid().GetHashCode());
        }
        public int Use()
        {
            return r.Next(1, 6);
        }
    }
}

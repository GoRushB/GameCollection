namespace Number2048
{
    public class Cell
    {
        public int Num { get; set; }
        public bool CanAdd { get; set; }
        public Cell()
        {
            Num = 0;
            CanAdd = true;
        }
        public override string ToString()
        {
            return Num != 0 ? Num.ToString() : " ";
        }
    }
}
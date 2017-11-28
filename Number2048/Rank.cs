namespace Number2048
{
    public class Rank
    {
        private Cell[] Cells { get; set; }
        private bool Doit { get; set; }
        public Rank(params Cell[] TheCells)
        {
            Cells = TheCells;
            Doit = false;
        }
        private void Swap(Cell a, Cell b)
        {
            a.Num += b.Num;
            b.Num = 0;
            Doit = true;
        }
        private void Add()
        {
            for (int i = Matrix.Size - 2; i >= 0; i--)
            {
                if (Cells[i].Num == 0)
                    continue;
                for (int j = i + 1; j < Matrix.Size; j++)
                    if (Cells[i].Num == Cells[j].Num && Cells[j].CanAdd)
                    {
                        Swap(Cells[j], Cells[i]);
                        Cells[j].CanAdd = false;
                        break;
                    }
            }
        }
        private void Move()
        {
            for (int i = Matrix.Size - 2; i >= 0; i--)
            {
                if (Cells[i].Num == 0)
                    continue;
                for (int j = i + 1, k = i; j < Matrix.Size; j++)
                    if (Cells[j].Num == 0)
                        Swap(Cells[j], Cells[k++]);
            }
        }
        public bool Change()
        {
            Add();
            Move();
            return Doit;
        }
        public bool Over()
        {
            for (int i = 0; i < Matrix.Size - 1; i++)
                if (Cells[i].Num == 0 || Cells[i + 1].Num == 0 || Cells[i].Num == Cells[i + 1].Num)
                    return false;
            return true;
        }
    }
}
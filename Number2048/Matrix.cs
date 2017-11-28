using System;
using System.Collections;
using System.Collections.Generic;

namespace Number2048
{
    public class Matrix : IEnumerable<Rank>
    {
        public const int Size = 4;
        public Cell[,] Cells { get; set; }
        private List<Cell> VoidCells { get; set; }
        private ConsoleKey Direction { get; set; }
        public Matrix()
        {
            Cells = new Cell[Size, Size];
            for (int i = 0; i < Size * Size; i++)
                Cells[i / Size, i % Size] = new Cell();
        }
        public void Reset()
        {
            foreach (var cell in Cells)
                cell.CanAdd = true;
        }
        private bool HaveVoid()
        {
            VoidCells = new List<Cell>();
            foreach (var a in Cells)
                if (a.Num == 0)
                    VoidCells.Add(a);
            return VoidCells.Count != 0;
        }
        public void NewNum()
        {
            if (!HaveVoid())
                return;
            Random r = new Random();
            VoidCells[r.Next(VoidCells.Count)].Num = 2;
        }
        public bool Move(ConsoleKey InputKey)
        {
            bool doit = false;
            Direction = InputKey;
            foreach (var rank in this)
                if (rank.Change())
                    doit = true;
            return doit;
        }
        public bool Over()
        {
            List<ConsoleKey> key = new List<ConsoleKey> { ConsoleKey.W, ConsoleKey.S, ConsoleKey.A, ConsoleKey.D };
            for (int i = 0; i < 4; i++)
            {
                Direction = key[i];
                foreach (var rank in this)
                {
                    if (!rank.Over())
                        return false;
                }
            }
            return true;
        }
        public IEnumerator<Rank> GetEnumerator()
        {
            for (int i = 0; i < Size; i++)
                switch (Direction)
                {
                    case ConsoleKey.W:
                        yield return new Rank(Cells[3, i], Cells[2, i], Cells[1, i], Cells[0, i]);
                        break;
                    case ConsoleKey.S:
                        yield return new Rank(Cells[0, i], Cells[1, i], Cells[2, i], Cells[3, i]);
                        break;
                    case ConsoleKey.A:
                        yield return new Rank(Cells[i, 3], Cells[i, 2], Cells[i, 1], Cells[i, 0]);
                        break;
                    case ConsoleKey.D:
                        yield return new Rank(Cells[i, 0], Cells[i, 1], Cells[i, 2], Cells[i, 3]);
                        break;
                }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
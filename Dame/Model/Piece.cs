using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dame.Model
{
    public class Piece
    {
        public enum Color { White, Red }
        public Color PieceColor { get; set; }
        public bool isKing { get; set; }
        public (int row, int column) Position { get; set; }

        public Piece(Color color, int row, int column)
        {
            this.PieceColor = color;
            this.isKing = true;
            this.Position = (row, column);
        }
    }
}

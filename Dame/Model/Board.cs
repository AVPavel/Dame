using Dame.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using static Dame.Utils.Utils;

namespace Dame.Model
{
    public class Board
    {
        public const int Size = 8;
        public Piece[,] BoardState { get; private set; }
        public Board() 
        {
            BoardState = new Piece[Size,Size];
            InitBoard();
        }
        public void InitBoard()
        {
            for(int row = 0; row < Size; row++)
            {
                for(int col = 0; col < Size; col++)
                {
                    if ((row + col) % 2 != 0)
                    {
                        if(row<3)
                            BoardState[row, col] = new Piece(Piece.Color.White, row, col);
                        else
                            BoardState[row, col] = new Piece(Piece.Color.Red, row, col);
                    }
                }
            }
        }

        public bool MovePiece(int fromRow, int fromCol, int toRow, int toCol)
        {
            if(IsOutOfBounds(fromRow, fromCol) || IsOutOfBounds(toRow, toCol))
            {
                return false;
            }

            Piece pieceToMove = BoardState[fromRow, fromCol];
            
            if (pieceToMove == null)
            {
                return false;
            }
            
            BoardState[toRow, toCol] = pieceToMove;
            BoardState[fromRow, fromCol] = null;
            pieceToMove.Position = (toRow, toCol);

            if ((pieceToMove.PieceColor == Piece.Color.White && toRow == Size - 1) ||
                (pieceToMove.PieceColor == Piece.Color.Red && toRow == 0))
            {
                pieceToMove.isKing = true;
            }

            return true;
        }
       
    }
}

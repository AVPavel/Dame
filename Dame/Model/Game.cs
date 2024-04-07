using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dame.Model
{
    public class Game
    {
        public Board GameBoard { get; private set; }
        public bool isGameOver { get; private set; }
        public Piece.Color CurrentPlayer { get; private set; }

        public Game()
        {
            GameBoard = new Board();
            isGameOver = false;
            CurrentPlayer = Piece.Color.Red;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dame.ViewModel
{
    public class GameViewModel
    {
        public ObservableCollection<TileViewModel> BoardTiles { get; private set; }

        public GameViewModel()
        {
            BoardTiles = new ObservableCollection<TileViewModel>();
            PopulateBoard();
        }

        private void PopulateBoard()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    bool isEven = (row + col) % 2 == 0;
                    bool isOccupied = (row < 3 || row > 4) && !isEven;
                    string pieceType = (row < 3) ? "Red" : "White";
                    BoardTiles.Add(new TileViewModel(isEven, isOccupied, pieceType));
                }
            }
        }
    }
}

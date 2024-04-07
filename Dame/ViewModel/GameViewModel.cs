using Dame.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Dame.ViewModel
{
    public class GameViewModel
    {
        public ObservableCollection<TileViewModel> BoardTiles { get; private set; }
        public ICommand MovePieceCommand { get; private set; }
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
                }
            }
        }

        private void MovePiece(object parameter)
        {
            var tile = parameter as TileViewModel;
            if (tile == null || !tile.IsOccupied)
            {
                MessageBox.Show("Mutare");
            }
        }
    }
}

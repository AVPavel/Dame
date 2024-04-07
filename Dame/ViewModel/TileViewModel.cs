using Dame.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Dame.ViewModel
{
    public class TileViewModel
    {
        public string ImagePath { get; set; }
        public string PieceImagePath { get; set; }
        public bool IsOccupied { get; set; }
        public Visibility PieceVisibility { get; set; }
        public TileViewModel(bool isEven, bool isOccupied, string pieceType, GameViewModel gameViewModel)
        {
            ImagePath = isEven ? "pack://application:,,,/Resources/squareWhite.png" : "pack://application:,,,/Resources/squareRed.png";
            IsOccupied = isOccupied;
            PieceImagePath = isOccupied ? $"pack://application:,,,/Resources/piece{pieceType}.png" : null;
            PieceVisibility = IsOccupied ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}

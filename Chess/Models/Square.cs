using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Models.Piece;
using Chess.Models;
using System.ComponentModel;

namespace Chess.Models
{
    public class Square : INotifyPropertyChanged
    {
        public ChessPiece? Piece
        {
            get => _piece;
            set
            {
                _piece = value;
                OnPropertyChanged(nameof(Piece));
            }
        }
        private ChessPiece? _piece;
        public Color Color { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public Square() { }
        public Square(Color color)
        {
            Color = color;
        }
        public Square(Color color, ChessPiece? piece = null)
        {
            Color = color;
            this.Piece = piece;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

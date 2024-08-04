using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Models.Piece;

namespace Chess.Models
{
    public class Player
    {
        string Name { get; set; }
        Color PlayerColor { get; set; }
        List<ChessPiece> CapturedPieces { get; set; }

        public Player(Color color) 
        {
            Color = color;
        }
        public Player() 
        {
            CapturedPieces = [];
        }
        public Player(string Name)
        {
            this.Name = Name;
            CapturedPieces = [];
        }
        public Player(string Name, Color color)
        {
            this.Name = Name;
            PlayerColor = color;
            CapturedPieces = [];
        }
        public void addToCaptured(ChessPiece piece)
        {
            CapturedPieces.Add(piece);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models.Piece
{
    public class Pawn : ChessPiece
    {
        public bool FirstMove { get; set; }
        public Pawn(Color color, bool firstMove) : base(color)
        {
            FirstMove = firstMove;
            ImageSource = color == Color.White ?
             "/Chess;component/Resources/Pieces/WhitePawn.png" :
             "/Chess;component/Resources/Pieces/BlackPawn.png";
        }

        public override List<Vector2> MovePattern(Vector2 position)
        {
            List<Vector2> possibleMoves = new List<Vector2>();
            if (FirstMove)
            {
                if (Color == Color.White) 
                    possibleMoves.Add(position + new Vector2(0, -2));
                else 
                    possibleMoves.Add(position + new Vector2(0, 2));
            }
            if (Color == Color.White)
                possibleMoves.Add(position + new Vector2(0, -1));
            else 
                possibleMoves.Add(position + new Vector2(0, 1));

            return possibleMoves;
        }
    }
}

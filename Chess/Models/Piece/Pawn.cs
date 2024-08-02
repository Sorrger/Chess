using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models.Piece
{
    internal class Pawn : ChessPiece
    {
        bool FirstMove;
        public Pawn() {
            firstMove = true;
        }
        public override List<Vector2> MovePattern()
        {
            List<Vector2> possibleMoves = new List<Vector2>();
            if (FirstMove)
            {
                possibleMoves.Add(Position + new Vector2(0, 2));
            }
            possibleMoves.Add(Position + new Vector2(0, 1));

            return possibleMoves;
        }
    }
}

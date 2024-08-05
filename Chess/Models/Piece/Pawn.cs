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
        }

        public override List<Vector2> MovePattern(Vector2 position)
        {
            List<Vector2> possibleMoves = new List<Vector2>();
            if (FirstMove)
            {
                possibleMoves.Add(position + new Vector2(0, 2));
            }
            possibleMoves.Add(position + new Vector2(0, 1));

            return possibleMoves;
        }
    }
}

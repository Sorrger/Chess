using Chess.Models.Piece;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models
{
    public class Game
    {
        public Board chessBoard;
        Player player1, player2;
        bool Paused {  get; set; }
        bool IsGameOver {  get; set; }
        bool WhiteTurn = true;
        public Game()
        {
            player1 = new Player(Color.White);
            player2 = new Player(Color.Black);
            chessBoard = new Board();
            Paused = true;
            IsGameOver = false;
        }
        public void startGame() 
        {
            chessBoard.SetBoard();
            Paused = false;
        }
        public bool CanMoveThere(int x, int y, int fx, int fy)
        {
            if ( fx > 7 || fx < 0 || fy > 7 || fy < 0)
                return false;

            var piece = chessBoard.GetPiece(x, y);
            if (piece == null) return false;

            List<Vector2> possibleMovesOfPiece = piece.MovePattern(new Vector2(x,y));
            if (!possibleMovesOfPiece.Contains(new Vector2(fx, fy)))
                return false;

            if (piece is Knight)
                return true;
            if (piece is Bishop)
            {
                if (Math.Abs(fx - x) != Math.Abs(fy - y))
                    return false;

                int xDirection = ReturnSign(fx,x);
                int yDirection = ReturnSign(fy,y);
                int currentX = x + xDirection;
                int currentY = y + yDirection;
                while (currentX != fx || currentY != fy)
                {
                    if (chessBoard.GetPiece(currentX, currentY) != null)
                        return false;

                    currentX += xDirection;
                    currentY += yDirection;
                }
                return true;
            }
            if (piece is Rook)
            {
                if (x != fx && y != fy)
                    return false;

                int xDirection = ReturnSign(fx, x);
                int yDirection = ReturnSign(fy, y);

                int currentX = x + xDirection;
                int currentY = y + yDirection;
                while (currentX != fx || currentY != fy)
                {
                    if (chessBoard.GetPiece(currentX, currentY) != null)
                        return false;

                    currentX += xDirection;
                    currentY += yDirection;
                }
                return true;
            }
            if (piece is Queen)
            {
                bool isStraightLine = (x == fx || y == fy);
                bool isDiagonal = (Math.Abs(fx - x) == Math.Abs(fy - y));

                if (!isStraightLine && !isDiagonal)
                    return false;

                int xDirection = ReturnSign(fx, x);
                int yDirection = ReturnSign(fy, y);
                int currentX = x + xDirection;
                int currentY = y + yDirection;
                while (currentX != fx || currentY != fy)
                {
                    if (chessBoard.GetPiece(currentX, currentY) != null)
                        return false;

                    currentX += xDirection;
                    currentY += yDirection;
                }
                return true;
            }
            if (piece is King)
            {
                int xDistance = Math.Abs(fx - x);
                int yDistance = Math.Abs(fy - y);

                if (xDistance > 1 || yDistance > 1)
                    return false;

                return true;
            }

            if (piece is Pawn pawn)
            {
                int direction = (pawn.Color == Color.White) ? 1 : -1;

                if (x == fx && y + direction == fy && chessBoard.GetPiece(x, fy) == null)
                    return true;

                if (x == fx && y + 2 * direction == fy &&
                    chessBoard.GetPiece(x, fy) == null &&chessBoard.GetPiece(x, y + direction) == null &&
                    pawn.FirstMove)
                    return true;

                if (Math.Abs(fx - x) == 1 && y + direction == fy && chessBoard.GetPiece(fx, fy) != null)
                    return true;

                return false;
            }
            return false;
        }

        int ReturnSign(int x, int y)
        {
            if (x > y)
                return 1;
            else if (x < y)
                return -1;
            else return 0;
        }
             
    }
}

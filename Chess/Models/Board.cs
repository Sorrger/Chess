using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Models.Piece;
using Chess.Models;

namespace Chess.Models
{
    public class Board
    {
        Square[,] board = new Square[8,8];
        public Board() 
        {
        }
        public void SetBoard()
        {
            //major pieces
            board[0, 0] = new Square(Color.White, new Rook(Color.Black)) { Row = 0, Column = 0 };
            board[0, 1] = new Square(Color.Black, new Knight(Color.Black)) { Row = 0, Column = 1 };
            board[0, 2] = new Square(Color.White, new Bishop(Color.Black)) { Row = 0, Column = 2 };
            board[0, 3] = new Square(Color.Black, new Queen(Color.Black)) { Row = 0, Column = 3 };
            board[0, 4] = new Square(Color.White, new King(Color.Black)) { Row = 0, Column = 4 };
            board[0, 5] = new Square(Color.Black, new Bishop(Color.Black)) { Row = 0, Column = 5 };
            board[0, 6] = new Square(Color.White, new Knight(Color.Black)) { Row = 0, Column = 6 };
            board[0, 7] = new Square(Color.Black, new Rook(Color.Black)) { Row = 0, Column = 7 };

            board[7, 0] = new Square(Color.Black, new Rook(Color.White)) { Row = 7, Column = 0 };
            board[7, 1] = new Square(Color.White, new Knight(Color.White)) { Row = 7, Column = 1 };
            board[7, 2] = new Square(Color.Black, new Bishop(Color.White)) { Row = 7, Column = 2 };
            board[7, 3] = new Square(Color.White, new Queen(Color.White)) { Row = 7, Column = 3 };
            board[7, 4] = new Square(Color.Black, new King(Color.White)) { Row = 7, Column = 4 };
            board[7, 5] = new Square(Color.White, new Bishop(Color.White)) { Row = 7, Column = 5 };
            board[7, 6] = new Square(Color.Black, new Knight(Color.White)) { Row = 7, Column = 6 };
            board[7, 7] = new Square(Color.White, new Rook(Color.White)) { Row = 7, Column = 7 };

            //pawns
            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                {
                    board[1, i] = new Square(Color.Black, new Pawn(Color.Black, true)) { Row = 1, Column = i };
                    board[6, i] = new Square(Color.White, new Pawn(Color.White, true)) { Row = 6, Column = i };
                }
                else
                {
                    board[1, i] = new Square(Color.White, new Pawn(Color.Black, true)) { Row = 1, Column = i };
                    board[6, i] = new Square(Color.Black, new Pawn(Color.White, true)) { Row = 6, Column = i };
                }
            }

            //empty squares
            for (int i = 2; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Color squareColor = (i + j) % 2 == 0 ? Color.White : Color.Black;
                    board[i, j] = new Square(squareColor) { Row = i, Column = j };
                }
            }
        }

        public void MovePiece(int x, int y, int dX, int dY)
        {
            Square fromMove = board[x, y];
            Square toMove = board[dX, dY];

            board[x, y] = new Square(fromMove.Color);
            board[dX, dY] = new Square(toMove.Color,fromMove.Piece);
        }
        public void AddPiece(int x, int y, ChessPiece piece) 
        {
            board[x, y] = new Square(board[x, y].Color, piece);
        }
        public ChessPiece GetPiece(int x, int y)
        {
            return board[x, y].Piece;
        }
        public IEnumerable<Square> GetBoardState()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Square square = board[row, col];
                    square.Row = row;
                    square.Column = col;
                    yield return square;
                }
            }
        }
    }
}

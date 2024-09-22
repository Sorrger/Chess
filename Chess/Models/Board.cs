using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Models.Piece;
using Chess.Models;
using System.Diagnostics;
using System.Collections.ObjectModel;

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
            if (x == dX && y == dY)
                return;
            var piece = board[x, y].Piece;

            if (piece == null)
                return;
            if (piece is Pawn pawn)
            {
                pawn.FirstMove = false;
            }
            board[dX, dY].Piece = piece;
            board[x, y].Piece = null;
            
            PrintBoardState();
        }
        public void PrintBoardState()
        {
            Console.Write("\nCurrent Board State:");

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    var piece = board[row, col].Piece;

                    // Jeśli na polu jest figura, wyświetl jej skrót
                    if (piece != null)
                    {
                        // Skrot do typu figury
                        string pieceShort = GetPieceShortName(piece);
                        Debug.Write(pieceShort + " ");
                    }
                    else
                    {
                        // Puste pole
                        Debug.Write(". ");
                    }
                }
                Debug.Write("\n");  // Nowa linia po każdej iteracji wiersza
            }
            Debug.Write("\n"); // Dodatkowy odstęp po planszy
        }

        private string GetPieceShortName(ChessPiece piece)
        {
            if (piece is Pawn) return piece.Color == Color.White ? "P" : "p";
            if (piece is Rook) return piece.Color == Color.White ? "R" : "r";
            if (piece is Knight) return piece.Color == Color.White ? "N" : "n";
            if (piece is Bishop) return piece.Color == Color.White ? "B" : "b";
            if (piece is Queen) return piece.Color == Color.White ? "Q" : "q";
            if (piece is King) return piece.Color == Color.White ? "K" : "k";

            return "?";  // Dla nieznanych przypadków
        }
        public void AddPiece(int x, int y, ChessPiece piece) 
        {
            board[x, y] = new Square(board[x, y].Color, piece);
        }
        public ChessPiece GetPiece(int x, int y)
        {
            return board[x, y].Piece;
        }
        public ObservableCollection<Square> GetBoardState()
        {
            var boardState = new ObservableCollection<Square>();
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Square square = board[row, col];
                    square.Row = row;
                    square.Column = col;
                    boardState.Add(square);
                }
            }
            return boardState;
        }

    }
}

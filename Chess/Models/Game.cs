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
        Board cheeseBoard;
        Player player1, player2;
        bool Paused {  get; set; }
        bool IsGameOver {  get; set; }
        bool WhiteTurn = true;
        public Game()
        {
            player1 = new Player(Color.White);
            player2 = new Player(Color.Black);
            cheeseBoard = new Board();
            Paused = true;
            IsGameOver = false;
        }
        void startGame() 
        {
            cheeseBoard.SetBoard();
            Paused = false;
        }

        //tutaj uzupelnic logike na razie tylko dla konia zrobione inne figury plus bicie pionka na skos np uzyc isBlocking idk
        bool CanMoveThere(int x, int y, int fx, int fy)
        {
            var piece = cheeseBoard.GetPiece(x, y);

            if (piece == null) return false;

            List<Vector2> possibleMovesOfPiece = piece.MovePattern(new Vector2(x,y));
            if (!possibleMovesOfPiece.Contains(new Vector2(fx, fy)))
                return false;
            if (piece is Knight)
                return true;


            //to do usuniecia
            return false;
        }
        bool IsBlocking(int x, int y, int fx, int fy) 
        {
            return false;
        }
             
    }
}

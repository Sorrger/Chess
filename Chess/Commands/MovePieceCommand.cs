using Chess.Models;
using Chess.Models.Piece;
using Chess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Commands
{
    class MovePieceCommand : CommandBase
    {
        GameViewModel _gameViewModel;
        public MovePieceCommand(GameViewModel gvm)
        {
            _gameViewModel = gvm;
        }
        public override void Execute(object? parameter)
        {
            Square sq = (Square)parameter;
            if (_gameViewModel.Clicked)
            {
                if (!_gameViewModel.PossiblePositions.Contains(new Vector2(sq.Column, sq.Row)))
                    return;
                if(!_gameViewModel.CurrentGame.CanMoveThere((int)_gameViewModel.ClickedPosition.X,
                    (int)_gameViewModel.ClickedPosition.Y, sq.Column, sq.Row))
                    return;
                if (_gameViewModel.CurrentGame.chessBoard.GetPiece(sq.Column, sq.Row) != null)
                {
                    //capture piece kiedys
                    
                }
                _gameViewModel.CurrentGame.chessBoard.MovePiece((int)_gameViewModel.ClickedPosition.X,
                    (int)_gameViewModel.ClickedPosition.Y, sq.Column, sq.Row);
                _gameViewModel.UpdateBoardState();
                _gameViewModel.Clicked = false;
                return;
            }

            if (sq.Piece == null) 
                return;
            _gameViewModel.Clicked = true;
            _gameViewModel.ClickedPosition = new Vector2(sq.Column, sq.Row);
            _gameViewModel.PossiblePositions = sq.Piece.MovePattern(new Vector2(sq.Column, sq.Row));

            Console.WriteLine(sq.Piece.Color.ToString());
        }

    }
}

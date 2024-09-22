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
            var sq = parameter as Square;
            if (_gameViewModel.Clicked)
            {

                if (_gameViewModel.PossiblePositions.Contains(new Vector2(sq.Row, sq.Column)))
                    return;
                if(_gameViewModel.CurrentGame.CanMoveThere((int)_gameViewModel.ClickedPosition.X,
                    (int)_gameViewModel.ClickedPosition.Y, sq.Row, sq.Column))
                    return;

              /*  if (_gameViewModel.CurrentGame.chessBoard.GetPiece(sq.Row, sq.Column) != null)
                {
                    
                    
                }*/
                _gameViewModel.CurrentGame.chessBoard.MovePiece((int)_gameViewModel.ClickedPosition.X ,
                    (int)_gameViewModel.ClickedPosition.Y , sq.Row, sq.Column);
                _gameViewModel.Clicked = false;
                return;
            }

            if (sq.Piece == null) 
                return; 

            _gameViewModel.Clicked = true;
            _gameViewModel.ClickedPosition = new Vector2(sq.Row, sq.Column);
            _gameViewModel.PossiblePositions = sq.Piece.MovePattern(new Vector2(sq.Column, sq.Row));
        }

    }
}

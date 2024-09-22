using Chess.Commands;
using Chess.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Chess.ViewModels
{
    public class GameViewModel : ViewModelBase
    {
        public Game CurrentGame { get; private set; }

        private ObservableCollection<Square> _boardState;
        public ObservableCollection<Square> BoardState
        {
            get => _boardState;
            set
            {
                _boardState = value;
                OnPropertyChanged(nameof(BoardState));
            }
        }
        public bool Clicked;
        public Vector2 ClickedPosition;
        public List<Vector2> PossiblePositions;

        public ICommand MovePiece { get; }

        public GameViewModel()
        {
            CurrentGame = new Game();
            CurrentGame.startGame();
            BoardState = new ObservableCollection<Square>(CurrentGame.chessBoard.GetBoardState());
            Clicked = false;
            MovePiece = new MovePieceCommand(this);
        }
    }
}

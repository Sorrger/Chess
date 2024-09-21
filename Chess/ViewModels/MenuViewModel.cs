using Chess.Commands;
using Chess.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Chess.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        public ICommand MoveToGame { get; }
        public ICommand ExitCommand { get; }
        public MenuViewModel(NavigationStore navigationStore) 
        {
            MoveToGame = new NavigationCommand(navigationStore);
        }
    }
}

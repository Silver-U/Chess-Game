using Chess_Game.Messenger;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Chess_Game.ViewModels
{
    public partial class PiecesSelectorViewModel
    {
        public PiecesSelectorViewModel()
        {

        }

        [RelayCommand]
        public void SelectPiece(String name)
        {
            //Console.WriteLine(name);
            WeakReferenceMessenger.Default.Send(new SelectedPieceMessenger(name));
        }
    }
}

using CommunityToolkit.Mvvm.Input;
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
            MessageBox.Show(name.Substring(0, name.Length - 2));
        }
    }
}

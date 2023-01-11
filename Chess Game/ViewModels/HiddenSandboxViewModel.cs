using Chess_Game.Models;
using CommunityToolkit.Mvvm;
using Chess_Game.ViewModels;
using Chess_Game.Views;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using Chess_Game.Views.HiddenSandbox;
using CommunityToolkit.Mvvm.Messaging;
using Chess_Game.Messenger;

namespace Chess_Game.ViewModels;

public partial class HiddenSandboxViewModel : ObservableObject, IRecipient<SelectedPieceMessenger>
{
    [ObservableProperty]
    public bool isEditMode;

    public String playerPieceEdit { get; set; } 
    public String opponentPieceEdit { get; set; }

    [ObservableProperty]
    public SquaresBoard? board;

    public HiddenSandboxViewModel()
    {
        WeakReferenceMessenger.Default.Register<SelectedPieceMessenger>(this);
    }

    public void Receive(SelectedPieceMessenger message)
    {
        throw new NotImplementedException();
    }

    public void SpawnPieceSelector(String name)
    {
        if(name.EndsWith("P"))
        {
            name = name.Remove(name.Length - 1);

        }
    }

    [RelayCommand]
    public void SpawnPiecesSelector(Object obj)
    {
        if(isEditMode)
        {
            var ca = obj as Canvas;
            var user = new WheelPiecesSelector();
            var position = Mouse.GetPosition(ca);
            Canvas.SetLeft(user, position.X / 1.5);
            Canvas.SetTop(user, position.Y - 80);
            ca.Children.Add(user);

        }
    }

    //var pop = new Popup();
    //var block = new TextBlock();
    //block.Text = "dasdasd";
    //    pop.Child = block;
    //    pop.IsOpen = true;
}

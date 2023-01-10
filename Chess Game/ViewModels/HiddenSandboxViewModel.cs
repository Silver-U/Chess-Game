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

namespace Chess_Game.ViewModels;

public partial class HiddenSandboxViewModel : ObservableObject
{
    [ObservableProperty]
    public bool isEditMode;

    public HiddenSandboxViewModel()
    {
    }

    public void SpawnPieceSelector(object sender, MouseButtonEventArgs e)
    {
        if(e.ChangedButton == MouseButton.Middle && e.ButtonState == MouseButtonState.Pressed)
        {
        }
        throw new NotImplementedException();
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

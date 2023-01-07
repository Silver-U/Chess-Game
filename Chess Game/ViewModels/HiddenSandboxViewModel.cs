using Chess_Game.Models;
using CommunityToolkit.Mvvm;
using Chess_Game.ViewModels;
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

namespace Chess_Game.ViewModels;

public partial class HiddenSandboxViewModel
{

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
    public void Dass()
    {
        MessageBox.Show("test");
    }

    //var pop = new Popup();
    //var block = new TextBlock();
    //block.Text = "dasdasd";
    //    pop.Child = block;
    //    pop.IsOpen = true;
}

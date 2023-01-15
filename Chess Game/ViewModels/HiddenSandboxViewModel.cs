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
using Chess_Game.Models.Pieces;

namespace Chess_Game.ViewModels;

public partial class HiddenSandboxViewModel : ObservableObject, IRecipient<SelectedPieceMessenger>
{
    [ObservableProperty]
    public bool? isEditMode;

    public Piece selectedPiece { get; set; }

    public String? playerPieceEdit { get; set; } 
    public String? opponentPieceEdit { get; set; }

    [ObservableProperty]
    public SquaresBoard? board;

    [ObservableProperty]
    public SquareContainer? container;
    

    public HiddenSandboxViewModel()
    {
        board = new SquaresBoard();
        container = new SquareContainer(4, 5, "D5");
        WeakReferenceMessenger.Default.Register<SelectedPieceMessenger>(this);
    }

    public void Receive(SelectedPieceMessenger message)
    {
        OnPieceSelected(message.Value);
    }

    public void OnPieceSelected(String name)
    {
        if(name.EndsWith("P"))
        {
            name = name.Remove(name.Length - 1);
            selectedPiece =  CreatePieceByName(name);

        }
        else
        {
            name = name.Remove(name.Length - 1);
        }
    }

    [RelayCommand]
    public void SpawnPiecesSelector(Object obj)
    {
        if(isEditMode is true)
        {
            var ca = obj as Canvas;
            var user = new WheelPiecesSelector();
            var position = Mouse.GetPosition(ca);
            Canvas.SetLeft(user, position.X - 150);
            Canvas.SetTop(user, position.Y - 150);
            ca.Children.Add(user);

        }
    }

    private Piece? CreatePieceByName(String name)
    {
        name = string.Concat(name[0].ToString().ToUpper(), name.AsSpan(1));
        var pieceType = Type.GetType("Chess_Game.Models.Pieces." + name);
        if (pieceType != null)
        {
            //return Activator.CreateInstance(pieceType);
            return Cast(Activator.CreateInstance(pieceType), pieceType);
        }
        return null;
    }
    private static dynamic Cast(dynamic obj, Type castTo)
    {
        return Convert.ChangeType(obj, castTo);
    }
    //var pop = new Popup();
    //var block = new TextBlock();
    //block.Text = "dasdasd";
    //    pop.Child = block;
    //    pop.IsOpen = true;
}

using Chess_Game.Models;
using Chess_Game.ViewModels;
using HandyControl.Controls;
using HandyControl.Tools.Extension;
using System;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace Chess_Game.Views
{
    /// <summary>
    /// Interaction logic for hiddenSandoxView.xaml
    /// </summary>
    public partial class hiddenSandboxView : UserControl
    {
        //container="{Binding Container}"
        public hiddenSandboxView()
        {
            InitializeComponent();
            //DataContext = new HiddenSandboxViewModel();


        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            string message = "";

            if(playingBoard.board is null)
            {
                message += "board est null";
            }
            else
            {
                message += "container NOT null";
            }

            message += " et ";
            MessageBox.Show(message);
        }

    }
}

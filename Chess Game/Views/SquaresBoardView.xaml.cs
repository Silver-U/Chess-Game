using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chess_Game.Views
{
    /// <summary>
    /// Interaction logic for SquaresBoardView.xaml
    /// </summary>
    public partial class SquaresBoardView : UserControl
    {
        private const int nbSquare = 8;
        public SquaresBoardView()
        {
            InitializeComponent();
            initialisation();
        }

        private void initialisation()
        {
            for (int i = 0; i < nbSquare; i++)
            {
                for (int j = 0; j < nbSquare; j++)
                {
                    var square = GetSquare();
                    Grid.SetRow(square, i);
                    Grid.SetColumn(square, j);
                    squares.Children.Add(square);
                }
            }

        }

        private static SquareContainerView GetSquare()
        {
            return new SquareContainerView();
        }
    }    
}

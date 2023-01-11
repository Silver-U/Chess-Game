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


        public SquaresBoard Board
        {
            get { return (SquaresBoard)GetValue(boardProperty); }
            set { SetValue(boardProperty, value); }
        }

        // Using a DependencyProperty as the backing store for board.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty boardProperty =
            DependencyProperty.Register("Board", typeof(SquaresBoard), typeof(SquaresBoard), new PropertyMetadata(0));


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
                    var square = GetSquare(i, j, generateSquareId(i, j));
                    Grid.SetRow(square, i);
                    Grid.SetColumn(square, j);
                    squares.Children.Add(square);
                }
            }

        }

        private static SquareContainerView GetSquare(int x, int y, String id)
        {
            var squareContainer = new SquareContainerView();
            Binding myBinding = new Binding("container");
            myBinding.Source = new SquareContainer(x, y, id);
            BindingOperations.SetBinding(squareContainer, SquareContainerView.containerProperty, myBinding);
            return squareContainer;
        }

        private string generateSquareId(int x, int j)
        {
            string id = "";

            switch (x)
            {
                case 0:
                    id += 'a';
                    break;
                case 1:
                    id += 'b';
                    break;
                case 2:
                    id += 'c';
                    break;
                case 3:
                    id += 'd';
                    break;
                case 4:
                    id += 'e';
                    break;
                case 5:
                    id += 'f';
                    break;
                case 6:
                    id += 'g';
                    break;
                case 7:
                    id += 'h';
                    break;
            }

            id += j++;

            return id;
        }
    }    
}

using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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


        public SquaresBoard board
        {
            get { return (SquaresBoard)GetValue(boardProperty); }
            set { SetValue(boardProperty, value); }
        }

        // Using a DependencyProperty as the backing store for board.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty boardProperty =
            DependencyProperty.Register("board", typeof(SquaresBoard), typeof(SquaresBoardView), new PropertyMetadata(null));



        private const int nbSquare = 8;

        public SquaresBoardView()
        {
            InitializeComponent();
            //initialisation();

        }

        private void initialisation()
        {
            for (int i = 0; i < nbSquare; i++)
            {
                for (int j = 0; j < nbSquare; j++)
                {
                    var id = generateSquareId(i, j);
                    var square = GetSquare(i, j, id, board.GetSquareContainerByID(id));
                    Grid.SetRow(square, i);
                    Grid.SetColumn(square, j);
                    squares.Children.Add(square);
                }
            }            
        }

        private static SquareContainerView GetSquare(int x, int y, String id, SquareContainer square)
        {
            var squareContainer = new SquareContainerView();
            Binding myBinding = new Binding();
            myBinding.Source = square;
            squareContainer.SetBinding(SquareContainerView.containerProperty, myBinding);
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

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            initialisation();
        }
    }    
}

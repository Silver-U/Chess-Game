using Chess_Game.Models;
using Chess_Game.Views;
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

namespace Chess_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public BitmapImage image { get; set; }        
        //public Uri image { get; set; }
        public MainWindow()
        {
            //image = new Uri(@"C:\Users\Silver\source\repos\Chess Game\Chess Game\Chess Game\Ressources\Images\yo.jpg", UriKind.Absolute);
            InitializeComponent();

            //image = new BitmapImage(new Uri(@"C:\Users\Silver\source\repos\Chess Game\Chess Game\Chess Game\Ressources\Images\yo.jpg", UriKind.Absolute));
            //po.Source = image;

            //po.Source = image;

        }
    }
}

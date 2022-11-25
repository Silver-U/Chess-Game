using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Chess_Game.Models.Pieces
{
    public class Knight : Piece
    {
        public BitmapImage image { get; set; }
        public Knight() : base()
        {
            image = new BitmapImage(new Uri(@"C:\Users\Silver\source\repos\Chess Game\Chess Game\Chess Game\Ressources\Images\yo.jpg", UriKind.Absolute));
        }

        public Knight(Position position) : base(position)
        {
            image = new BitmapImage(new Uri(@"C:\Users\Silver\source\repos\Chess Game\Chess Game\Chess Game\Ressources\Images\yo.jpg", UriKind.Absolute));

        }
    }
}

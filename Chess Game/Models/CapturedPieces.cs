using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class CapturedPieces
    {
        public List<Piece> pieces { get;}

        public CapturedPieces()
        {
            pieces = new List<Piece>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class Piece
    {
        protected bool isCapture;
        protected Position? position { get; set; }
        public Piece(Position? position)
        {
            isCapture = false;
            this.position = position;
        }
    }
}

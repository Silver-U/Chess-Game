using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public abstract class Piece
    {
        protected bool isCapture { get; set; }
        protected Position? position { get; set; }
        protected string? playerID { get;}
        protected string pieceID { get; set; } 

        protected Piece(Position position)
        {
            isCapture = false;
            this.position = position;
        }

        public Piece()
        {
            position = new Position();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class SquareContainer
    {   
        public Piece? piece { get; set;}
        public Position position { get;}
        public string id { get; }

        public SquareContainer(Position position, String id)
        {
            this.position = position;
            this.id = id;   
        }

        public SquareContainer(int x, int y, String id)
        {
            this.position = new Position(x,y);
            this.id = id;
        }
    }
}


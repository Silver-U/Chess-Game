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
        public Position position { get; private set;}
        public string id { get; private set; }

        public SquareContainer(Position position, string id)
        {
            this.position = position;
            this.id = id;   
        }
    }
}

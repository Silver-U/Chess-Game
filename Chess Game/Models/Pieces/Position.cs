using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class Position
    {
        private int x { get; set;}
        private int j { get; set; }

        public Position(int x, int j)
        {
            this.x = x;
            this.j = j;
        }
        public Position()
        {
            this.x = 0;
            this.j = 0;
        }
    }
}

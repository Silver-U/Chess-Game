using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class Player
    {
        public string id { get; } = Guid.NewGuid().ToString();
        public string name { get; set; }

        public Player(string name)
        {
            this.name = name;
        }
    }
}

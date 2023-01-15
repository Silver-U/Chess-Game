using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class SquaresBoard
    {
        private const int nbSquare = 8;
        public Dictionary<string, SquareContainer> squares { get; set; }

        public SquaresBoard()
        {
            squares = new Dictionary<string, SquareContainer>();
            initialisation();
        }

        private void initialisation()
        {
            for (int i = 0; i < nbSquare; i++)
            {
                for (int j = 0; j < nbSquare; j++)
                {
                    var squareId = generateSquareId(i, j);
                    squares.Add(squareId, new SquareContainer(new Position(i, j), squareId));
                }
            }
        }

        private string generateSquareId(int x, int j)
        {
            string id = "";

            switch(x)
            {
                case 0: id += 'a'; 
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

        public SquareContainer GetSquareContainerByID(String id)
        {
            return squares.GetValueOrDefault(id);
        }
    }
}

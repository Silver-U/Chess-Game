using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class ChessBoard
    {
        public Player player { get; set; }
        public Player opponent { get; set; }
        public SquaresBoard squares { get; set; }    
        public CapturedPieces capturedPlayerPieces { get; set; }    
        public CapturedPieces capturedOpponentPieces { get; set; }

        public ChessBoard()
        {
            player = new Player("Ulrich");
            squares = new SquaresBoard();
            Console.WriteLine(value: player.id);
            capturedPlayerPieces = new CapturedPieces();
            capturedOpponentPieces = new CapturedPieces();
        }
    }
}

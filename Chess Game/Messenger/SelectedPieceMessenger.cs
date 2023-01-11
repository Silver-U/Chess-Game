using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Messenger
{
    public class SelectedPieceMessenger : ValueChangedMessage<String>
    {
        public SelectedPieceMessenger(string value) : base(value)
        {
        }
    }
}

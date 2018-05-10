using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
   public class Game
    {
        public void StartProgram()
        {
            PrintConsole.Welcome();

            PrintConsole.WantToPlay();
            bool status = GameLogic.CheckEnteredAnswer();
            while (status)
            {
                CardDeck cardDeck = new CardDeck();
                cardDeck.Initialization();
                cardDeck.Mix();

                Player player = new Player();
                Player pc = new Player();

                GameLogic.GiveCardToPlayer(player, cardDeck);

                GameLogic.GiveCardToPlayer(pc, cardDeck);

                GameLogic.ChooseWinner(player, pc);

                PrintConsole.WantToPlayOneMoreTime();
                status = GameLogic.CheckEnteredAnswer();
            };
        }
       
    }
}

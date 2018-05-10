using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public static class GameLogic
    {

        public static bool CheckEnteredAnswer()
        {
            bool status = true;
            string answer = Console.ReadLine();
            while (answer != Answer.yes && answer != Answer.no)
            {
                PrintConsole.IncorrectAnswer();
                answer = Console.ReadLine();
            };
            if (answer == Answer.yes)
            {
                status = true;
            }
            if (answer == Answer.no)
            {
                status = false;
            }

            return status;
        }

        public static void ChooseWinner(Player player, Player pc)
        {
            int playerPoints = player.cards.Sum(x => x.Points);
            int pcPoints = pc.cards.Sum(x => x.Points);

            PrintConsole.PrintScore(player, pc);

            if (pcPoints == BlackJackNumbers.Blackjack || pcPoints <= BlackJackNumbers.Blackjack && pcPoints > playerPoints || 
                playerPoints > BlackJackNumbers.Blackjack || playerPoints == pcPoints)
            {
                PrintConsole.YouLose();
            }
            if (playerPoints == BlackJackNumbers.Blackjack || playerPoints <= BlackJackNumbers.Blackjack && playerPoints > pcPoints || 
                playerPoints <= BlackJackNumbers.Blackjack && playerPoints > pcPoints)
            {
                PrintConsole.YouWon();
            }
        }

        public static string GetCard(PlayingCard card)
        {
            return String.Format("{0} {1} ", card.Value.ToString(), card.Suit.ToString());
        }

        public static string GetCards(Player player)
        {
            string nameCards = string.Empty;
            foreach (var i in player.cards)
            {
                nameCards += GameLogic.GetCard(i);
            }
            return nameCards;
        }

        public static void GiveCardToPlayer(Player player, CardDeck deck)
        {
            player.cards.Add(deck.IssueCard());
            player.cards.Add(deck.IssueCard());
        }
    }
}

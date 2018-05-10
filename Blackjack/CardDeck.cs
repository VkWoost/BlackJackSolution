using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
   public class CardDeck
    {
        private Stack<PlayingCard> _cards = new Stack<PlayingCard>(BlackJackNumbers.CardsCount);

        public void Initialization()
        {
            for(int value = 0; value < BlackJackNumbers.TheSameSuitCard; value++)
            {
                int suit = (int)Suits.Diamonds;
                _cards.Push(new PlayingCard(suit++, value));
                _cards.Push(new PlayingCard(suit++, value));
                _cards.Push(new PlayingCard(suit++, value));
                _cards.Push(new PlayingCard(suit++, value));
            }
        }

        public void Mix()
        {
            var random = new Random(DateTime.Now.Millisecond);
            List <PlayingCard> list = _cards.ToList();
            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                var change = list[i];
                list[i] = list[j];
                list[j] = change;
            }
            _cards = new Stack<PlayingCard>(list);
        }
        
        public PlayingCard IssueCard()
        {
            return _cards.Pop();
        }
    }
}

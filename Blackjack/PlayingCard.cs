namespace Blackjack
{
    public class PlayingCard
    {
        public Suits Suit { get; private set; }
        public Value Value { get; private set; }
        public int Points { get; private set; }

        public PlayingCard(int suit, int value)
        {
            Suit = (Suits)suit;
            Value = (Value)value;
            if (value >= (int)Value.Ten && value <= (int)Value.King)
            {
                Points = BlackJackNumbers.PointHighCard;
            }
            if (value == (int)Value.Ace)
            {
                Points = BlackJackNumbers.PointAceCard;
            }
            if (value < (int)Value.Ten)
            {
                Points = value + BlackJackNumbers.PointLowCard;
            }
        }
    }
}

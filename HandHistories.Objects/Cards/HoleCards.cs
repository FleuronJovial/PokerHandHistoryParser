using System;
using System.Runtime.Serialization;

namespace HandHistories.Objects.Cards
{
    [DataContract]
    public class HoleCards : CardGroup
    {
        private HoleCards(params Card [] cards) : base(cards)
        {
        }

        public static HoleCards ForHoldem(Card card1, Card card2)
        {
            return new HoleCards(card1, card2);
        }


        public static HoleCards ForOmaha(Card card1, Card card2, Card card3, Card card4)
        {
            return new HoleCards(card1, card2, card3, card4);
        }


        public static HoleCards NoHolecards()
        {
            return new HoleCards();
        }

        public static HoleCards FromCards(ReadOnlySpan<char> cards)
        {
            Card[] cardsArray = Parse(cards);

            return FromCards(cardsArray);
        }

        public static HoleCards FromCards(Card[] cards)
        {
            if (cards.Length == 0)
            {
                return NoHolecards();
            }
            if (cards.Length > 5)
            {
                throw new ArgumentException("Hole cards cant contain more than 5 cards.");
            }
            return new HoleCards(cards);
        }       
    }
}

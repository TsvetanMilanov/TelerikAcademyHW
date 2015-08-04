using System;
using System.Collections.Generic;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            if (this == null)
            {
                throw new NullReferenceException("Hand must not be null when using ToString() to it!");
            }

            if (this.Cards.Count != 5)
            {
                throw new InvalidOperationException("The hand must have 5 cards!");
            }

            string result = string.Join(" | ", this.Cards);

            return result;
        }
    }
}

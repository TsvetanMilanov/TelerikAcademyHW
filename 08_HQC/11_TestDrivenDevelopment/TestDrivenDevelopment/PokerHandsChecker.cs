namespace Poker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException("Hand to check must not be null!");
            }

            bool isHandValid = true;

            if (hand.Cards.Count != 5)
            {
                return false;
            }

            IList<ICard> handsCards = hand.Cards;

            for (int i = 0; i < handsCards.Count; i++)
            {
                ICard currentCard = handsCards[i];

                for (int j = i + 1; j < handsCards.Count; j++)
                {
                    ICard cardToCheck = handsCards[j];

                    if (currentCard.Face == cardToCheck.Face && currentCard.Suit == cardToCheck.Suit)
                    {
                        return false;
                    }
                }
            }

            return isHandValid;
        }

        public bool IsStraightFlush(IHand hand)
        {
            bool isValidHand = this.IsValidHand(hand);

            if (isValidHand == false)
            {
                throw new ArgumentException("Can not check invalid hand for straight flush!");
            }

            bool areCardsEqualyIncreasing = AreCardsInEqualyIncreasingSequence(hand.Cards);
            bool areCardsFromSameSuit = AreCardsFromSameSuit(hand.Cards);

            if (areCardsEqualyIncreasing == true && areCardsFromSameSuit == true)
            {
                return true;
            }

            return false;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            bool isValidHand = this.IsValidHand(hand);

            if (isValidHand == false)
            {
                throw new ArgumentException("Can not check invalid hand for four of a kind!");
            }

            IDictionary<CardFace, int> repeatingCards = FindRepeatingCards(hand.Cards);
            bool hasFourOfAKind = CheckIfContainsCountOfGroupsOfRepeatingCards(repeatingCards, 1, 4);

            return hasFourOfAKind;
        }

        public bool IsFullHouse(IHand hand)
        {
            bool isValidHand = this.IsValidHand(hand);

            if (isValidHand == false)
            {
                throw new ArgumentException("Can not check invalid hand for full house hand!");
            }

            var repeatingCards = FindRepeatingCards(hand.Cards);

            bool hasOnePair = CheckIfContainsCountOfGroupsOfRepeatingCards(repeatingCards, 1, 2);
            bool hasThreeOfAKind = CheckIfContainsCountOfGroupsOfRepeatingCards(repeatingCards, 1, 3);

            if (hasOnePair == true && hasThreeOfAKind == true)
            {
                return true;
            }

            return false;
        }

        public bool IsFlush(IHand hand)
        {
            bool isValidFlushHand = true;

            bool isValidHand = this.IsValidHand(hand);

            if (isValidHand == false)
            {
                throw new ArgumentException("Can not check invalid hand for flush!");
            }

            bool areCardsEqualyIncreasing = AreCardsInEqualyIncreasingSequence(hand.Cards);

            if (areCardsEqualyIncreasing == true)
            {
                return false;
            }

            bool areCardsFromSameSuit = AreCardsFromSameSuit(hand.Cards);

            if (areCardsFromSameSuit == false)
            {
                return false;
            }

            return isValidFlushHand;
        }

        public bool IsStraight(IHand hand)
        {
            bool isValidHand = this.IsValidHand(hand);

            if (isValidHand == false)
            {
                throw new ArgumentException("Can not check invalid hand for straight!");
            }

            bool areCardsEqualyIncreasing = AreCardsInEqualyIncreasingSequence(hand.Cards);
            bool areCardsFromSameSuit = AreCardsFromSameSuit(hand.Cards);

            if (areCardsEqualyIncreasing == true && areCardsFromSameSuit == false)
            {
                return true;
            }

            return false;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            bool isValidHand = this.IsValidHand(hand);

            if (isValidHand == false)
            {
                throw new ArgumentException("Can not check invalid hand for three of a kind hand!");
            }

            var repeatingCards = FindRepeatingCards(hand.Cards);

            bool hasThreeOfAKind = CheckIfContainsCountOfGroupsOfRepeatingCards(repeatingCards, 1, 3);

            if (hasThreeOfAKind && repeatingCards.Count == 1)
            {
                return true;
            }

            return false;
        }

        public bool IsTwoPair(IHand hand)
        {
            bool isValidHand = this.IsValidHand(hand);

            if (isValidHand == false)
            {
                throw new ArgumentException("Can not check invalid hand for two pair hand!");
            }

            var repeatingCards = FindRepeatingCards(hand.Cards);

            bool hasTwoPair = CheckIfContainsCountOfGroupsOfRepeatingCards(repeatingCards, 2, 2);

            return hasTwoPair;
        }

        public bool IsOnePair(IHand hand)
        {
            bool isValidHand = this.IsValidHand(hand);

            if (isValidHand == false)
            {
                throw new ArgumentException("Can not check invalid hand for one pair hand!");
            }

            var repeatingCards = FindRepeatingCards(hand.Cards);

            bool hasOnePair = CheckIfContainsCountOfGroupsOfRepeatingCards(repeatingCards, 1, 2);

            if (hasOnePair && repeatingCards.Count == 1)
            {
                return true;
            }

            return false;
        }

        public bool IsHighCard(IHand hand)
        {
            bool isValidHand = this.IsValidHand(hand);

            if (isValidHand == false)
            {
                throw new ArgumentException("Can not check invalid hand for high card hand!");
            }

            bool areCardsEqualyIncreasing = AreCardsInEqualyIncreasingSequence(hand.Cards);

            if (areCardsEqualyIncreasing == true)
            {
                return false;
            }

            bool areCardsFromSameSuit = AreCardsFromSameSuit(hand.Cards);

            if (areCardsFromSameSuit == true)
            {
                return false;
            }

            var repeatingCards = FindRepeatingCards(hand.Cards);

            if (repeatingCards.Count > 0)
            {
                return false;
            }

            return true;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }

        private IList<ICard> SortCardsInHand(IList<ICard> listOfCardsInHand)
        {
            IList<ICard> sortedList = listOfCardsInHand
                .OrderBy(card => card.Face)
                .ThenBy(card => card.Suit)
                .ToList();

            return sortedList;
        }

        private bool AreCardsFromSameSuit(IList<ICard> listOfCards)
        {
            CardSuit firstCardSuit = listOfCards[0].Suit;

            bool handHasSameSuitCards = listOfCards.All(card => card.Suit == firstCardSuit);

            return handHasSameSuitCards;
        }

        private bool AreCardsInEqualyIncreasingSequence(IList<ICard> listOfCards)
        {
            IList<ICard> sortedCards = SortCardsInHand(listOfCards);

            for (int i = 0; i < sortedCards.Count - 1; i++)
            {
                ICard firstCard = sortedCards[i];
                ICard secondCard = sortedCards[i + 1];

                if (secondCard.Face - firstCard.Face != 1)
                {
                    return false;
                }
            }

            return true;
        }

        private IDictionary<CardFace, int> FindRepeatingCards(IList<ICard> listOfCards)
        {
            IDictionary<CardFace, int> repeatingCards = new SortedDictionary<CardFace, int>();

            for (int i = 0; i < listOfCards.Count; i++)
            {
                ICard firstCard = listOfCards[i];
                int firstCardCounter = 1;

                for (int j = i + 1; j < listOfCards.Count; j++)
                {
                    ICard currentCard = listOfCards[j];

                    if (firstCard.Face == currentCard.Face)
                    {
                        firstCardCounter++;

                        if (!repeatingCards.ContainsKey(firstCard.Face))
                        {
                            repeatingCards.Add(firstCard.Face, firstCardCounter);
                        }

                        if (repeatingCards.ContainsKey(firstCard.Face) &&
                        repeatingCards[firstCard.Face] < firstCardCounter)
                        {
                            repeatingCards[firstCard.Face] = firstCardCounter;
                        }
                    }
                }
            }

            return repeatingCards;
        }

        private bool CheckIfContainsCountOfGroupsOfRepeatingCards(
            IDictionary<CardFace, int> repeatingCards, int groupsCount, int cardsInGroupCount)
        {
            int countOfGroupsWithCardsCount = 0;

            foreach (KeyValuePair<CardFace, int> element in repeatingCards)
            {
                if (element.Value == cardsInGroupCount)
                {
                    countOfGroupsWithCardsCount++;
                }
            }

            if (countOfGroupsWithCardsCount != groupsCount)
            {
                return false;
            }

            return true;
        }
    }
}

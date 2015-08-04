namespace Santase.Logic.Tests
{
    using Santase.Logic.Tests;

    using NUnit.Framework;
    using Santase.Logic.Cards;

    [TestFixture]
    public class DeckTests
    {
        private Deck deck;
        private int cardsCount;

        [SetUp]
        public void TestsInitialization()
        {
            deck = new Deck();
            cardsCount = deck.CardsLeft;
        }

        [Test]
        public void ChangeTrumpCardShouldProperlyChangeTrumpCard()
        {
            Card oldTrumpCard = deck.GetTrumpCard;
            Card newTrumpCard = null;
            if (oldTrumpCard.Suit == CardSuit.Heart)
            {
                newTrumpCard = new Card(CardSuit.Spade, CardType.Ace);
            }
            else
            {
                newTrumpCard = new Card(CardSuit.Heart, CardType.Ace);
            }

            deck.ChangeTrumpCard(newTrumpCard);

            Assert.AreEqual(newTrumpCard, deck.GetTrumpCard);
        }

        [Test]
        public void CardsShouldBeShuffledWhenCreatingNewDeck()
        {
            Deck secondDeck = new Deck();
            int cardsAtSamePosition = 0;

            while (deck.CardsLeft > 0)
            {
                Card firstDeckCard = deck.GetNextCard();
                Card secondDeckCard = secondDeck.GetNextCard();

                if (firstDeckCard.Type == secondDeckCard.Type && firstDeckCard.Suit == secondDeckCard.Suit)
                {
                    cardsAtSamePosition++;
                }
            }

            Assert.AreNotEqual(cardsCount, cardsAtSamePosition);
        }

        [TestCase(1)]
        [TestCase(10)]
        [TestCase(15)]
        [TestCase(20)]
        [TestCase(24)]
        public void CardsLeftShouldReturnProperValuewhenGettingValidNumberOfCards(int removedCardsCount)
        {
            for (int i = 0; i < removedCardsCount; i++)
            {
                deck.GetNextCard();
            }

            int cardsLeft = deck.CardsLeft;

            Assert.AreEqual(cardsCount - removedCardsCount, cardsLeft);
        }

        [Test]
        public void GetNextCardShouldRemoveTheCardFromTheDeck()
        {
            Card removedCard = deck.GetNextCard();
            bool deckContainsRemovedCard = false;

            for (int i = 0; i < cardsCount - 1; i++)
            {
                Card currentCard = deck.GetNextCard();

                if (removedCard.Type == currentCard.Type && removedCard.Suit == currentCard.Suit)
                {
                    deckContainsRemovedCard = true;
                }
            }

            Assert.IsFalse(deckContainsRemovedCard);
        }

        [Test]
        [ExpectedException(typeof(InternalGameException))]
        public void GetNextCardFromEmptyDeckShouldThrowInternalGameException()
        {
            while (true)
            {
                deck.GetNextCard();
            }
        }
    }
}

namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class HandTests
    {
        [Test]
        public void HandToStringShouldReturnProperValue()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });

            string expectedResult = string.Join(" | ", hand.Cards);
            string actualResultResult = hand.ToString();

            Assert.AreEqual(expectedResult, actualResultResult);
        }

        [TestCase(0)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(6)]
        [ExpectedException(typeof(InvalidOperationException))]
        public void HandToStringShouldThrowInvalivOperationExceptionWhenThereAreNotFiveCardsInHand(int cardsCount)
        {
            IList<ICard> cards = new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            };

            IList<ICard> listOfCardsForHand = new List<ICard>();

            for (int i = 0; i < cardsCount; i++)
            {
                listOfCardsForHand.Add(cards[i]);
            }

            IHand hand = new Hand(listOfCardsForHand);

            string actualResultResult = hand.ToString();
        }

        [Test]
        [ExpectedException(typeof(NullReferenceException))]
        public void HandToStringShouldThrowNullReferenceExceptionWhenHandCardsAreNull()
        {
            IHand hand = new Hand(null);

            hand.ToString();
        }

        [Test]
        [ExpectedException(typeof(NullReferenceException))]
        public void HandToStringShouldThrowNullReferenceExceptionWhenHandIsNull()
        {
            IHand nullHand = null;

            nullHand.ToString();
        }
    }
}

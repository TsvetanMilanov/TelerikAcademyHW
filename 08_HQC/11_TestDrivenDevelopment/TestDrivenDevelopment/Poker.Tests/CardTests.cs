namespace Poker.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CardTests
    {
        [Test]
        public void CardToStringShouldReturnCorrectResult()
        {
            ICard card = new Card(CardFace.Ace, CardSuit.Spades);

            string expectedResult = string.Format("{0} of {1}", card.Face, card.Suit);
            string actualResult = card.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [ExpectedException(typeof(NullReferenceException))]
        public void CardToStringShouldThrowNullReferenceExceptionWhenCardIsNull()
        {
            ICard nullCard = null;

            nullCard.ToString();
        }
    }
}

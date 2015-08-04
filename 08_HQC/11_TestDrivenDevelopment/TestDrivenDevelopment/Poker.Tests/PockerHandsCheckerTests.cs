namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class PockerHandsCheckerTests
    {
        private PokerHandsChecker pockerHandsChecker;
        private IList<ICard> allCards;
        private Dictionary<PockerHands, IHand> allPockerHands;

        [TestFixtureSetUp]
        public void InitializeData()
        {
            pockerHandsChecker = new PokerHandsChecker();

            IList<CardSuit> allCardSuits = new List<CardSuit>();
            IList<CardFace> allCardFaces = new List<CardFace>();

            allCards = new List<ICard>();
            allPockerHands = new Dictionary<PockerHands, IHand>();

            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                allCardSuits.Add(suit);
            }

            foreach (CardFace face in Enum.GetValues(typeof(CardFace)))
            {
                allCardFaces.Add(face);
            }

            foreach (var suit in allCardSuits)
            {
                foreach (var face in allCardFaces)
                {
                    allCards.Add(new Card(face, suit));
                }
            }

            addAllValidHandsToDictionary(allPockerHands);
        }

        [Test]
        public void IsValidHandShouldReturnTrueWhenHandHasValidCards()
        {
            IList<ICard> listOfCards = new List<ICard>();

            for (int i = 0; i < 5; i++)
            {
                listOfCards.Add(allCards[i]);
            }

            IHand hand = new Hand(listOfCards);

            bool isHandValid = pockerHandsChecker.IsValidHand(hand);

            Assert.IsTrue(isHandValid);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsValdHandShouldThrowArgumentNullExceptionWhenHandIsNull()
        {
            IHand nullHand = null;

            bool isHandValid = pockerHandsChecker.IsValidHand(nullHand);
        }

        [Test]
        public void IsValdHandShouldShouldReturnFalseWhenHandHasRepeatingCards()
        {
            IList<ICard> listOfCards = new List<ICard>();

            for (int i = 0; i < 4; i++)
            {
                listOfCards.Add(allCards[i]);
            }

            listOfCards.Add(listOfCards[0]);

            IHand nullHand = new Hand(listOfCards);

            bool isHandValid = pockerHandsChecker.IsValidHand(nullHand);

            Assert.IsFalse(isHandValid);
        }

        [TestCase(0)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(6)]
        [TestCase(7)]
        public void IsValidHandShouldReturnFalseWhenHandHasNotFiveCards(int cardsCount)
        {
            IList<ICard> listOfCards = new List<ICard>();

            for (int i = 0; i < cardsCount; i++)
            {
                listOfCards.Add(allCards[i]);
            }

            IHand hand = new Hand(listOfCards);

            bool isHandValid = pockerHandsChecker.IsValidHand(hand);

            Assert.IsFalse(isHandValid);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFlushShouldThrowArgumentNullExceptionWhenHandIsNull()
        {
            IHand nullHand = null;

            bool isHandFlush = pockerHandsChecker.IsFlush(nullHand);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFlushShouldThrowArgumentExceptionWhenHandIsInvalid()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
            });

            bool isHandFlush = pockerHandsChecker.IsFlush(hand);
        }

        [Test]
        public void IsFlushShouldReturnTrueWhenGivenValidFlushHand()
        {
            IHand validFlushHand = allPockerHands[PockerHands.Flush];

            bool isHandFlush = pockerHandsChecker.IsFlush(validFlushHand);

            Assert.IsTrue(isHandFlush);
        }

        [Test]
        public void IsFlushShouldReturnFalseWhenGivenOnlyOneInvalidCard()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Diamonds)
            });

            bool isValidFlushHand = pockerHandsChecker.IsFlush(hand);

            Assert.IsFalse(isValidFlushHand);
        }

        [Test]
        public void IsFlushShouldReturnFalseWhenGivenMoreThanOneInvalidCards()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Diamonds)
            });

            bool isValidFlushHand = pockerHandsChecker.IsFlush(hand);

            Assert.IsFalse(isValidFlushHand);
        }

        [Test]
        public void IsFlushShouldReturnFalseWhenGivenStraightFlushHand()
        {
            IHand hand = allPockerHands[PockerHands.StraightFlush];

            bool isValidFlushHand = pockerHandsChecker.IsFlush(hand);

            Assert.IsFalse(isValidFlushHand);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFourOfAKindShouldThrowArgumentNullExceptionWhenHandIsNull()
        {
            IHand nullHand = null;

            bool isHandFourOfAKind = pockerHandsChecker.IsFourOfAKind(nullHand);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFourOfAKindShouldThrowArgumentExceptionWhenHandIsInvalid()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
            });

            bool isHandFourOfAKind = pockerHandsChecker.IsFourOfAKind(hand);
        }

        [Test]
        public void IsFourOfAKindShouldReturnTrueWhenGivenValidFourOfAKindHand()
        {
            IHand validFlushHand = allPockerHands[PockerHands.FourOfAKind];

            bool isHandFourOfAKind = pockerHandsChecker.IsFourOfAKind(validFlushHand);

            Assert.IsTrue(isHandFourOfAKind);
        }

        [Test]
        public void IsFourOfAKindShouldReturnFalseWhenGivenThreeOfAKindHand()
        {
            IHand hand = allPockerHands[PockerHands.ThreeOfAKind];

            bool isValidFourOfAKindHand = pockerHandsChecker.IsFourOfAKind(hand);

            Assert.IsFalse(isValidFourOfAKindHand);
        }

        [Test]
        public void IsFourOfAKindShouldReturnFalseWhenGivenOnePairHand()
        {
            IHand hand = allPockerHands[PockerHands.OnePair];

            bool isValidFourOfAKindHand = pockerHandsChecker.IsFourOfAKind(hand);

            Assert.IsFalse(isValidFourOfAKindHand);
        }

        [Test]
        public void IsFourOfAKindShouldReturnFalseWhenGivenTwoPairHand()
        {
            IHand hand = allPockerHands[PockerHands.TwoPair];

            bool isValidFourOfAKindHand = pockerHandsChecker.IsFourOfAKind(hand);

            Assert.IsFalse(isValidFourOfAKindHand);
        }

        [Test]
        public void IsFourOfAKindShouldReturnFalseWhenGivenFullHouse()
        {
            IHand hand = allPockerHands[PockerHands.FullHouse];

            bool isValidFourOfAKindHand = pockerHandsChecker.IsFourOfAKind(hand);

            Assert.IsFalse(isValidFourOfAKindHand);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsHighCardShouldThrowArgumentNullExceptionWhenHandIsNull()
        {
            IHand nullHand = null;

            bool isHighCardHand = pockerHandsChecker.IsHighCard(nullHand);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void IsHighCardShouldThrowArgumentExceptionWhenHandIsInvalid()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
            });

            bool isHighCardHand = pockerHandsChecker.IsHighCard(hand);
        }

        [Test]
        public void IsHighCardShouldReturnTrueWhenGivenValidHighCardHand()
        {
            IHand validHighCardHand = allPockerHands[PockerHands.HighCard];

            bool isHighCardHand = pockerHandsChecker.IsHighCard(validHighCardHand);

            Assert.IsTrue(isHighCardHand);
        }

        [Test]
        public void IsHighCardShouldReturnFalseWhenGivenOnePairHand()
        {
            IHand hand = allPockerHands[PockerHands.OnePair];

            bool isHighCardHand = pockerHandsChecker.IsHighCard(hand);

            Assert.IsFalse(isHighCardHand);
        }

        [Test]
        public void IsHighCardShouldReturnFalseWhenGivenTwoPairHand()
        {
            IHand hand = allPockerHands[PockerHands.TwoPair];

            bool isHighCardHand = pockerHandsChecker.IsHighCard(hand);

            Assert.IsFalse(isHighCardHand);
        }

        [Test]
        public void IsHighCardShouldReturnFalseWhenGivenThreeOfAKindHand()
        {
            IHand hand = allPockerHands[PockerHands.ThreeOfAKind];

            bool isHighCardHand = pockerHandsChecker.IsHighCard(hand);

            Assert.IsFalse(isHighCardHand);
        }

        [Test]
        public void IsHighCardShouldReturnFalseWhenGivenStraightHand()
        {
            IHand hand = allPockerHands[PockerHands.Straight];

            bool isHighCardHand = pockerHandsChecker.IsHighCard(hand);

            Assert.IsFalse(isHighCardHand);
        }

        [Test]
        public void IsHighCardShouldReturnFalseWhenGivenFlushHand()
        {
            IHand hand = allPockerHands[PockerHands.Flush];

            bool isHighCardHand = pockerHandsChecker.IsHighCard(hand);

            Assert.IsFalse(isHighCardHand);
        }

        [Test]
        public void IsHighCardShouldReturnFalseWhenGivenFullHouseHand()
        {
            IHand hand = allPockerHands[PockerHands.FullHouse];

            bool isHighCardHand = pockerHandsChecker.IsHighCard(hand);

            Assert.IsFalse(isHighCardHand);
        }

        [Test]
        public void IsHighCardShouldReturnFalseWhenGivenFourOfAKindHand()
        {
            IHand hand = allPockerHands[PockerHands.FourOfAKind];

            bool isHighCardHand = pockerHandsChecker.IsHighCard(hand);

            Assert.IsFalse(isHighCardHand);
        }

        [Test]
        public void IsHighCardShouldReturnFalseWhenGivenStraightFlushHand()
        {
            IHand hand = allPockerHands[PockerHands.StraightFlush];

            bool isHighCardHand = pockerHandsChecker.IsHighCard(hand);

            Assert.IsFalse(isHighCardHand);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsOnePairShouldThrowArgumentNullExceptionWhenHandIsNull()
        {
            IHand nullHand = null;

            bool isOnePairHand = pockerHandsChecker.IsOnePair(nullHand);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void IsOnePairShouldThrowArgumentExceptionWhenHandIsInvalid()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
            });

            bool isOnePairHand = pockerHandsChecker.IsOnePair(hand);
        }

        [Test]
        public void IsOnePairShouldReturnTrueWhenGivenValidOnePairHand()
        {
            IHand validOnePairHand = allPockerHands[PockerHands.OnePair];

            bool isOnePairHand = pockerHandsChecker.IsOnePair(validOnePairHand);

            Assert.IsTrue(isOnePairHand);
        }

        [Test]
        public void IsOnePairShouldReturnFalseWhenGivenTwoPairHand()
        {
            IHand hand = allPockerHands[PockerHands.TwoPair];

            bool isOnePairHand = pockerHandsChecker.IsOnePair(hand);

            Assert.IsFalse(isOnePairHand);
        }

        [Test]
        public void IsOnePairShouldReturnFalseWhenGivenFullHouseHand()
        {
            IHand hand = allPockerHands[PockerHands.FullHouse];

            bool isOnePairHand = pockerHandsChecker.IsOnePair(hand);

            Assert.IsFalse(isOnePairHand);
        }

        [Test]
        public void IsOnePairShouldReturnFalseWhenGivenThreeOfAKindHand()
        {
            IHand hand = allPockerHands[PockerHands.ThreeOfAKind];

            bool isOnePairHand = pockerHandsChecker.IsOnePair(hand);

            Assert.IsFalse(isOnePairHand);
        }

        [Test]
        public void IsOnePairShouldReturnFalseWhenGivenFourOfAKindHand()
        {
            IHand hand = allPockerHands[PockerHands.FourOfAKind];

            bool isOnePairHand = pockerHandsChecker.IsOnePair(hand);

            Assert.IsFalse(isOnePairHand);
        }

        [Test]
        public void IsOnePairShouldReturnFalseWhenGivenStraightHand()
        {
            IHand hand = allPockerHands[PockerHands.Straight];

            bool isOnePairHand = pockerHandsChecker.IsOnePair(hand);

            Assert.IsFalse(isOnePairHand);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsTwoPairShouldThrowArgumentNullExceptionWhenHandIsNull()
        {
            IHand nullHand = null;

            bool isTwoPairHand = pockerHandsChecker.IsTwoPair(nullHand);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void IsTwoPairShouldThrowArgumentExceptionWhenHandIsInvalid()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
            });

            bool isTwoPairHand = pockerHandsChecker.IsTwoPair(hand);
        }

        [Test]
        public void IsTwoPairShouldReturnTrueWhenGivenValidTwoPairHand()
        {
            IHand validOnePairHand = allPockerHands[PockerHands.TwoPair];

            bool isTwoPairHand = pockerHandsChecker.IsTwoPair(validOnePairHand);

            Assert.IsTrue(isTwoPairHand);
        }

        [Test]
        public void IsTwoPairShouldReturnFalseWhenGivenOnePairHand()
        {
            IHand hand = allPockerHands[PockerHands.OnePair];

            bool isTwoPairHand = pockerHandsChecker.IsTwoPair(hand);

            Assert.IsFalse(isTwoPairHand);
        }

        [Test]
        public void IsTwoPairShouldReturnFalseWhenGivenFullHouseHand()
        {
            IHand hand = allPockerHands[PockerHands.FullHouse];

            bool isTwoPairHand = pockerHandsChecker.IsTwoPair(hand);

            Assert.IsFalse(isTwoPairHand);
        }

        [Test]
        public void IsTwoPairShouldReturnFalseWhenGivenThreeOfAKindHand()
        {
            IHand hand = allPockerHands[PockerHands.ThreeOfAKind];

            bool isTwoPairHand = pockerHandsChecker.IsTwoPair(hand);

            Assert.IsFalse(isTwoPairHand);
        }

        [Test]
        public void IsTwoPairShouldReturnFalseWhenGivenFourOfAKindHand()
        {
            IHand hand = allPockerHands[PockerHands.FourOfAKind];

            bool isTwoPairHand = pockerHandsChecker.IsTwoPair(hand);

            Assert.IsFalse(isTwoPairHand);
        }

        [Test]
        public void IsTwoPairShouldReturnFalseWhenGivenStraightHand()
        {
            IHand hand = allPockerHands[PockerHands.Straight];

            bool isTwoPairHand = pockerHandsChecker.IsTwoPair(hand);

            Assert.IsFalse(isTwoPairHand);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsThreeOfAKindShouldThrowArgumentNullExceptionWhenHandIsNull()
        {
            IHand nullHand = null;

            bool isThreeOfAKind = pockerHandsChecker.IsThreeOfAKind(nullHand);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void IsThreeOfAKindShouldThrowArgumentExceptionWhenHandIsInvalid()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
            });

            bool isThreeOfAKind = pockerHandsChecker.IsThreeOfAKind(hand);
        }

        [Test]
        public void IsThreeOfAKindShouldReturnTrueWhenGivenValidThreeOfAKindHand()
        {
            IHand validThreeOfAKindHand = allPockerHands[PockerHands.ThreeOfAKind];

            bool isThreeOfAKind = pockerHandsChecker.IsThreeOfAKind(validThreeOfAKindHand);

            Assert.IsTrue(isThreeOfAKind);
        }

        [Test]
        public void IsThreeOfAKindShouldReturnFalseWhenGivenOnePairHand()
        {
            IHand hand = allPockerHands[PockerHands.OnePair];

            bool isThreeOfAKind = pockerHandsChecker.IsThreeOfAKind(hand);

            Assert.IsFalse(isThreeOfAKind);
        }

        [Test]
        public void IsThreeOfAKindShouldReturnFalseWhenGivenFullHouseHand()
        {
            IHand hand = allPockerHands[PockerHands.FullHouse];

            bool isThreeOfAKind = pockerHandsChecker.IsThreeOfAKind(hand);

            Assert.IsFalse(isThreeOfAKind);
        }

        [Test]
        public void IsThreeOfAKindShouldReturnFalseWhenGivenTwoPairHand()
        {
            IHand hand = allPockerHands[PockerHands.TwoPair];

            bool isThreeOfAKind = pockerHandsChecker.IsThreeOfAKind(hand);

            Assert.IsFalse(isThreeOfAKind);
        }

        [Test]
        public void IsThreeOfAKindShouldReturnFalseWhenGivenFourOfAKindHand()
        {
            IHand hand = allPockerHands[PockerHands.FourOfAKind];

            bool isThreeOfAKind = pockerHandsChecker.IsThreeOfAKind(hand);

            Assert.IsFalse(isThreeOfAKind);
        }

        [Test]
        public void IsThreeOfAKindShouldReturnFalseWhenGivenStraightHand()
        {
            IHand hand = allPockerHands[PockerHands.Straight];

            bool isThreeOfAKind = pockerHandsChecker.IsThreeOfAKind(hand);

            Assert.IsFalse(isThreeOfAKind);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsStraightShouldThrowArgumentNullExceptionWhenHandIsNull()
        {
            IHand nullHand = null;

            bool isStraightHand = pockerHandsChecker.IsStraight(nullHand);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void IsStraightShouldThrowArgumentExceptionWhenHandIsInvalid()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
            });

            bool isStraightHand = pockerHandsChecker.IsStraight(hand);
        }

        [Test]
        public void IsStraightShouldReturnTrueWhenGivenValidStraightHand()
        {
            IHand validThreeOfAKindHand = allPockerHands[PockerHands.Straight];

            bool isStraightHand = pockerHandsChecker.IsStraight(validThreeOfAKindHand);

            Assert.IsTrue(isStraightHand);
        }

        [Test]
        public void IsStraightShouldReturnFalseWhenGivenStraightFlushHand()
        {
            IHand hand = allPockerHands[PockerHands.StraightFlush];

            bool isStraightHand = pockerHandsChecker.IsStraight(hand);

            Assert.IsFalse(isStraightHand);
        }

        [Test]
        public void IsStraightShouldReturnFalseWhenGivenFlushHand()
        {
            IHand hand = allPockerHands[PockerHands.Flush];

            bool isStraightHand = pockerHandsChecker.IsStraight(hand);

            Assert.IsFalse(isStraightHand);
        }

        [Test]
        public void IsStraightShouldReturnFalseWhenGivenHighCardHand()
        {
            IHand hand = allPockerHands[PockerHands.HighCard];

            bool isStraightHand = pockerHandsChecker.IsStraight(hand);

            Assert.IsFalse(isStraightHand);
        }

        [Test]
        public void IsStraightShouldReturnFalseWhenGivenFourEqualyIncreasingCardsAndOneNotEqualyIncreasingCardHand()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Clubs),
            });

            bool isStraightHand = pockerHandsChecker.IsStraight(hand);

            Assert.IsFalse(isStraightHand);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFullHouseShouldThrowArgumentNullExceptionWhenHandIsNull()
        {
            IHand nullHand = null;

            bool isFullHouseHand = pockerHandsChecker.IsFullHouse(nullHand);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFullHouseShouldThrowArgumentExceptionWhenHandIsInvalid()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
            });

            bool isFullHouseHand = pockerHandsChecker.IsFullHouse(hand);
        }

        [Test]
        public void IsFullHouseShouldReturnTrueWhenGivenValidFullHouseHand()
        {
            IHand validOnePairHand = allPockerHands[PockerHands.FullHouse];

            bool isFullHouseHand = pockerHandsChecker.IsFullHouse(validOnePairHand);

            Assert.IsTrue(isFullHouseHand);
        }

        [Test]
        public void IsFullHouseShouldReturnFalseWhenGivenOnePairHand()
        {
            IHand hand = allPockerHands[PockerHands.OnePair];

            bool isFullHouseHand = pockerHandsChecker.IsFullHouse(hand);

            Assert.IsFalse(isFullHouseHand);
        }

        [Test]
        public void IsFullHouseShouldReturnFalseWhenGivenTwoPairHand()
        {
            IHand hand = allPockerHands[PockerHands.TwoPair];

            bool isFullHouseHand = pockerHandsChecker.IsFullHouse(hand);

            Assert.IsFalse(isFullHouseHand);
        }

        [Test]
        public void IsFullHouseShouldReturnFalseWhenGivenThreeOfAKindHand()
        {
            IHand hand = allPockerHands[PockerHands.ThreeOfAKind];

            bool isFullHouseHand = pockerHandsChecker.IsFullHouse(hand);

            Assert.IsFalse(isFullHouseHand);
        }

        [Test]
        public void IsFullHouseShouldReturnFalseWhenGivenFourOfAKindHand()
        {
            IHand hand = allPockerHands[PockerHands.FourOfAKind];

            bool isFullHouseHand = pockerHandsChecker.IsFullHouse(hand);

            Assert.IsFalse(isFullHouseHand);
        }

        [Test]
        public void IsFullHouseShouldReturnFalseWhenGivenStraightHand()
        {
            IHand hand = allPockerHands[PockerHands.Straight];

            bool isFullHouseHand = pockerHandsChecker.IsFullHouse(hand);

            Assert.IsFalse(isFullHouseHand);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsStraightFlushShouldThrowArgumentNullExceptionWhenHandIsNull()
        {
            IHand nullHand = null;

            bool isHandStraightFlush = pockerHandsChecker.IsStraightFlush(nullHand);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void IsStraightFlushShouldThrowArgumentExceptionWhenHandIsInvalid()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
            });

            bool isHandStraightFlush = pockerHandsChecker.IsStraightFlush(hand);
        }

        [Test]
        public void IsStraightFlushShouldReturnTrueWhenGivenValidStraightFlushHand()
        {
            IHand validFlushHand = allPockerHands[PockerHands.StraightFlush];

            bool isHandStraightFlush = pockerHandsChecker.IsStraightFlush(validFlushHand);

            Assert.IsTrue(isHandStraightFlush);
        }

        [Test]
        public void IsStraightFlushShouldReturnFalseWhenGivenOnlyOneInvalidSuitCard()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Diamonds)
            });

            bool isHandStraightFlush = pockerHandsChecker.IsStraightFlush(hand);

            Assert.IsFalse(isHandStraightFlush);
        }

        [Test]
        public void IsStraightFlushShouldReturnFalseWhenGivenMoreThanOneInvalidSuitCards()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Diamonds)
            });

            bool isHandStraightFlush = pockerHandsChecker.IsStraightFlush(hand);

            Assert.IsFalse(isHandStraightFlush);
        }

        [Test]
        public void IsStraightFlushShouldReturnFalseWhenGivenFlushHand()
        {
            IHand hand = allPockerHands[PockerHands.Flush];

            bool isHandStraightFlush = pockerHandsChecker.IsStraightFlush(hand);

            Assert.IsFalse(isHandStraightFlush);
        }

        [Test]
        public void IsStraightFlushShouldReturnFalseWhenGivenHighCardHand()
        {
            IHand hand = allPockerHands[PockerHands.HighCard];

            bool isHandStraightFlush = pockerHandsChecker.IsStraightFlush(hand);

            Assert.IsFalse(isHandStraightFlush);
        }

        [Test]
        public void IsStraightFlushShouldReturnFalseWhenGivenOnlyOneInvalidFaceCard()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Hearts)
            });

            bool isHandStraightFlush = pockerHandsChecker.IsStraightFlush(hand);

            Assert.IsFalse(isHandStraightFlush);
        }

        [Test]
        public void IsStraightFlushShouldReturnFalseWhenGivenMoreThanOneInvalidFaceCards()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts)
            });

            bool isHandStraightFlush = pockerHandsChecker.IsStraightFlush(hand);

            Assert.IsFalse(isHandStraightFlush);
        }

        private void addAllValidHandsToDictionary(Dictionary<PockerHands, IHand> allPockerHands)
        {
            IHand straightFlushHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades)
            });

            allPockerHands.Add(PockerHands.StraightFlush, straightFlushHand);

            IHand fourOfAKindHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Spades)
            });

            allPockerHands.Add(PockerHands.FourOfAKind, fourOfAKindHand);

            IHand fullHouseHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Spades)
            });

            allPockerHands.Add(PockerHands.FullHouse, fullHouseHand);

            IHand flushHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades)
            });

            allPockerHands.Add(PockerHands.Flush, flushHand);

            IHand straightHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Spades)
            });

            allPockerHands.Add(PockerHands.Straight, straightHand);

            IHand threeOfAKindHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Spades)
            });

            allPockerHands.Add(PockerHands.ThreeOfAKind, threeOfAKindHand);

            IHand twoPairHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Spades)
            });

            allPockerHands.Add(PockerHands.TwoPair, twoPairHand);

            IHand onePairHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Spades)
            });

            allPockerHands.Add(PockerHands.OnePair, onePairHand);

            IHand highCardHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Spades)
            });

            allPockerHands.Add(PockerHands.HighCard, highCardHand);
        }
    }
}
using NUnit.Framework;
using Santase.Logic;

namespace Santase.Logic.Tests
{
    using Cards;
    using NUnit.Framework;
    using Players;
    using RoundStates;
    using ConsoleUI;
    using System.Collections.Generic;

    [TestFixture]
    public class PlayerActionValidaterTests
    {
        private ISantaseGame game;
        private PlayerAction action;
        private PlayerTurnContext context;
        private IList<Card> playerCards;
        private IPlayer firstPlayer;
        private IPlayer secondPlayer;
        private Card testCard;
        private Card trumpCard;
        private IGameRound gameRound;
        private MoreThanTwoCardsLeftRoundState roundState;
        private PlayerActionValidater validator = new PlayerActionValidater();

        [SetUp]
        public void InitializeData()
        {
            firstPlayer = new ConsolePlayer(5, 10);
            secondPlayer = new ConsolePlayer(10, 10);

            gameRound = new GameRound(firstPlayer, secondPlayer, PlayerPosition.SecondPlayer);

            roundState = new MoreThanTwoCardsLeftRoundState(gameRound);
            testCard = new Card(CardSuit.Diamond, CardType.Jack);
            trumpCard = new Card(CardSuit.Club, CardType.Ace);
            action = new PlayerAction(PlayerActionType.PlayCard, testCard, Announce.Twenty);
            context = new PlayerTurnContext(roundState, trumpCard, 20);

            playerCards = new List<Card>();
            playerCards.Add(testCard);
            playerCards.Add(new Card(CardSuit.Heart, CardType.Jack));
            playerCards.Add(new Card(CardSuit.Spade, CardType.King));
            playerCards.Add(new Card(CardSuit.Spade, CardType.Queen));
            playerCards.Add(new Card(CardSuit.Club, CardType.Nine));
            playerCards.Add(new Card(CardSuit.Spade, CardType.Ten));
        }

        [Test]
        public void IsValidShouldReturnFalseWhenPlayerIsTryingToPlayInvalidCard()
        {
            playerCards.RemoveAt(0);
            bool isMoveValid = validator.IsValid(action, context, playerCards);

            Assert.IsFalse(isMoveValid);
        }

        [Test]
        public void IsValidShouldReturnTruePlayerIsTryingToPlayValidCard()
        {
            bool isMoveValid = validator.IsValid(action, context, playerCards);

            Assert.IsTrue(isMoveValid);
        }

        [Test]
        public void IsValidShouldChangeTheAnnounceToNoneIfThereIsAnnounceAndValidCards()
        {
            validator.IsValid(action, context, playerCards);
            Announce announceResult = action.Announce;

            Assert.AreEqual(Announce.None, announceResult);
        }
    }
}

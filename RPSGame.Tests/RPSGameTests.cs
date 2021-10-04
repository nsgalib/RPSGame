using System;
using GameRPS.Library.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPSGame.Library.Enums;
using RPSGame.Library.Models;

namespace RPSGame.Tests
{
	[TestClass]
	public class RPSGameTests
	{
		[TestMethod]
		public void TestMethod1()
		{
		}

		[TestMethod]
		[ExpectedException(typeof(UndefinedPlayer))]
		public void UndefindedPlayers()
		{
			IGame game = new Game(null, null);
		}

		[TestMethod]
		public void PaperBeatRock()
		{
			IGame game = new Game(new ComputerPlayer(), new ComputerPlayer());
			Result gameResult = game.DeclareWinner(Move.Paper, Move.Rock);
			Assert.IsTrue(gameResult == Result.Player1Wins, "Paper should win against rock");
		}

		[TestMethod]
		public void RockBeatScissors()
		{
			IGame game = new Game(new ComputerPlayer(), new ComputerPlayer());
			Result gameResult = game.DeclareWinner(Move.Rock, Move.Scissors);
			Assert.IsTrue(gameResult == Result.Player1Wins, "Rock should win against Scissors");
		}

		[TestMethod]
		public void ScissorsBeatPaper()
		{
			IGame game = new Game(new ComputerPlayer(), new ComputerPlayer());
			Result gameResult = game.DeclareWinner(Move.Scissors, Move.Paper);
			Assert.IsTrue(gameResult == Result.Player1Wins, "Scissors should win against paper");
		}

	}
}

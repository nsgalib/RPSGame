using RPSGame.Library.Enums;
using RPSGame.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameRPS.Library.Models
{
	public class Game : IGame
	{
		public IPlayer Player1 { get; } // => throw new NotImplementedException();

		public IPlayer Player2 { get; } // => throw new NotImplementedException();

		public Game(IPlayer player1, IPlayer player2)
		{
			if ((player1 == null) || (player2 == null))
			{
				throw new ApplicationException("Players cannot be null");
			}

			if ((player1 is HumanPlayer) && (player2 is HumanPlayer))
			{
				throw new ApplicationException("One player must be computer.");
			}

			Player1 = player1;
			Player2 = player2;

			if (string.IsNullOrEmpty(Player1.PlayerName))
			{
				Player1.PlayerName = "Player1";
			}

			if (string.IsNullOrEmpty(Player2.PlayerName))
			{
				Player1.PlayerName = "Player2";
			}
		}

		public Result DeclareWinner()
		{
			return DeclareWinner(Player1.Move, Player2.Move);
		}

		public Result DeclareWinner(Move p1Move, Move p2Move)
		{
			Result result = Result.Draw;

			if ((p1Move == Move.Paper && p2Move == Move.Rock) ||
				(p1Move == Move.Rock && p2Move == Move.Scissors) ||
				(p1Move == Move.Scissors && p2Move == Move.Paper))
			{
				result = Result.Player1Wins;
			}

			if ((p1Move == Move.Rock && p2Move == Move.Paper) ||
			   (p1Move == Move.Scissors && p2Move == Move.Rock) ||
			   (p1Move == Move.Paper && p2Move == Move.Scissors))
			{
				result = Result.Player2Wins;
			}

			return result;
		}
	}
}


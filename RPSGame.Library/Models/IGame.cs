using RPSGame.Library.Enums;
using RPSGame.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameRPS.Library.Models
{
	public interface IGame
	{
		Result DeclareWinner();
		Result DeclareWinner(Move p1Move, Move p2Move);
		IPlayer Player1 { get; }
		IPlayer Player2 { get; }
	}
}


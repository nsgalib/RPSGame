using RPSGame.Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPSGame.Library.Models
{
	public class ComputerPlayer : Player, IPlayer
	{
		static Array values = Enum.GetValues(typeof(Move));

		static Random random = new Random();

		public ComputerPlayer()
		{
			this.GetMove();
		}


		public Move GetMove()
		{
			Move randomMove;

			lock (random)
			{
				randomMove = (Move)values.GetValue(random.Next(values.Length));
			}

			Move = randomMove;
			return randomMove;
		}
	}
}

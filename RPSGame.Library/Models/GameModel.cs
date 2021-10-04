using RPSGame.Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPSGame.Library.Models
{
	public class GameModel
	{
		public PlayerMoveOptions PlayerOneMove { get; set; }
		public PlayerMoveOptions PlayerTwoMove { get; set; }
		public string Result { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RPSGame.Library.Models
{
	public interface IPlayer
	{
		string PlayerName { get; set; }
		Enums.Move Move { get; set; }
	}
}

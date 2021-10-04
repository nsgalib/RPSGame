using GameRPS.Library.Models;
using RPSGame.Library.Enums;
using RPSGame.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RPSGame.Site.Controllers
{
	public class GameController : Controller
	{
		[HttpGet]
		public ActionResult Index()
		{
			try
			{
				GameModel gameModel = new GameModel();
				gameModel.Result = string.Empty;
				return View(gameModel);
			}
			catch(Exception ex)
			{
				throw;
			}
			
		}

		[HttpPost]
		public ActionResult Index(GameModel gameModel)
		{
			gameModel.Result = string.Empty;
			IPlayer player1 = null;
			IPlayer player2 = null;


			// Player1 play
			if (gameModel.PlayerOneMove == PlayerMoveOptions.Computer)
			{
				player1 = new ComputerPlayer();
			}
			else
			{
				player1 = new HumanPlayer();

				switch (gameModel.PlayerOneMove)
				{
					case PlayerMoveOptions.Rock:
						player1.Move = Move.Rock;
						break;
					case PlayerMoveOptions.Paper:
						player1.Move = Move.Paper;
						break;
					case PlayerMoveOptions.Scissors:
						player1.Move = Move.Scissors;
						break;

				}
			}


			// Player2 play
			if (gameModel.PlayerTwoMove == PlayerMoveOptions.Computer)
			{
				player2 = new ComputerPlayer();
			}
			else
			{
				throw new ApplicationException();
			}


			IGame game = new Game(player1, player2);
			Result gameResult = game.DeclareWinner();

			string playersMoves = " ( Player1: " + player1.Move.ToString() + " / Player2: " + player2.Move.ToString() + ")";

			switch (gameResult)
			{
				case Result.Draw:
					gameModel.Result = "Draw " + playersMoves;
					break;
				case Result.Player1Wins:
					gameModel.Result = "Player 1 has won " + playersMoves;
					break;
				case Result.Player2Wins:
					gameModel.Result = "Player 2 has won " + playersMoves;
					break;
			}

			return View(gameModel);
		}



		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}
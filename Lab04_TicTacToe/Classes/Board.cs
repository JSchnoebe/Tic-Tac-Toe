using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};


		public void DisplayBoard()
		{
			for (int col = 0; col < GameBoard.GetLength(0); col++) {
				for (int row = 0; row < GameBoard.GetLength(0); row++)
                {
					string gb = GameBoard[col, row];
					Console.Write($"|{gb}|");
                }
				Console.WriteLine();
			}
		}
	}
}

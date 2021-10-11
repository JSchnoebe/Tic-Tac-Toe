using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            

            StartGame();

            
        }

        static void StartGame()
        {
            Board board = new Board();

            Console.WriteLine("Player1 what is your name?");

            string input1 = Console.ReadLine();

            Console.WriteLine("Player2 what is your name?");

            string input2 = Console.ReadLine();

            Player player1 = new Player();
            player1.Marker = "x";
            player1.Name = input1;
            player1.IsTurn = true;

            Player player2 = new Player();
            player2.Marker = "o";
            player2.Name = input2;

            Game game = new Game(player1, player2);

            board.DisplayBoard();


            game.Play();

            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
        }


    }
}

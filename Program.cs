using System;

namespace TikTacToeGame
{
    public class TikTacToeGame
    {
        static void Main(string[] args)
        {
            char[] board = startGame();
            char option = chooseLetter();
            displayBoard(board);

        }
        public static char[] startGame()
        {
            char[] board = new char[10];
            for (int i = 0; i < 10; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
        public static char chooseLetter()
        {
            Console.WriteLine("Enter the text you want to use : X or 0");
            char option = Convert.ToChar(Console.ReadLine());
            return option;

        }
        public static void displayBoard(char[] board)
        {
            Console.WriteLine("\n" + board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("__________");
            Console.WriteLine("\n" + board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("__________");
            Console.WriteLine("\n" + board[7] + " | " + board[8] + " | " + board[9]);
        }
    }
}
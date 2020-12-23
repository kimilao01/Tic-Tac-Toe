using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Board set up//
            int[] board = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            //Print board//
            void printBoard()
            {
                for (int i = 0; i <= 6; i += 3)
                {
                    for (int i2 = 0; i2 < 3; i2++)
                    {
                        Console.Write(board[i + i2]);
                    }
                    Console.WriteLine();
                }
            }

            //Check win//
            void checkWin(int turn)
            {
                if (board[0] == board[1] && board[1] == board[2] && board[2] == turn)
                {
                    Console.WriteLine(turn + " Wins!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (board[3] == board[4] && board[4] == board[5] && board[5] == turn)
                {
                    Console.WriteLine(turn + " Wins!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (board[6] == board[7] && board[7] == board[8] && board[8] == turn)
                {
                    Console.WriteLine(turn + " Wins!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (board[0] == board[3] && board[3] == board[6] && board[6] == turn)
                {
                    Console.WriteLine(turn + " Wins!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (board[1] == board[4] && board[4] == board[7] && board[7] == turn)
                {
                    Console.WriteLine(turn + " Wins!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (board[2] == board[5] && board[5] == board[8] && board[8] == turn)
                {
                    Console.WriteLine(turn + " Wins!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (board[0] == board[4] && board[4] == board[8] && board[8] == turn)
                {
                    Console.WriteLine(turn + " Wins!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (board[2] == board[4] && board[4] == board[6] && board[6] == turn)
                {
                    Console.WriteLine(turn + " Wins!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

            //The game//
            void game()
            {
                int turn = 1;

                printBoard();
                Console.WriteLine();

                while (board.Contains(0))
                {
                    Console.Write(turn + ", Your Move: ");
                    string playerInput = Console.ReadLine();
                    Console.WriteLine();
                    int playerMove = 0;

                    //Check if input is valid or not//
                    if (Regex.IsMatch(playerInput, @"\d") && playerInput.Length == 1 && playerInput != "0")
                    {
                        playerMove = Convert.ToInt32(playerInput);
                    }
                    else
                    {
                        Console.WriteLine("Error: Only Numbers From 1~9");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    //Check if input is filled or not//
                    if (board[playerMove - 1] != 0)
                    {
                        Console.WriteLine("Error: Space Filled Already");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    //Apply move//
                    board[playerMove - 1] = turn;

                    //Print board//
                    printBoard();
                    Console.WriteLine();

                    //Check win//
                    checkWin(turn);

                    if (turn == 1)
                    {
                        turn = 2;
                    }
                    else
                    {
                        turn = 1;
                    }
                }
                Console.WriteLine("Draw!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            game();
        }
    }
}

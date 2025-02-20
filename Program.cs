// libraries 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

//class goes here
internal class Program 
{
 //global variables, list, arrays, etc. 

    //create 2d array here, 3 x 3 matrix
    private static int [][] threeByThreeBoard = new int[][] {
            new int [] { 0, 0,1 },
            new int [] { 0, 1,0 },
            new int [] { 1, 0,0 }
        };
private static int rows = threeByThreeBoard.Length;
private static int columns = threeByThreeBoard[0].Length;

    private static void Main (string[] args)
    {
        //call your methods
        //checks to see if the return value of winchecker 
        if (WinChecker(threeByThreeBoard) == 0){
            Console.WriteLine("There are no winners");
        }
        else 
        {
            Console.WriteLine("Winner: Player " + WinChecker(threeByThreeBoard));
        }
    }
        //define your methods
         public static int WinChecker(int [][] board)
        {
            int horizontalResult = HorizontalWinner(board);
            int verticalResult = VerticalWinner(board);
            int diagonalResult = DiagonalWinner(board);
            int diagonalOtherWayResult = DiagonalOtherWayWinner(board);
        
            if (horizontalResult != 0)
                return horizontalResult;
            else if (verticalResult != 0)
                return verticalResult;
            else if (diagonalResult != 0)
                return diagonalResult;
            else if (diagonalOtherWayResult !=0)
                return diagonalOtherWayResult;
            else
                return 0;
        }

        //method for horizontal winner 
    public static int HorizontalWinner(int[][] board)
    {
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                if (c + 2 < columns                 && 
                    board[r][c] != 0                &&
                    board[r][c] == board[r][c + 1]  &&
                    board[r][c] == board[r][c + 2]
                    )
                {
                    return board[r][c];
                }
            }
        }
        return 0;
    }
        
        
    public static int VerticalWinner(int[][] board)
    {
        for (int c = 0; c < columns; c++)
        {
            for (int r = 0; r < rows; r++)
            {
                if (r + 2 < rows                    && 
                    board[r][c] != 0                &&
                    board[r][c] == board[r + 1][c]  &&
                    board[r][c] == board[r + 2][c]
                    )
                {
                    return board[r][c];
                }
            }
        }
        return 0;
    }
        public static int DiagonalWinner(int[][] board)
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (r + 2 < rows && c + 2 < columns     && 
                        board[r][c] != 0                    &&
                        board[r][c] == board[r + 1][c + 1]  &&
                        board[r][c] == board[r + 2][c + 2])
                    {
                        return board[r][c];
                    }
                }
            }
            return 0;
        }
            
        public static int DiagonalOtherWayWinner(int[][] board)
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (r + 2 < rows && c - 2 >= 0 &&
                        board[r][c] != 0 &&
                        board[r][c] == board[r + 1][c - 1] &&
                        board[r][c] == board[r + 2][c - 2])
                        {
                            return board[r][c];
                        }
                }
            }
        return 0;
        }    
}

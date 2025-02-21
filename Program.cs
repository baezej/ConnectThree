/*You have the starter code and you have 4 TODOS.
Prepare to answer the questions
1.Describe the purpose of a computing innovation.
2.Explain how the use of data abstraction manages complexity in program code. 
3.Identify inputs and corresponding expected outputs or behaviors that can be used to check the correctness of an algorithm or program. 
4.Explain how the use of data abstraction manages complexity in program code.

*/
// libraries 
using System;
using System.Collections;
using System.Collections.Generic;


//class goes here
internal class Program 
{
 //global variables, list, arrays, etc. 

    //create 2d array here, 3 x 3 matrix
    private static int [][] threeByThreeBoard = new int[][] {
            new int [] { 0, 0, 0 },
            new int [] { 0, 0,0 },
            new int [] { 0, 0,0 }
        };
//Need to create static because this will be called inside of main
 //Changed from the static 3 assigned for each variable row and column and changed ot the length of each array.
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
            //creates local variable that stores the return value
            int horizontalResult = HorizontalWinner(board);
            int verticalResult = VerticalWinner(board);
            int diagonalResult = DiagonalWinner(board);
            int diagonalOtherWayResult = DiagonalOtherWayWinner(board);
        
           //sets up condition checking the return values of each method... 
          //TODO: CREATE A DIAGONAL CONDITION CHECKER 
           if (horizontalResult != 0)
                return horizontalResult;
            else if (verticalResult != 0)
                return verticalResult;
            else
                return 0;
        }

        //method for horizontal winner, static because it'll be called in the main method
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
        
   //TODO: USING THE HORIZONTALWINNER METHOD, CREATE THE VERTICAL WINNER METHOD
    public static int VerticalWinner(int[][] board)
    {
       
        return 0;
    }

   //TODO: CREATE THE DIAGONALWINNER METHOD AND THE PROPER PARAMETER

   //TODO: DO YOU HAVE TO CREATE ANY OTHER METHODS?
}

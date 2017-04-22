using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApplication1
{
    class GameOfLife
    {
        Board board;

        public GameOfLife(int typeOfOscillator)
        {
            board = new Board((Board.Oscillators)typeOfOscillator);                  
        }


        public void Iterate()
        {
            UpdateBoard();
            Console.Clear();
            PrintBoard();
        }

        private void UpdateBoard()
        {
            int[,] tempBoard = new int[board.getBoardLength(), board.getBoardHeight()];
            for (int i = 0; i < board.getBoardLength(); i++) 
            {
                for (int j = 0; j < board.getBoardHeight(); j++)
                {
                    tempBoard[i, j] = CheckNeighbors(i, j);
                }
            }
            board = new Board(tempBoard);
        }

        private int CheckNeighbors(int i, int j)
        {
            int lengthLowerBound = i > 0 ? i -1 : 0;
            int lengthUpperBound = i < (board.getBoardLength()-1) ? i + 1 : i;
            int heightLowerBound = j > 0 ? j -1 : 0;
            int heightUpperBound = j < (board.getBoardHeight()-1) ? j+1 : j;
  
            int liveNeighborCount = GetNeighborCount(lengthLowerBound, lengthUpperBound, heightLowerBound, heightUpperBound);
            liveNeighborCount -= board.getCellValue(i, j);

            return DetermineStatus(i, j, liveNeighborCount);
        }

        private int GetNeighborCount(int llb, int lub, int hlb, int hub)
        {
            int value = 0;
            for (int k = llb; k <= lub; k++)
            {
                for (int l = hlb; l <= hub; l++)
                {
                    value += board.getCellValue(k, l);
                }
            }
            return value;
        }

        private int DetermineStatus(int i, int j, int liveNeighborCount)
        {
            if (board.getCellValue(i, j) == 0)         
                return liveNeighborCount == 3 ? 1 : 0;          
            else
                return (liveNeighborCount < 2 || liveNeighborCount > 3) ? 0 : 1;
        }

        private void PrintBoard()
        {
            for (int i = 0; i < board.getBoardLength(); i++)
            {
                for (int j = 0; j < board.getBoardHeight(); j++)
                {
                    var cellValue = board.getCellValue(i, j) == 1 ? "\u25A0" : "\u2014";
                    Console.Write($" {cellValue} ");
                }
                Console.WriteLine("");
            }
        }
    }
}

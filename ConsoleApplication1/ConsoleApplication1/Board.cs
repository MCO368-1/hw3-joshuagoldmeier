using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Board
    {
        private int[,] board = new int[20, 20];
        private Oscillators theOscillator;
        public enum Oscillators
        {
            Default = 0, Blinker = 1, Toad = 2, Beacon = 3, Pulsar = 4, Pentadeclathon = 5
        }

        public Board(Oscillators oscillator)
        {
            this.theOscillator = oscillator;
            createBoard();
        }

        public Board(int[,] board)
        {
            this.board = board;
        }

        private void createBoard()
        {
            switch (theOscillator)
            {
                case Oscillators.Blinker:
                    blinker();
                    break;
                case Oscillators.Toad:
                    toad();
                    break;
                case Oscillators.Beacon:
                    beacon();
                    break;
                case Oscillators.Pulsar:
                    pulsar();
                    break;
                case Oscillators.Pentadeclathon:
                    pentadecathlon();
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

        public int getBoardLength()
        {
            return this.board.GetLength(0);
        }

        public int getBoardHeight()
        {
            return this.board.GetLength(1);
        }

        public int getCellValue(int i, int j)
        {

            return this.board[i, j];
        }

        private void blinker()
        {
            board[9, 9] = 1;
            board[9, 10] = 1;
            board[9, 11] = 1;
        }
        private void toad()
        {
            board[9, 9] = 1;
            board[9, 10] = 1;
            board[9, 11] = 1;
            board[10, 8] = 1;
            board[10, 9] = 1;
            board[10, 10] = 1;
        }

        private void beacon()
        {
            board[9, 8] = 1;
            board[9, 9] = 1;
            board[10, 8] = 1;
            board[10, 9] = 1;
            board[11, 10] = 1;
            board[11, 11] = 1;
            board[12, 10] = 1;
            board[12, 11] = 1;
        }

        private void pulsar()
        {
            board[4, 5] = 1;
            board[4, 6] = 1;
            board[4, 7] = 1;
            board[4, 11] = 1;
            board[4, 12] = 1;
            board[4, 13] = 1;
            board[6, 3] = 1;
            board[6, 8] = 1;
            board[6, 10] = 1;
            board[6, 15] = 1;
            board[7, 3] = 1;
            board[7, 8] = 1;
            board[7, 10] = 1;
            board[7, 15] = 1;
            board[8, 3] = 1;
            board[8, 8] = 1;
            board[8, 10] = 1;
            board[8, 15] = 1;
            board[9, 5] = 1;
            board[9, 6] = 1;
            board[9, 7] = 1;
            board[9, 11] = 1;
            board[9, 12] = 1;
            board[9, 13] = 1;
            board[11, 5] = 1;
            board[11, 6] = 1;
            board[11, 7] = 1;
            board[11, 11] = 1;
            board[11, 12] = 1;
            board[11, 13] = 1;
            board[12, 3] = 1;
            board[12, 8] = 1;
            board[12, 10] = 1;
            board[12, 15] = 1;
            board[13, 3] = 1;
            board[13, 8] = 1;
            board[13, 10] = 1;
            board[13, 15] = 1;
            board[14, 3] = 1;
            board[14, 8] = 1;
            board[14, 10] = 1;
            board[14, 15] = 1;
            board[16, 5] = 1;
            board[16, 6] = 1;
            board[16, 7] = 1;
            board[16, 11] = 1;
            board[16, 12] = 1;
            board[16, 13] = 1;
        }

        private void pentadecathlon()
        {
            board[8, 7] = 1;
            board[8, 12] = 1;
            board[9, 5] = 1;
            board[9, 6] = 1;
            board[9, 8] = 1;
            board[9, 9] = 1;
            board[9, 10] = 1;
            board[9, 11] = 1;
            board[9, 13] = 1;
            board[9, 14] = 1;
            board[10, 7] = 1;
            board[10, 12] = 1;
        }

    }
}

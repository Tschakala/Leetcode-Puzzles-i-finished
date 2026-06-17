using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Solver
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static void SolveSudoku(char[][] board)
        {
            List<char> list = new List<char>();
            int num;
            bool contain;

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    if (board[i][j] == '.')
                    {
                        num = 1;
                        contain = false;

                        while (!contain)
                        {
                            list.Clear();
                            list.AddRange(board[i]);
                            if (list.Contains(char.Parse(num.ToString())))
                            {
                                contain = true;
                                num++;
                            }
                            else
                            {
                                board[i][j] = char.Parse(num.ToString());
                            }
                        }
                    }
                }
            }


        }
    }
}

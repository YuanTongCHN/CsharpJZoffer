using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer12
{
    public class Solution
    {
        public bool Exist(char[][] board, string word)
        {
            for (int y = 0; y < board.Length; y++)
            {
                for (int x = 0; x < board[0].Length; x++)
                {
                    if (OneExist(board, y, x, word, 0))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool OneExist(char[][] board, int y, int x, string word, int wordIndex)
        {
            if (x < 0 || y < 0 || x >= board[0].Length || y >= board.Length)
            {
                return false;
            }
            char temp = word[wordIndex];
            if (temp != board[y][x])
            {
                return false;
            }
            if (wordIndex == word.Length - 1)
            {
                return true;
            }
            board[y][x] = '-';
            bool result = OneExist(board, y + 1, x, word, wordIndex + 1) || OneExist(board, y - 1, x, word, wordIndex + 1) || OneExist(board, y, x + 1, word, wordIndex + 1) || OneExist(board, y, x - 1, word, wordIndex + 1);
            board[y][x] = temp;
            return result;
        }
    }
}

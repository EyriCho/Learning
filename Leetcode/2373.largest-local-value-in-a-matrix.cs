/*
 * @lc app=leetcode id=2373 lang=csharp
 *
 * [2373] Largest Local Values in a Matrix 
 */

// @lc code=start
public class Solution {
    public int[][] LargestLocal(int[][] grid) {
        int n = grid.Length - 2;
        int[][] result = new int[n][];
        for (int i = 0; i < n; i++)
        {
            result[i] = new int[n];
        }

        (int, int)[] array = new (int, int)[grid.Length + 1];
        int length = 0;

        void Add(int num, int pos)
        {
            int i = length++,
                p = 0;
            array[i] = (num, pos);
            (int, int) temp = (0, 0);
            while (i > 0)
            {
                p = (i - 1) >> 1;
                if (array[p].Item1 >= array[i].Item1)
                {
                    return;
                }

                temp = array[p];
                array[p] = array[i];
                array[i] = temp;
                i = p;
            }
        }

        void Pop()
        {
            int i = 0,
                l = 0,
                r = 0;
            (int, int) temp = (0, 0);
            array[0] = array[--length];
            while (true)
            {
                l = i * 2 + 1;
                r = i * 2 + 2;

                if (l >= length)
                {
                    return;
                }

                if (array[l].Item1 > array[i].Item1 ||
                    (r < length && array[r].Item1 > array[i].Item1))
                {
                    if (r >= length ||
                        array[l].Item1 >= array[r].Item1)
                    {
                        temp = array[l];
                        array[l] = array[i];
                        array[i] = temp;
                        i = l;
                    }
                    else
                    {
                        temp = array[r];
                        array[r] = array[i];
                        array[i] = temp;
                        i = r;
                    }
                }
                else
                {
                    return;
                }
            }
        }

        int max = 0,
            top = 0,
            bottom = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            length = 0;
            for (int j = 0; j < grid.Length; j++)
            {
                Add(grid[i][j], j);
                while (length > 0 &&
                    array[0].Item2 < j - 2)
                {
                    Pop();
                }

                if (j >= 2)
                {
                    max = array[0].Item1;
                    top = Math.Max(0, i - 2);
                    bottom = Math.Min(grid.Length - 3, i);
                    while (top <= bottom)
                    {
                        result[top][j - 2] = Math.Max(result[top][j - 2], max);
                        top++;
                    }
                }
            }
        }

        return result;
    }
}
// @lc code=end


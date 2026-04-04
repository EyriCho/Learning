/*
 * @lc app=leetcode id=1536 lang=csharp
 *
 * [1536] Minimum Swaps to Arrange a Binary Grid
 */

// @lc code=start
public class Solution {
    public int MinSwaps(int[][] grid) {
        int count = 0;
        int[] array = new int[grid.Length];
        for (int i = 0; i < grid.Length; i++)
        {
            count = 0;
            for (int j = grid[i].Length - 1; j >= 0; j--)
            {
                if (grid[i][j] != 0)
                {
                    break;
                }
                count++;
            }

            array[i] = count;
        }

        int result = 0,
            needed = 0,
            current = 0;
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            needed = array.Length - 1 - i;
            if (array[i] >= needed)
            {
                continue;
            }

            j = i + 1;
            current = array[i];
            for (; j < array.Length; j++)
            {
                if (array[j] >= needed)
                {
                    break;
                }

                current ^= array[j];
                array[j] ^= current;
                current ^= array[j];
                result++;
            }

            if (j == array.Length)
            {
                return -1;
            }

            array[j] = current;
            result++;
        }

        return result;
    }
}
// @lc code=end


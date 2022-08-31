/*
 * @lc app=leetcode id=1329 lang=csharp
 *
 * [1329] Sort the Matrix Diagonally
 */

// @lc code=start
public class Solution {
    public int[][] DiagonalSort(int[][] mat) {
        void Sort(int x, int y)
        {
            int[] array = new int[mat.Length];
            int i = 0;
            while (x < mat.Length && y < mat[0].Length)
            {
                array[i++] = mat[x++][y++];
            }
            
            Array.Sort(array);
            
            i = mat.Length - 1;
            while (x > 0 && y > 0)
            {
                mat[--x][--y] = array[i--];
            }
        }

        for (int i = 0; i < mat.Length; i++)
        {
            Sort(i, 0);
        }
        
        for (int i = 1; i < mat[0].Length; i++)
        {
            Sort(0, i);
        }
        
        return mat;
    }
}
// @lc code=end


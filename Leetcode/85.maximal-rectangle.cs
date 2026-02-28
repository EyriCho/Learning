/*
 * @lc app=leetcode id=85 lang=csharp
 *
 * [85] Maximal Rectangle
 */

// @lc code=start
public class Solution {
    public int MaximalRectangle(char[][] matrix) {
        int result = 0;
        int[] heights = new int[matrix[0].Length + 1];

        int MaximalRectangleForRow()
        {
            Stack<int> stack = new ();
            int l = 0, r = 0,
                h = 0, w = 0,
                max = 0;

            for (; r <= heights.Length; r++)
            {
                h = r == heights.Length ? 0 : heights[r];
                while (stack.Count > 0 &&
                    heights[stack.Peek()] >= h)
                {
                    l = stack.Pop();
                    w = stack.Count == 0 ? r : (r - stack.Peek() - 1);
                    max = Math.Max(max, heights[l] * w);
                }
                stack.Push(r);
            }
            return max;
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                heights[j] = matrix[i][j] == '0' ? 0 : (heights[j] + 1);
            }

            result = Math.Max(result, MaximalRectangleForRow());
        }
        return result;
    }
}
// @lc code=end


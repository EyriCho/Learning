/*
 * @lc app=leetcode id=85 lang=csharp
 *
 * [85] Maximal Rectangle
 */

// @lc code=start
public class Solution {
    public int MaximalRectangle(char[][] matrix) {
        int result = 0;
        var heights = new int[matrix[0].Length];
        
        int getMaxRectangle()
        {
            int r = 0,
                cur = 0;
            Stack<int> stack = new ();
            
            for (int i = 0; i < matrix[0].Length; i++)
            {
                while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
                {
                    cur = stack.Pop();
                    r = Math.Max(r, heights[cur] * (stack.Count == 0 ? i : (i - stack.Peek() - 1)));
                }
                stack.Push(i);
            }
            
            while(stack.Count > 0)
            {
                cur = stack.Pop();
                r = Math.Max(r, heights[cur] * (heights.Length - (stack.Count == 0 ? -1 : stack.Peek()) - 1));
            }
            
            return r;
        }
        
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == '1')
                {
                    heights[j]++;
                }
                else
                {
                    heights[j] = 0;
                }
            }
            
            result = Math.Max(result, getMaxRectangle());
        }
        
        return result;
    }
}
// @lc code=end


/*
 * @lc app=leetcode id=85 lang=csharp
 *
 * [85] Maximal Rectangle
 */

// @lc code=start
public class Solution {
    public int MaximalRectangle(char[][] matrix) {
        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            return 0;
        
        int result = 0;
        var height = new int[matrix[0].Length];
        
        int getMaxRectangle()
        {
            int r = 0;
            
            var stack = new Stack<int>();
            
            for (int i = 0; i < matrix[0].Length; i++)
            {
                while (stack.Count > 0 && height[stack.Peek()] >= height[i])
                {
                    var cur = stack.Pop();
                    r = Math.Max(r, height[cur] * (stack.Count == 0 ? i : (i - stack.Peek() - 1)));
                }
                stack.Push(i);
            }
            
            while(stack.Count > 0)
            {
                    var cur = stack.Pop();
                    r = Math.Max(r, height[cur] * (height.Length - (stack.Count == 0 ? -1 : stack.Peek()) - 1));
            }
            
            return r;
        }
        
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == '1')
                    height[j]++;
                else
                    height[j] = 0;
            }
            
            result = Math.Max(result, getMaxRectangle());
        }
        
        return result;
    }
}
// @lc code=end


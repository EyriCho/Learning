/*
 * @lc app=leetcode id=84 lang=csharp
 *
 * [84] Largest Rectangle in Histogram
 */

// @lc code=start
public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int result = 0;
        
        var stack = new Stack<int>();
        
        for (int i = 0; i < heights.Length; i++)
        {
            while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
            {
                var cur = stack.Pop();
                result = Math.Max(result, heights[cur] * (stack.Count == 0 ? i : (i - stack.Peek() - 1)));
            }
            stack.Push(i);
        }
        
        while (stack.Count > 0)
        {
            var cur = stack.Pop();
            result = Math.Max(result, heights[cur] * (heights.Length - (stack.Count == 0 ? -1 : stack.Peek()) - 1));
        }
        
        return result;
    }
}
// @lc code=end


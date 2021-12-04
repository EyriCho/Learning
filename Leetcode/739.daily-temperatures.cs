/*
 * @lc app=leetcode id=739 lang=csharp
 *
 * [739] Daily Temperatures
 */

// @lc code=start
public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var result = new int[temperatures.Length];
        
        var stack = new Stack<(int, int)>();
        stack.Push((temperatures[0], 0));
        
        for (int i = 1; i < temperatures.Length; i++)
        {
            while (stack.Count > 0 && temperatures[i] > stack.Peek().Item1)
            {
                var (t, j) = stack.Pop();
                
                result[j] = i - j;
            }
            
            stack.Push((temperatures[i], i));
        }
        
        return result;
    }
}
// @lc code=end


/*
 * @lc app=leetcode id=739 lang=csharp
 *
 * [739] Daily Temperatures
 */

// @lc code=start
public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var result = new int[temperatures.Length];

        var stack = new Stack<int>();
        stack.Push(0);

        for (int i = 1; i < temperatures.Length; i++)
        {
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
            {
                var p = stack.Pop();
                result[p] = i - p;
            }

            stack.Push(i);
        }

        return result;
    }
}
// @lc code=end


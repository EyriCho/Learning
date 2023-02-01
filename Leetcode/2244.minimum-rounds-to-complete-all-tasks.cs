/*
 * @lc app=leetcode id=2244 lang=csharp
 *
 * [2244] Minimum Rounds to Complete All Tasks
 */

// @lc code=start
public class Solution {
    public int MinimumRounds(int[] tasks) {
        var dict = new Dictionary<int, int>();
        foreach (var task in tasks)
        {
            if (!dict.TryGetValue(task, out int count))
            {
                count = 0;
            }
            dict[task] = ++count;
        }

        var result = 0;
        foreach (var kv in dict)
        {
            if (kv.Value == 1)
            {
                return -1;
            }
            else 
            {
                result += kv.Value / 3 + (kv.Value % 3 == 0 ? 0 : 1);
            }
        }

        return result;
    }
}
// @lc code=end


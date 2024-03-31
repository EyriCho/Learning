/*
 * @lc app=leetcode id=3005 lang=csharp
 *
 * [3005] Count Elements With Maximum Frequency
 */

// @lc code=start
public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        Dictionary<int, int> dict = new();
        foreach (int num in nums)
        {
            dict.TryGetValue(num, out int c);
            dict[num] = c + 1;
        }

        int max = 0,
            result = 0;
        foreach (KeyValuePair<int, int> kv in dict)
        {
            if (kv.Value == max)
            {
                result += kv.Value;
            }
            else if (kv.Value > max)
            {
                max = kv.Value;
                result = kv.Value;
            }
        }

        return result;
    }
}
// @lc code=end


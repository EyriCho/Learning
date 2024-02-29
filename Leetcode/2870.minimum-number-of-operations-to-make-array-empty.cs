/*
 * @lc app=leetcode id=2870 lang=csharp
 *
 * [2870] Minimum Number of Operations to Make Array Empty
 */

// @lc code=start
public class Solution {
    public int MinOperations(int[] nums) {
        Dictionary<int, int> dict = new ();

        foreach (int num in nums)
        {
            if (!dict.TryGetValue(num, out int count))
            {
                count = 0;
            }
            dict[num] = count + 1;
        }

        int result = 0,
            left = 0;
        foreach (KeyValuePair<int, int> kv in dict)
        {
            if (kv.Value == 1)
            {
                return -1;
            }

            result += kv.Value / 3;
            left = kv.Value % 3;
            if (left != 0)
            {
                result++;
            }
        }

        return result;
    }
}
// @lc code=end


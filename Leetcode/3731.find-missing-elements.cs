/*
 * @lc app=leetcode id=3731 lang=csharp
 *
 * [3731] Find Missing Elements
 */

// @lc code=start
public class Solution {
    public IList<int> FindMissingElements(int[] nums) {
        bool[] found = new bool[101];
        int min = 101, max = 0;
        List<int> result = new ();
        foreach (int num in nums)
        {
            found[num] = true;
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        for (int i = min; i <= max; i++)
        {
            if (found[i])
            {
                continue;
            }

            result.Add(i);
        }

        return result;
    }
}
// @lc code=end


/*
 * @lc app=leetcode id=2200 lang=csharp
 *
 * [2200] Find All K-Distant Indics in an Array
 */

// @lc code=start
public class Solution {
    public IList<int> FindKDistantIndices(int[] nums, int key, int k) {
        List<int> list = new ();
        int s = 0, e = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != key)
            {
                continue;
            }
            
            s = Math.Max(0, i - k);
            e = Math.Min(i + k + 1, nums.Length);
            if (list.Count > 0)
            {
                s = Math.Max(s, list[^1] + 1);
            }

            while (s < e)
            {
                list.Add(s++);
            }
        }

        return list;
    }
}
// @lc code=end


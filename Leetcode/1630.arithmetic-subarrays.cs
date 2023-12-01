/*
 * @lc app=leetcode id=1630 lang=csharp
 *
 * [1630] Arithmetic Subarrays
 */

// @lc code=start
public class Solution {
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r) {
        int[] temp = new int[nums.Length];
        List<bool> result = new(nums.Length);

        for (int i = 0; i < l.Length; i++)
        {
            int s = l[i],
                e = r[i];
            for (int j = s; j <= e; j++)
            {
                temp[j] = nums[j];
            }
            Array.Sort(temp, s, e - s + 1);

            int diff = temp[s + 1] - temp[s];

            bool isArithmetic = true;
            for (int j = s + 2; j <= e; j++)
            {
                if (temp[j] - temp[j - 1] != diff)
                {
                    isArithmetic = false;
                    break;
                }
            }

            result.Add(isArithmetic);
        }

        return result;
    }
}
// @lc code=end


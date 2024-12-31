/*
 * @lc app=leetcode id=2762 lang=csharp
 *
 * [2762] Continuous Subarrays
 */

// @lc code=start
public class Solution {
    public long ContinuousSubarrays(int[] nums) {
        long result = 0L;
        int l = 0,
            r = 0;

        LinkedList<int> min = new (),
            max = new ();

        while (r < nums.Length)
        {
            while (min.Count > 0 &&
                nums[min.Last()] >= nums[r])
            {
                min.RemoveLast();
            }

            while (max.Count > 0 &&
                nums[max.Last()] <= nums[r])
            {
                max.RemoveLast();
            }

            min.AddLast(r);
            max.AddLast(r);
            
            while (nums[max.First()] - nums[min.First()] > 2)
            {
                l++;

                if (min.First() < l)
                {
                    min.RemoveFirst();
                }

                if (max.First() < l)
                {
                    max.RemoveFirst();
                }
            }

            result += r - l + 1;
            r++;
        }

        return result;
    }
}
// @lc code=end


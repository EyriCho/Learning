/*
 * @lc app=leetcode id=215 lang=csharp
 *
 * [215] Kth Largest Element in an Array
 */

// @lc code=start
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        int QuickFind(int l, int r)
        {
            if (l >= r)
            {
                return nums[r];
            }

            int m = l, temp = 0;
            for (int i = l + 1; i <= r; i++)
            {
                if (nums[i] > nums[l])
                {
                    m++;
                    temp = nums[m];
                    nums[m] = nums[i];
                    nums[i] = temp;
                }
            }

            temp = nums[m];
            nums[m] = nums[l];
            nums[l] = temp;

            if (m == k - 1)
            {
                return nums[m];
            }
            else if (m >= k)
            {
                return QuickFind(l, m - 1);
            }
            else
            {
                return QuickFind(m + 1, r);
            }
        }

        return QuickFind(0, nums.Length - 1);
    }
}
// @lc code=end


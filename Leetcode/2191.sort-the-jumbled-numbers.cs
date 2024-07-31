/*
 * @lc app=leetcode id=2191 lang=csharp
 *
 * [2191] Sort the Jumbled Numbers
 */

// @lc code=start
public class Solution {
    public int[] SortJumbled(int[] mapping, int[] nums) {
        (int, int)[] mapped = new (int, int)[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                mapped[i] = (mapping[0], 0);
                continue;
            }

            int num = nums[i],
                n = 0,
                mask = 1,
                left = 0;
            while (num > 0)
            {
                left = num % 10;
                n += mapping[left] * mask;
                mask *= 10;
                num /= 10;
            }

            mapped[i] = (n, nums[i]);
        }

        int l = 0,
            r = 0,
            m = 0,
            origin = 0,
            map = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            (map, origin) = mapped[i];
            l = 0;
            r = i;
            while (l < r)
            {
                m = (l + r) >> 1;
                if (map >= mapped[m].Item1)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }

            r = i;
            for (; r > l; r--)
            {
                mapped[r] = mapped[r - 1];
            }

            mapped[l] = (map, origin);
        }

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = mapped[i].Item2;
        }

        return nums;
    }
}
// @lc code=end


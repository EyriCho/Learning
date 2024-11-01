/*
 * @lc app=leetcode id=1497 lang=csharp
 *
 * [1497] Check If Array Pairs Are Divisible by k
 */

// @lc code=start
public class Solution {
    public bool CanArrange(int[] arr, int k) {
        int[] remains = new int[k];
        int r = 0,
            l = 1;

        foreach (int num in arr)
        {
            r = ((num % k) + k) % k;
            remains[r]++;
        }

        if (remains[0] % 2 != 0)
        {
            return false;
        }

        r = remains.Length - 1;
        while (l < r)
        {
            if (remains[l++] != remains[r--])
            {
                return false;
            }
        }

        if (l == r &&
            remains[l] % 2 != 0)
        {
            return false;
        }

        return true;
    }
}
// @lc code=end


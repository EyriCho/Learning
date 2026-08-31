/*
 * @lc app=leetcode id=1386 lang=csharp
 *
 * [1386] Cinema Seat Allocation
 */

// @lc code=start
public class Solution {
    public int MaxNumberOfFamilies(int n, int[][] reservedSeats) {
        Dictionary<int, int> dict = new ();
        foreach (int[] taken in reservedSeats)
        {
            if (taken[1] == 1 || taken[1] == 10)
            {
                continue;
            }

            if (!dict.TryGetValue(taken[0], out int mask))
            {
                mask = 0;
            }

            dict[taken[0]] = mask | (1 << taken[1]);
        }

        int result = n << 1,
            count = 0;
        bool left = false, 
            mid = false,
            right = false;
        foreach (KeyValuePair<int, int> kv in dict)
        {
            left = (kv.Value & 960) == 0;
            mid = (kv.Value & 240) == 0;
            right = (kv.Value & 60) == 0;
            
            if (left && right)
            {
                count = 2;
            }
            else if (left || mid || right)
            {
                count = 1;
            }
            else
            {
                count = 0;
            }

            result -= 2 - count;
        }

        return result;
    }
}
// @lc code=end


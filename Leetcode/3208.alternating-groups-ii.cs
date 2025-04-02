/*
 * @lc app=leetcode id=3208 lang=csharp
 *
 * [3208] Alternating Groups II
 */

// @lc code=start
public class Solution {
    public int NumberOfAlternatingGroups(int[] colors, int k) {
        int result = 0,
            contiguous = 1,
            last = colors.Length + k - 2;

        for (int i = 0; i < last; i++)
        {
            if (colors[i % colors.Length] == colors[(i + 1) % colors.Length])
            {
                contiguous = 1;
            }
            else
            {
                if (++contiguous >= k)
                {
                    result++;
                }
            }
        }

        return result;
    }
}
// @lc code=end


/*
 * @lc app=leetcode id=1051 lang=csharp
 *
 * [1051] Height Checker
 */

// @lc code=start
public class Solution {
    public int HeightChecker(int[] heights) {
        int[] counts = new int[101];
        foreach (int h in heights)
        {
            counts[h]++;
        }

        int current = 1,
            result = 0;
        foreach (int h in heights)
        {
            while (counts[current] == 0)
            {
                current++;
            }
            if (h != current)
            {
                result++;
            }
            counts[current]--;
        }

        return result;
    }
}
// @lc code=end


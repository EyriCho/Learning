/*
 * @lc app=leetcode id=2275 lang=csharp
 *
 * [2275] Largest Combination With Bitwise AND Greater Than Zero
 */

// @lc code=start
public class Solution {
    public int LargestCombination(int[] candidates) {
        int[] array = new int[32];

        int pos = 0,
            num = 0;
        foreach (int c in candidates)
        {
            num = c;
            pos = 0;
            while (num > 0)
            {
                array[pos] += num & 1;
                num >>= 1;
                pos++;
            }
        }

        num = 0;
        foreach (int count in array)
        {
            num = Math.Max(count, num);
        }
        
        return num;
    }
}
// @lc code=end


/*
 * @lc app=leetcode id=1894 lang=csharp
 *
 * [1894] Find the Student that Will Replace the Chalk
 */

// @lc code=start
public class Solution {
    public int ChalkReplacer(int[] chalk, int k) {
        long total = 0L;
        foreach (int c in chalk)
        {
            total += c;
        }
        total = k % total;
        for (int i = 0; i < chalk.Length; i++)
        {
            if (chalk[i] > total)
            {
                return i;
            }
            total -= chalk[i];
        }
        return 0;
    }
}
// @lc code=end


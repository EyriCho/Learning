/*
 * @lc app=leetcode id=1010 lang=csharp
 *
 * [1010] Pairs of Songs With Total Durations Divisible by 60
 */

// @lc code=start
public class Solution {
    public int NumPairsDivisibleBy60(int[] time) {
        int[] remainders = new int[60];
        int result = 0;
        
        foreach (int t in time)
        {
            int remainder = t % 60;
            result += remainders[remainder == 0 ? 0 : (60 - remainder)];
            remainders[remainder]++;
        }
        
        return result;
    }
}
// @lc code=end


/*
 * @lc app=leetcode id=3577 lang=csharp
 *
 * [3577] Count the Number of Computer Unlocking Permutations
 */

// @lc code=start
public class Solution {
    public int CountPermutations(int[] complexity) {
        for (int i = 1; i < complexity.Length; i++)
        {
            if (complexity[i] <= complexity[0])
            {
                return 0;
            }
        }

        long result = 1L;
        for (int i = 2; i < complexity.Length; i++)
        {
            result = (result * i) % 1_000_000_007L;
        }

        return (int)result;
    }
}
// @lc code=end


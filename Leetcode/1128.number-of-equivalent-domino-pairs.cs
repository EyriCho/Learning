/*
 * @lc app=leetcode id=1128 lang=csharp
 *
 * [1128] Number of Equivalent Domino Pairs
 */

// @lc code=start
public class Solution {
    public int NumEquivDominoPairs(int[][] dominoes) {
        int[] kinds = new int[100];
        int kind = 0,
            result = 0;
        foreach (int[] domino in dominoes)
        {
            kind = domino[0] <= domino[1] ? (domino[0] * 10 + domino[1]) : (domino[1] * 10 + domino[0]);
            result += kinds[kind];
            kinds[kind]++;
        }
        
        return result;
    }
}
// @lc code=end


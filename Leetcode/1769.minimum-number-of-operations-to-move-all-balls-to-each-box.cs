/*
 * @lc app=leetcode id=1769 lang=csharp
 *
 * [1769] Minimum Number of Operations to Move All Balls to Each Box
 */

// @lc code=start
public class Solution {
    public int[] MinOperations(string boxes) {
        int[] result = new int[boxes.Length];

        int moves = 0,
            count = 0;

        for (int i = 0; i < boxes.Length; i++)
        {
            result[i] += moves;
            count += boxes[i] == '1' ? 1 : 0;
            moves += count;
        }

        count = 0;
        moves = 0;
        for (int i = boxes.Length - 1; i >= 0; i--)
        {
            result[i] += moves;
            count += boxes[i] == '1' ? 1 : 0;
            moves += count;
        }

        return result;
    }
}
// @lc code=end


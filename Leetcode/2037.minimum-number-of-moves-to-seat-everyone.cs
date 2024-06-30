/*
 * @lc app=leetcode id=2037 lang=csharp
 *
 * [2037] Minimum Number of Moves to Seat Everyone
 */

// @lc code=start
public class Solution {
    public int MinMovesToSeat(int[] seats, int[] students) {
        Array.Sort(seats);
        Array.Sort(students);

        int i = 0,
            result = 0;

        for (; i < seats.Length; i++)
        {
            result += Math.Abs(students[i] - seats[i]);
        }

        return result;
    }
}
// @lc code=end


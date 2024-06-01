/*
 * @lc app=leetcode id=1700 lang=csharp
 *
 * [1700] Number of Students Unable to Eat Lunch
 */

// @lc code=start
public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int total = students.Sum();

        for (int i = 0; i < sandwiches.Length; i++)
        {
            if ((sandwiches[i] == 0 && total == sandwiches.Length - i) ||
                (sandwiches[i] == 1 && total == 0))
            {
                return sandwiches.Length - i;
            }

            total -= sandwiches[i];
        }

        return 0;
    }
}
// @lc code=end


/*
 * @lc app=leetcode id=2554 lang=csharp
 *
 * [2554] Maximum Number of Integers to Choose From a Range I
 */

// @lc code=start
public class Solution {
    public int MaxCount(int[] banned, int n, int maxSum) {
        HashSet<int> set = new (banned);

        int result = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i > maxSum)
            {
                break;
            }
            
            if (!set.Contains(i))
            {
                result++;
                maxSum -= i;
            }
        }

        return result;
    }
}
// @lc code=end


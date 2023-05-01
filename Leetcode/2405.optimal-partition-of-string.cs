/*
 * @lc app=leetcode id=2405 lang=csharp
 *
 * [2405] Optimal Partition of String
 */

// @lc code=start
public class Solution {
    public int PartitionString(string s) {
        var set = new HashSet<char>();
        
        int i = 0,
            result = 0;
        while (i < s.Length)
        {
            set.Clear();

            while (i < s.Length && !set.Contains(s[i]))
            {
                set.Add(s[i]);
                i++;
            }

            result++;
        }

        return result;
    }
}
// @lc code=end


/*
 * @lc app=leetcode id=1593 lang=csharp
 *
 * [1593] Split a String Into the Max Number of Unique Substrings
 */

// @lc code=start
public class Solution {
    public int MaxUniqueSplit(string s) {
        HashSet<string> set = new ();
        int max = 0;
        
        void Split(int index)
        {
            if (index == s.Length)
            {
                max = Math.Max(max, set.Count);
            }
            for (int i = index + 1; i <= s.Length; i++)
            {
                if (set.Contains(s[index..i]))
                {
                    continue;
                }

                set.Add(s[index..i]);
                Split(i);
                set.Remove(s[index..i]);
            }
        }
        Split(0);

        return max;
    }
}
// @lc code=end


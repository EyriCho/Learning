/*
 * @lc app=leetcode id=2007 lang=csharp
 *
 * [2007] Find Original Array From Doubled Array
 */

// @lc code=start
public class Solution {
    public int[] FindOriginalArray(int[] changed) {
        if (changed.Length % 2 > 0)
        {
            return new int[0];
        }
        
        Array.Sort(changed);
        
        var dict = new Dictionary<int, int>();
        var result = new int[changed.Length >> 1];
        int i = 0;
        for (int j = changed.Length - 1; j >= 0; j--)
        {
            var twice = changed[j] << 1;
            
            if (dict.ContainsKey(twice))
            {
                if (dict[twice] == 1)
                {
                    dict.Remove(twice);
                }
                else
                {
                    dict[twice]--;
                }
                result[i++] = changed[j];
            }
            else
            {
                if (dict.ContainsKey(changed[j]))
                {
                    dict[changed[j]]++;
                }
                else
                {
                    dict[changed[j]] = 1;
                }
            }
        }
        
        return dict.Count > 0 ? new int[0] : result;
    }
}
// @lc code=end


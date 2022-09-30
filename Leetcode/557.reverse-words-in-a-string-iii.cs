/*
 * @lc app=leetcode id=557 lang=csharp
 *
 * [557] Reverse Words in a String III
 */

// @lc code=start
public class Solution {
    public string ReverseWords(string s) {
        int i = 0;
        var array = s.ToCharArray();
        
        while (i < s.Length)
        {
            int l = i;
            while (i < s.Length && s[i] != ' ')
            {
                i++;
            }
            
            int r = i - 1;
            while (l < r)
            {
                var temp = array[l];
                array[l] = array[r];
                array[r] = temp;
                l++;
                r--;
            }
            
            i++;
        }
        
        return new string(array);
    }
}
// @lc code=end


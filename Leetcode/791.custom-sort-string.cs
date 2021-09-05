/*
 * @lc app=leetcode id=791 lang=csharp
 *
 * [791] Custom Sort String
 */

// @lc code=start
public class Solution {
    public string CustomSortString(string order, string str) {
        var array = new char[str.Length];
        var occured = new int[26];
        
        foreach (var c in str)
            occured[c - 'a']++;
        
        int i = 0;
        foreach (var c in order)
            while (occured[c - 'a']-- > 0)
                array[i++] = c;
        
        for (int j = 0; j < 26; j++)
            while (occured[j]-- > 0)
                array[i++] = (char)(j + 'a');
        
        return new string(array);
    }
}
// @lc code=end


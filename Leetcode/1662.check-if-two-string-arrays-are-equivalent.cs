/*
 * @lc app=leetcode id=1662 lang=csharp
 *
 * [1662] Check If Two String Arrays are Equivalent
 */

// @lc code=start
public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        List<char> str1 = new List<char>(),
            str2 = new List<char>();
        
        foreach (var word in word1)
            foreach (var c in word)
                str1.Add(c);
        
        foreach (var word in word2)
            foreach (var c in word)
                str2.Add(c);
        
        if (str1.Count != str2.Count)
            return false;
        
        int i = 0;
        while (i < str1.Count)
        {
            if (str1[i] != str2[i])
                return false;
            
            i++;
        }
        
        return true;
    }
}
// @lc code=end


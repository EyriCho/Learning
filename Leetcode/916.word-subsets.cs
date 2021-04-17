/*
 * @lc app=leetcode id=916 lang=csharp
 *
 * [916] Word Subsets
 */

// @lc code=start
public class Solution {
    public IList<string> WordSubsets(string[] A, string[] B) {
        var result = new List<string>();
        var bCount = new int[26];
        
        var counts = new int[26];
        for (int i = 0; i < B.Length; i++)
        {
            for (int j = 0; j < 26; j++)
                counts[j] = 0;
            foreach (var c in B[i])
                counts[c - 'a']++;
            
            for (int j = 0; j < 26; j++)
                bCount[j] = Math.Max(bCount[j], counts[j]);
        }
        
        foreach (var a in A)
        {
            int j = 0;
            for (; j < 26; j++)
                counts[j] = 0;
            foreach (var c in a)
                counts[c - 'a']++;

            for (j = 0; j < 26; j++)
                if (counts[j] < bCount[j])
                    break;
            
            if (j == 26)
                result.Add(a);
        }
        
        return result;
    }
}
// @lc code=end


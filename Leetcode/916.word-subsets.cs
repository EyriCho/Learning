/*
 * @lc app=leetcode id=916 lang=csharp
 *
 * [916] Word Subsets
 */

// @lc code=start
public class Solution {
    public IList<string> WordSubsets(string[] A, string[] B) {
        List<string> result = new ();
        
        int[] count1 = new int[26],
            count2 = new int[26];
        
        foreach (var word in words2)
        {
            Array.Fill(count1, 0);
            
            foreach (var c in word)
            {
                count1[c - 'a']++;
            }
            
            for (int i = 0; i < 26; i++)
            {
                count2[i] = Math.Max(count2[i], count1[i]);
            }
        }
        
        foreach (var word in words1)
        {
            Array.Fill(count1, 0);

            foreach (var c in word)
            {
                count1[c - 'a']++;
            }
            
            int i = 0;
            for (; i < 26; i++)
            {
                if (count1[i] < count2[i])
                {
                    break;
                }
            }
            
            if (i == 26)
            {
                result.Add(word);
            }
        }
        
        return result;
    }
}
// @lc code=end


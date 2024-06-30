/*
 * @lc app=leetcode id=1002 lang=csharp
 *
 * [1002] Find Common Characters
 */

// @lc code=start
public class Solution {
    public IList<string> CommonChars(string[] words) {
        int[] counts = new int[26],
            temp = new int[26];

        Array.Fill(counts, int.MaxValue);
        
        foreach (string word in words)
        {
            Array.Fill(temp, 0);
            foreach (char c in word)
            {
                temp[c - 'a']++;
            }

            for (int i = 0; i < temp.Length; i++)
            {
                counts[i] = Math.Min(temp[i], counts[i]);
            }
        }

        string character = string.Empty;
        List<string> result = new ();
        for (int i = 0; i < temp.Length; i++)
        {
            character = ((char)('a' + i)).ToString();
            while (counts[i] > 0)
            {
                result.Add(character);
                counts[i]--;
            }
        }
        return result;
    }
}
// @lc code=end


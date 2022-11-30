/*
 * @lc app=leetcode id=345 lang=csharp
 *
 * [345] Reverse Vowels of a String
 */

// @lc code=start
public class Solution {
    public string ReverseVowels(string s) {
        int l = 0, r = s.Length - 1;
        var array = s.ToCharArray();
        var vowels = new HashSet<char> {
            'a', 'e', 'i', 'o', 'u',
            'A', 'E', 'I', 'O', 'U'
        };
        
        while (l < r)
        {
            while (l < r && !vowels.Contains(array[l]))
            {
                l++;
            }
            
            while (l < r && !vowels.Contains(array[r]))
            {
                r--;
            }
            
            if (l < r)
            {
                var temp = array[l];
                array[l] = array[r];
                array[r] = temp;
            }
            l++;
            r--;
        }
        
        return new string(array);
    }
}
// @lc code=end


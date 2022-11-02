/*
 * @lc app=leetcode id=38 lang=csharp
 *
 * [38] Count and Say
 */

// @lc code=start
public class Solution {
    public string CountAndSay(int n) {
        List<char> Say(List<char> sequence)
        {
            var list = new List<char>();
            
            int i = 0;
            while (i < sequence.Count)
            {
                var c = sequence[i];
                var j = i + 1;
                while (j < sequence.Count && sequence[j] == c)
                {
                    j++;
                }
                list.Add((char)(j - i + '0'));
                list.Add(c);
                i = j;
            }
            return list;
        }
        
        var word = new List<char>() {
            '1'
        };
        while (--n > 0)
        {
            word = Say(word);
        }
        
        return new string(word.ToArray());
    }
}
// @lc code=end


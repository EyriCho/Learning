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
            List<char> rst = new ();
            
            int i = 0,
                j = 0;
            char c;
            while (i < sequence.Count)
            {
                c = sequence[i];
                j = i + 1;
                while (j < sequence.Count && sequence[j] == c)
                {
                    j++;
                }
                rst.Add((char)(j - i + '0'));
                rst.Add(c);
                i = j;
            }
            return rst;
        }
        
        List<char> word = new () { '1' };
        while (--n > 0)
        {
            word = Say(word);
        }
        
        return new string(word.ToArray());
    }
}
// @lc code=end


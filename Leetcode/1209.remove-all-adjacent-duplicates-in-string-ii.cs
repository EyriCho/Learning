/*
 * @lc app=leetcode id=1209 lang=csharp
 *
 * [1209] Remove All Adjacent Duplicates in String II
 */

// @lc code=start
public class Solution {
    public string RemoveDuplicates(string s, int k) {
        var stack = new Stack<(char, int)>();
        int i = 0, total = 0;
        
        while (i < s.Length)
        {
            var c = s[i];
            var start = i++;
            while (i < s.Length && s[i] == c)
                i++;
            var count = i - start;
            
            if (stack.Count > 0)
            {
                var (prevChar, prevCount) = stack.Peek();
                if (prevChar == c)
                {
                    count += prevCount;
                    stack.Pop();
                    total -= prevCount;
                }
            }
            
            count = count % k;
            
            if (count > 0)
            {    
                stack.Push((c, count));
                total += count;
            }
        }
        
        var result = new char[total];
        foreach (var (c, count) in stack)
        {
            i = count;
            while (i-- > 0)
                result[--total] = c;
        }
        return new string(result);
    }
}
// @lc code=end


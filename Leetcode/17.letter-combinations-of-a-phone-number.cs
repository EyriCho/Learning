/*
 * @lc app=leetcode id=17 lang=csharp
 *
 * [17] Letter Combinations of a Phone Number
 */

// @lc code=start
public class Solution {
    public IList<string> LetterCombinations(string digits) {
        var result = new List<string>();
        if (digits.Length == 0)
            return result;
        
        var map = new char[][] {
            new char[] {},
            new char[] {},
            new char[] { 'a', 'b', 'c' },
            new char[] { 'd', 'e', 'f' },
            new char[] { 'g', 'h', 'i' },
            new char[] { 'j', 'k', 'l' },
            new char[] { 'm', 'n', 'o' },
            new char[] { 'p', 'q', 'r', 's'},
            new char[] { 't', 'u', 'v'},
            new char[] { 'w', 'x', 'y', 'z'}
        };
        
        var queue = new Queue<char[]>();
        queue.Enqueue(new char[digits.Length]);
        
        int i = 0;
        while (i < digits.Length)
        {
            var letters = map[digits[i] - '0'];
            
            var count = queue.Count;
            while (count-- > 0)
            {
                var array = queue.Dequeue();
                
                foreach (var l in letters)
                {
                    var n = new char[digits.Length];
                    Array.Copy(array, n, i);
                    n[i] = l;
                    queue.Enqueue(n);
                }
            }
            
            i++;
        }
        
        while (queue.Count > 0)
        {
            result.Add(new string(queue.Dequeue()));
        }
        
        return result;
    }
}
// @lc code=end


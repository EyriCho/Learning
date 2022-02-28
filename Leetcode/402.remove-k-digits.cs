/*
 * @lc app=leetcode id=402 lang=csharp
 *
 * [402] Remove K Digits
 */

// @lc code=start
public class Solution {
    public string RemoveKdigits(string num, int k) {
        if (num.Length == k)
        {
            return "0";
        }
        
        var set = new HashSet<int>();
        var stack = new Stack<int>();
        int count = 0,
            i = 0;
        while (count < k && i < num.Length)
        {
            while (count < k && stack.Count > 0 && num[stack.Peek()] > num[i])
            {
                stack.Pop();
                count++;
            }
            
            stack.Push(i);
            i++;
        }
        
        while (i < num.Length)
        {
            stack.Push(i++);
        }
        
        while (count < k)
        {
            stack.Pop();
            count++;
        }
        
        var list = new List<char>(stack.Count);
        count = stack.Count;
        while (count > 0)
        {
            list.Insert(0, num[stack.Pop()]);
            count--;
        }
        while (list.Count > 0 && list[0] == '0')
        {
            list.RemoveAt(0);
        }
        
        return list.Count == 0 ? "0" : string.Join("", list);
    }
}
// @lc code=end


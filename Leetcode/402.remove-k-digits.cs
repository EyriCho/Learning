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

        Stack<int> stack = new();
        int i = 0,
            count = 0;

        while (count < k && i < num.Length)
        {
            while (count < k && stack.Count > 0 && num[stack.Peek()] > num[i])
            {
                stack.Pop();
                count++;
            }

            stack.Push(i++);
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

        List<char> list = new(stack.Count());
        while (stack.Count > 0)
        {
            list.Insert(0, num[stack.Pop()]);
        }

        while (list.Count > 0 && list[0] == '0')
        {
            list.RemoveAt(0);
        }

        return list.Count == 0 ? "0" : new string(list.ToArray());
    }
}
// @lc code=end


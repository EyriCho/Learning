/*
 * @lc app=leetcode id=682 lang=csharp
 *
 * [682] Baseball Game
 */

// @lc code=start
public class Solution {
    public int CalPoints(string[] ops) {
        var stack = new Stack<int>();
        int result = 0;
        
        foreach (var op in ops)
        {
            if (op == "+")
            {
                var num1 = stack.Pop();
                var num = num1 + stack.Peek();
                stack.Push(num1);
                result += num;
                stack.Push(num);
            }
            else if (op == "D")
            {
                var num = stack.Peek() * 2;
                stack.Push(num);
                result += num;
            }
            else if (op == "C")
            {
                result -= stack.Pop();
            }
            else
            {
                var num = int.Parse(op);
                stack.Push(num);
                result += num;
            }
        }
        
        return result;
    }
}
// @lc code=end


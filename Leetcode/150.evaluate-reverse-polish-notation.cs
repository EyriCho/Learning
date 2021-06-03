/*
 * @lc app=leetcode id=150 lang=csharp
 *
 * [150] Evaluate Reverse Polish Notation
 */

// @lc code=start
public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        foreach (var token in tokens)
        {
            if (token.Length == 1 && token[0] < '0')
            {
                int oper2 = stack.Pop(),
                    oper1 = stack.Pop();
                if (token == "+")
                    stack.Push(oper1 + oper2);
                else if (token == "-")
                    stack.Push(oper1 - oper2);
                else if (token == "*")
                    stack.Push(oper1 * oper2);
                else if (token == "/")
                    stack.Push(oper1 / oper2);
            }
            else
                stack.Push(int.Parse(token));
        }
        
        return stack.Pop();
    }
}
// @lc code=end


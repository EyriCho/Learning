/*
 * @lc app=leetcode id=946 lang=csharp
 *
 * [946] Validate Stack Sequences
 */

// @lc code=start
public class Solution {
    public bool ValidateStackSequences(int[] pushed, int[] popped) {
        var stack = new Stack<int>();
        
        var popIdx = 0;
        
        foreach (var num in pushed)
        {
            stack.Push(num);
            
            while (stack.Count > 0 &&
                   popIdx < popped.Length &&
                   stack.Peek() == popped[popIdx])
            {
                stack.Pop();
                popIdx++;
            }
        }
        
        return stack.Count == 0;
    }
}
// @lc code=end


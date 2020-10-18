/*
 * @lc app=leetcode id=39 lang=csharp
 *
 * [39] Combination Sum
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        Array.Sort(candidates);
        cdds = candidates;
        stack = new Stack<int>();
        result = new List<IList<int>>();
        
        SubCombination(0, target);
        
        return result;
    }
    IList<IList<int>> result;
    Stack<int> stack;
    int[] cdds;
    
    private void SubCombination(int pos, int left)
    {
        for (int i = pos; i < cdds.Length; i++)
        {
            if (left < cdds[i])
                return;
            else if (left == cdds[i])
            {
                stack.Push(cdds[i]);
                result.Add(new List<int>(stack));
                stack.Pop();
                return;
            }
            else
            {
                stack.Push(cdds[i]);
                SubCombination(i, left - cdds[i]);
                stack.Pop();
            }
        }
    }
}
// @lc code=end


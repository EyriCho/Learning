/*
 * @lc app=leetcode id=216 lang=csharp
 *
 * [216] Combination Sum III
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        result = new List<IList<int>>();
        
        Help(new List<int>(), 1, k, n);
        
        return result;
    }

    List<IList<int>> result;
    public void Help(IList<int> list, int start, int k, int n)
    {
        if (k == 1)
        {
            if (n < 10)
            {
                list.Add(n);
                result.Add(new List<int>(list));
                list.RemoveAt(list.Count - 1);                
            }
            
            return;
        }
        
        int last = 11 - k;
        for (int i = start; i < last; i++)
        {
            var left = n - i;
            if (left <= i)
                break;
            
            list.Add(i);
            Help(list, i + 1, k - 1, n - i);
            list.RemoveAt(list.Count - 1);
        }
    }
}
// @lc code=end


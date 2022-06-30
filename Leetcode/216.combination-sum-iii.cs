/*
 * @lc app=leetcode id=216 lang=csharp
 *
 * [216] Combination Sum III
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        var result = new List<IList<int>>();
        if (n > 45)
        {
            return result;
        }
        
        var temp = new List<int>();
        
        void Sum (int left, int num, int digit)
        {
            if (num == 0 && left == 0)
            {
                result.Add(new List<int>(temp));
                return;
            }
            
            for (int j = digit; j < 10; j++)
            {
                if (j > left)
                {
                    break;
                }
                
                temp.Add(j);
                Sum(left - j, num - 1, j + 1);
                temp.Remove(j);
            }
        }
        
        Sum(n, k, 1);
        
        return result;
    }
}
// @lc code=end


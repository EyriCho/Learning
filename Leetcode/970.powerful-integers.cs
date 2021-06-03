/*
 * @lc app=leetcode id=970 lang=csharp
 *
 * [970] Powerful Integers
 */

// @lc code=start
public class Solution {
    public IList<int> PowerfulIntegers(int x, int y, int bound) {
        var set = new HashSet<int>();
        
        for (int i = 1; i < bound; i *= x)
        {
            for (int j = 1; i + j <= bound; j *= y)
            {
                set.Add(i + j);
                if (y == 1)
                    break;
            }
            if (x == 1)
                break;
        }
        
        return set.ToList();
    }
}
// @lc code=end


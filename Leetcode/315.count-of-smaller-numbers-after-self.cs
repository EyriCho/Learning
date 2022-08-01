/*
 * @lc app=leetcode id=315 lang=csharp
 *
 * [315] Count of Smaller Numbers After Self
 */

// @lc code=start
public class Solution {
    public IList<int> CountSmaller(int[] nums) {
        var temp = new int[200_002];
        
        var result = new int[nums.Length];
        
        int Query(int x)
        {
            int r = 0;
            for (int i = x; i > 0; i -= (i & -i))
            {
                r += temp[i];
            }
            return r;
        }
        
        void Add(int x, int c)
        {
            for (int i = x; i < 200_002; i += (i & -i))
            {
                temp[i] += c;
            }
        }
        
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            int x = nums[i] + 100_001;
            
            result[i] = Query(x - 1);
            
            Add(x, 1);
        }
        
        return result;
    }
}
// @lc code=end


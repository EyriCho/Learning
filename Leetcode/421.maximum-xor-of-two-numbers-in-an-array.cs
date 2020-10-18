/*
 * @lc app=leetcode id=421 lang=csharp
 *
 * [421] Maximum XOR of Two Numbers in an Array
 */

// @lc code=start
public class Solution {
    public int FindMaximumXOR(int[] nums) {
        int result = 0, mask = 0; 
        
        for (int i = 31; i >= 0; --i)
        {
            mask |= 1 << i;
            var set = new HashSet<int>();
            foreach (var num in nums)
            {
                set.Add(num & mask);
            }
            
            int t = result | 1 << i;
            foreach (var prefix in set)
            {
                if (set.Contains(prefix ^ t))
                {
                    result = t;
                    break;
                }
            }
        }
        
        return result;
    }
}
// @lc code=end


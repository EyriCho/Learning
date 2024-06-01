/*
 * @lc app=leetcode id=78 lang=csharp
 *
 * [78] Subsets
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        int count = 1 << nums.Length,
            num = 0,
            j = 0;
        
        List<IList<int>> result = new ();
        
        for (int i = 0; i < count; i++)
        {
            List<int> list = new ();
            
            num = i;
            j = 0;
            while (num > 0)
            {
                if (num % 2 == 1)
                {
                    list.Add(nums[j]);
                }
                num >>= 1;
                j++;
            }
            result.Add(list);
        }
        
        return result;
    }
}
// @lc code=end


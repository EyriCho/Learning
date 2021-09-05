/*
 * @lc app=leetcode id=90 lang=csharp
 *
 * [90] Subsets II
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        
        var result = new List<IList<int>>();
        result.Add(new List<int>());
        int last = nums[0], size = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (last != nums[i])
            {
                last = nums[i];
                size = result.Count;
            }
            int newSize = result.Count;
            for (int j = newSize - size; j < newSize; j++)
            {
                var list = new List<int>(result[j]);
                list.Add(nums[i]);
                result.Add(list);
            }
        }
        
        return result;
    }
}
// @lc code=end


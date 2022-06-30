/*
 * @lc app=leetcode id=47 lang=csharp
 *
 * [47] Permutations II
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        var result = new List<IList<int>>();
        var temp = new List<int>();
        
        void Helper(int index)
        {
            if (index == nums.Length)
            {
                result.Add(new List<int>(temp));
                return;
            }
            
            var set = new HashSet<int>();
            
            for (int i = index; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    continue;
                }
                set.Add(nums[i]);
                
                int t = nums[i];
                nums[i] = nums[index];
                nums[index] = t;
                
                temp.Add(nums[index]);

                Helper(index + 1);
                
                temp.RemoveAt(index);
                
                nums[index] = nums[i];
                nums[i] = t;               
            }
        }
        
        Helper(0);
        
        return result;
    }
}
// @lc code=end


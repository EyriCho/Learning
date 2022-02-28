/*
 * @lc app=leetcode id=60 lang=csharp
 *
 * [60] Permutation Sequence
 */

// @lc code=start
public class Solution {
    public string GetPermutation(int n, int k) {
        int num = 1, count = 1;
        var list = new List<int>();
        var candidates  = new List<int>();
        
        while (num <= n)
        {
            count *= num;
            candidates.Add(num);
            num++;
        }
        count /= --num;
        
        while (k > 0 && num > 1)
        {
            int p = (k - 1) / count;
            list.Add(candidates[p]);
            candidates.RemoveAt(p);
            k = k - p * count;
            count /= --num;
        }
        
        list.AddRange(candidates);
        
        return string.Join("", list);
    }
}
// @lc code=end


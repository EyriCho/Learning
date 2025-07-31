/*
 * @lc app=leetcode id=898 lang=csharp
 *
 * [898] Bitwise ORs of Subarrays
 */

// @lc code=start
public class Solution {
    public int SubarrayBitwiseORs(int[] arr) {
        HashSet<int> prev = new (),
            current = new (),
            all = new (),
            temp = null;

        foreach (int num in arr)
        {
            current.Clear();
            prev.Add(0);

            foreach (int p in prev)
            {
                current.Add(p | num);
                all.Add(p | num);
            }

            temp = prev;
            prev = current;
            current = temp;
        }
        
        return all.Count;
    }
}
// @lc code=end


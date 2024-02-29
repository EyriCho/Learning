/*
 * @lc app=leetcode id=1207 lang=csharp
 *
 * [1207] Unique Number of Occurrences
 */

// @lc code=start
public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> dict = new ();
        HashSet<int> set = new ();
        
        foreach (int num in arr)
        {
            if (!dict.ContainsKey(num))
            {
                dict[num] = 0;
            }
            dict[num]++;
        }
        
        foreach (int freq in dict.Values)
        {
            if (set.Contains(freq))
            {
                return false;
            }
            
            set.Add(freq);
        }
        
        return true;
    }
}
// @lc code=end


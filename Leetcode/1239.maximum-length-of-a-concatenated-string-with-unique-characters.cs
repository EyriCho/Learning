/*
 * @lc app=leetcode id=1239 lang=csharp
 *
 * [1239] Maximum Length of a Concatenated String with Unique Characters
 */

// @lc code=start
public class Solution {
    public int MaxLength(IList<string> arr) {
        int ToInt(string s)
        {
            int r = 0;
            foreach (var c in s)
            {
                var bit = 1 << (c - 'a');
                if ((r & bit) > 0)
                {
                    return 0;
                }
                else
                {
                    r |= bit;
                }
            }
            return r;
        }
        
        int BitCount(int mask)
        {
            int r = 0;
            while (mask > 0)
            {
                mask &= (mask - 1);
                r++;
            }
            return r;
        }
        
        var set = new HashSet<int>();
        set.Add(0);
        var result = 0;
        
        for (int i = 0; i < arr.Count; i++)
        {
            var strInt = ToInt(arr[i]);
            if (strInt > 0)
            {
                var toAdd = new List<int>();
                foreach (var prev in set)
                {
                    var newInt = strInt | prev;
                    if ((strInt & prev) == 0 && !set.Contains(newInt))
                    {
                        toAdd.Add(newInt);
                        result = Math.Max(result, BitCount(newInt));
                    }
                }
                
                foreach (var add in toAdd)
                {
                    set.Add(add);
                }
            }
        }
        
        return result;
    }
}
// @lc code=end


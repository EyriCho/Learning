/*
 * @lc app=leetcode id=1865 lang=csharp
 *
 * [1865] Finding Pairs With a Certain Sum
 */

// @lc code=start
public class FindSumPairs {

    Dictionary<int, int> dict1;
    Dictionary<int, int> dict2;
    int[] nums2;

    public FindSumPairs(int[] nums1, int[] nums2) {
        dict1 = new ();
        dict2 = new ();
        int c = 0;
        foreach (int num in nums1)
        {
            dict1.TryGetValue(num, out c);
            dict1[num] = c + 1;
        }

        this.nums2 = nums2;
        foreach (int num in nums2)
        {
            dict2.TryGetValue(num, out c);
            dict2[num] = c + 1;
        }
    }
    
    public void Add(int index, int val) {
        int c = 0;
        dict2.TryGetValue(nums2[index], out c);
        if (c == 1)
        {
            dict2.Remove(nums2[index]);
        }
        else
        {
            dict2[nums2[index]] = c - 1;
        }

        nums2[index] += val;
        dict2.TryGetValue(nums2[index], out c);
        dict2[nums2[index]] = c + 1;
    }
    
    public int Count(int tot) {
        int result = 0,
            left = 0;
        foreach (KeyValuePair<int, int> kv in dict1)
        {
            if (kv.Key >= tot)
            {
                continue;
            }

            left = tot - kv.Key;
            if (!dict2.ContainsKey(left))
            {
                continue;
            }

            result += kv.Value * dict2[left];
        }

        return result;
    }
}

/**
 * Your FindSumPairs object will be instantiated and called as such:
 * FindSumPairs obj = new FindSumPairs(nums1, nums2);
 * obj.Add(index,val);
 * int param_2 = obj.Count(tot);
 */
// @lc code=end


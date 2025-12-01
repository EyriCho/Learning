/*
 * @lc app=leetcode id=3321 lang=csharp
 *
 * [3321] Find X-Sum of All K-Long Subarrays II
 */

// @lc code=start
public class Solution {
    public long[] FindXSum(int[] nums, int k, int x) {
        Dictionary<int, int> dict = new ();
        Comparer<(int, int)> comparer = Comparer<(int Count, int Num)>.Create(
            (a, b) => a.Count == b.Count ?
                b.Num.CompareTo(a.Num) :
                b.Count.CompareTo(a.Count)
        );
        SortedSet<(int Count, int Num)> top = new (comparer),
            rest = new (comparer);

        long total = 0L;
        void Add(int num, int count)
        { 
            if (top.Count < x)
            {
                top.Add((count, num));
                total += (long)num * count;
            }
            else
            {
                rest.Add((count, num));
                if (comparer.Compare(rest.Min, top.Max) < 0)
                {
                    (int Count, int Num) moveDown = top.Max,
                        moveUp = rest.Min;
                    total -= (long)moveDown.Count * moveDown.Num;
                    total += (long)moveUp.Count * moveUp.Num;
                    top.Remove(moveDown);
                    top.Add(moveUp);
                    rest.Remove(moveUp);
                    rest.Add(moveDown);
                }
            }
        }

        void Remove((int Count, int Num) d)
        {
            if (top.Contains(d))
            {
                top.Remove(d);
                total -= (long)d.Count * d.Num;

                if (rest.Count > 0)
                {
                    (int Count, int Num) moveUp = rest.Min;
                    total += (long)moveUp.Count * moveUp.Num;
                    top.Add(moveUp);
                    rest.Remove(moveUp);
                }
            }
            else if (rest.Contains(d))
            {
                rest.Remove(d);
            }
        }

        int count = 0,
            num = 0,
            idx = 0;
        for (int i = k - 2; i >= 0; i--)
        {
            dict.TryGetValue(nums[i], out count);
            dict[nums[i]] = count + 1;
        }
        foreach (KeyValuePair<int, int> kv in dict)
        {
            Add(kv.Key, kv.Value);
        }

        long[] result = new long[nums.Length - k + 1];
        for (int i = k - 1; i < nums.Length; i++)
        {
            idx = i - k + 1;
            dict.TryGetValue(nums[i], out count);
            Remove((count, nums[i]));
            count++;
            dict[nums[i]] = count;
            Add(nums[i], count);

            result[idx] = total;

            dict.TryGetValue(nums[idx], out count);
            Remove((count, nums[idx]));
            count--;
            dict[nums[idx]] = count;
            Add(nums[idx], count);
        }
        
        return result;
    }
}
// @lc code=end


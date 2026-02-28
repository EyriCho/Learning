/*
 * @lc app=leetcode id=3510 lang=csharp
 *
 * [3510] Minimum Pair Removal to Sort Array II
 */

// @lc code=start
public class Solution {
    public int MinimumPairRemoval(int[] nums) {
        PriorityQueue<(int, int, long, long), (long, int)> queue = new (Comparer<(long sum, int index)>.Create((a, b) => 
            a.sum.Equals(b.sum) ? a.index.CompareTo(b.index) :
                a.sum.CompareTo(b.sum)));
        
        long[] array = new long[nums.Length];
        int[] last = new int[nums.Length],
            next = new int[nums.Length];

        int violations = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            array[i] = nums[i];
            last[i] = i - 1;
            next[i] = i + 1;
            
            if (i != nums.Length - 1)
            {
                queue.Enqueue((i, i + 1, nums[i], nums[i + 1]), (array[i] + nums[i + 1], i));
                if (nums[i] > nums[i + 1])
                {
                    violations++;
                }
            }
        }

        int result = 0,
            idx = 0, nxt = 0,
            p = 0, n = 0;
        long val = 0L, nextVal = 0L,
            sum = 0L;
        while (violations > 0)
        {
            (idx, nxt, val, nextVal) = queue.Dequeue();
            sum = val + nextVal;

            if (array[idx] != val ||
                array[nxt] != nextVal)
            {
                continue;
            }

            if (array[idx] > array[nxt])
            {
                violations--;
            }

            next[idx] = next[nxt];
            if (next[nxt] != nums.Length)
            {
                last[next[nxt]] = idx;
            }

            if (idx > 0)
            {
                p = last[idx];
                if (p != -1)
                {
                    if (array[p] > array[idx])
                    {
                        violations--;
                    }

                    if (array[p] > sum)
                    {
                        violations++;
                    }
                    queue.Enqueue((p, idx, array[p], sum), (array[p] + sum, p));
                }
            }

            if (next[nxt] != nums.Length)
            {
                n = next[nxt];
                if (array[nxt] > array[n])
                {
                    violations--;
                }

                if (sum > array[n])
                {
                    violations++;
                }
                queue.Enqueue((idx, n, sum, array[n]), (sum + array[n], idx));
            }

            array[idx] = sum;
            array[nxt] = int.MinValue;
            result++;
        }


        return result;
    }
}
// @lc code=end


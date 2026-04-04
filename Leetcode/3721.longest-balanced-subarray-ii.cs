/*
 * @lc app=leetcode id=3721 lang=csharp
 *
 * [3721] Longest Balanced Subarray II
 */

// @lc code=start
public class Solution {
    public int LongestBalanced(int[] nums) {
        Dictionary<int, int> dict = new ();
        SegmentTree tree = new (nums.Length);

        int result = 0,
            lastSeen = 0,
            r = 0;
        for (int l = nums.Length - 1; l >= 0; l--)
        {
            if (dict.TryGetValue(nums[l], out lastSeen))
            {
                tree.Update(lastSeen, 0);
            }
            dict[nums[l]] = l;
            tree.Update(l, (nums[l] % 2 == 0) ? 1 : -1);

            r = tree.FindRightMostPrefix(0);
            if (r >= l)
            {
                result = Math.Max(result, r - l + 1);
            }
        }

        return result;
    }

    internal class SegmentTree
    {
        private int Length;
        private int[] Sum;
        private int[] Min;
        private int[] Max;

        internal SegmentTree(int length)
        {
            Length = length;
            Sum = new int[length * 4];
            Max = new int[length * 4];
            Min = new int[length * 4];
        }

        private void Pull(int node)
        {
            int l = node << 1,
                r = (node << 1) | 1;
            
            Sum[node] = Sum[l] + Sum[r];
            Min[node] = Math.Min(Min[l], Sum[l] + Min[r]);
            Max[node] = Math.Max(Max[l], Sum[l] + Max[r]);
        }

        internal void Update(int idx, int val)
        {
            int node = 1,
                l = 0,
                m = 0,
                r = Length - 1,
                ps = 0;
            
            int[] path = new int[32];

            while (l != r)
            {
                path[ps++] = node;
                m = l + (r - l) / 2;
                if (idx <= m)
                {
                    node <<= 1;
                    r = m;
                }
                else
                {
                    node = (node << 1) | 1;
                    l = m + 1;
                }
            }


            Sum[node] = Min[node] = Max[node] = val;

            while (ps > 0)
            {
                Pull(path[--ps]);
            }
        }

        internal int FindRightMostPrefix(int target)
        {
            int node = 1,
                l = 0,
                m = 0,
                r = Length - 1,
                leftNode = 0,
                rightNode = 0,
                sumBefore = 0;
            
            if (Min[node] > target || Max[node] < target)
            {
                return -1;
            }

            while (l != r)
            {
                m = l + (r - l) / 2;
                leftNode = node << 1;
                rightNode = (node << 1) | 1;

                int sumBeforeRight = sumBefore + Sum[leftNode],
                    rightNeed = target - sumBeforeRight;
                
                if (Min[rightNode] <= rightNeed && Max[rightNode] >= rightNeed)
                {
                    node = rightNode;
                    l = m + 1;
                    sumBefore = sumBeforeRight;
                }
                else
                {
                    node = leftNode;
                    r = m;
                }
            }

            return l;
        }
    }
}
// @lc code=end


/*
 * @lc app=leetcode id=3525 lang=csharp
 *
 * [3525] Find X Value of Array II
 */

// @lc code=start
public class Solution {
    public int[] ResultArray(int[] nums, int k, int[][] queries) {
        (int product, int[] freq)[] segTree = new (int, int[])[nums.Length << 2];
        for (int i = 0; i < segTree.Length; i++)
        {
            segTree[i] = (0, new int[k]);
        }

        (int, int[]) Merge(
            (int product, int[] freq) lNode,
            (int product, int[] freq) rNode)
        {
            (int product, int[] freq) rst = (0, new int[k]);
            rst.product = (lNode.product * rNode.product) % k;

            for (int r = 0; r < k; r++)
            {
                rst.freq[r] = lNode.freq[r];
            }

            int remain = 0;
            for (int r = 0; r < k; r++)
            {
                if (rNode.freq[r] == 0)
                {
                    continue;
                }

                remain = lNode.product * r % k;
                rst.freq[remain] += rNode.freq[r];
            }

            return rst;
        }

        void Build(int idx, int l, int r)
        {
            if (l == r)
            {
                segTree[idx].product = nums[l] % k;
                segTree[idx].freq[segTree[idx].product] = 1;
                return;
            }

            int m = (l + r) >> 1,
                left = idx << 1,
                right = (idx << 1) | 1;
            Build(left, l, m);
            Build(right, m + 1, r);

            segTree[idx] = Merge(segTree[left], segTree[right]);
        }

        void Update(int idx, int l, int r, int i, int val)
        {
            if (l == r)
            {
                segTree[idx].product = val % k;
                Array.Fill(segTree[idx].freq, 0);
                segTree[idx].freq[segTree[idx].product] = 1;
                return;
            }

            int m = (l + r) >> 1,
                left = idx << 1,
                right = (idx << 1) | 1;
            if (i <= m)
            {
                Update(left, l, m, i, val);
            }
            else
            {
                Update(right, m + 1, r, i, val);
            }

            segTree[idx] = Merge(segTree[left], segTree[right]);
        }

        (int, int[] freq) Query(int idx, int l, int r, int left, int right)
        {
            if (left > right)
            {
                return (1, new int[k]);
            }

            if (l == left && r == right)
            {
                return segTree[idx];
            }

            int m = (l + r) >> 1;

            return Merge(Query(idx << 1, l, m, left, Math.Min(m, right)),
                Query((idx << 1) | 1, m + 1, r, Math.Max(left, m + 1), right));
        }

        Build(1, 0, nums.Length - 1);
        int[] result = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            Update(1, 0, nums.Length - 1, queries[i][0], queries[i][1]);
            result[i] = Query(1, 0, nums.Length - 1, queries[i][2], nums.Length - 1).freq[queries[i][3]];
        }

        return result;
    }
}
// @lc code=end


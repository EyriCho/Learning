/*
 * @lc app=leetcode id=2213 lang=csharp
 *
 * [2213] Longest Substring of One Repeating Character
 */

// @lc code=start
public class Solution {
    public int[] LongestRepeating(string s, string queryCharacters, int[] queryIndices) {
        char[] array = s.ToCharArray();
        int[] prefix = new int[s.Length << 2],
            suffix = new int[s.Length << 2],
            best = new int[s.Length << 2],
            result = new int[queryIndices.Length];

        void Merge(int node, int left, int mid, int right)
        {
            int leftNode = node << 1,
                rightNode = node << 1 | 1,
                leftLength = mid - left + 1,
                rightLength = right - mid;
            
            prefix[node] = prefix[leftNode];
            suffix[node] = suffix[rightNode];
            best[node] = Math.Max(best[leftNode], best[rightNode]);

            if (array[mid] != array[mid + 1])
            {
                return;
            }

            best[node] = Math.Max(best[node], suffix[leftNode] + prefix[rightNode]);

            if (prefix[leftNode] == leftLength)
            {
                prefix[node] = leftLength + prefix[rightNode];
            }

            if (suffix[rightNode] == rightLength)
            {
                suffix[node] = rightLength + suffix[leftNode];
            }
        }

        void Build(int node, int left, int right)
        {
            if (left == right)
            {
                prefix[node] = suffix[node] = best[node] = 1;
                return;
            }

            int mid = (left + right) >> 1;
            Build(node << 1, left, mid);
            Build(node << 1 | 1, mid + 1, right);
            Merge(node, left, mid, right);
        }

        void Update(int node, int left, int right, int index)
        {
            if (left == right)
            {
                return;
            }

            int mid = (left + right) >> 1;
            if (index <= mid)
            {
                Update(node << 1, left, mid, index);
            }
            else
            {
                Update(node << 1 | 1, mid + 1, right, index);
            }

            Merge(node, left, mid, right);
        }

        Build(1, 0, s.Length - 1);
        for (int i = 0; i < result.Length; i++)
        {
            array[queryIndices[i]] = queryCharacters[i];
            Update(1, 0, s.Length - 1, queryIndices[i]);
            result[i] = best[1];
        }

        return result;
    }
}
// @lc code=end


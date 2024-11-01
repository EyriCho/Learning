/*
 * @lc app=leetcode id=1405 lang=csharp
 *
 * [1405] Longest Happy String
 */

// @lc code=start
public class Solution {
    public string LongestDiverseString(int a, int b, int c) {
        StringBuilder builder = new (a + b + c);
        PriorityQueue<char, int> queue = new (Comparer<int>.Create((a, b) => b.CompareTo(a)));
        queue.EnqueueRange([('a', a), ('b', b), ('c', c)]);

        bool TryAppend()
        {
            if (!queue.TryDequeue(out char letter, out int count) ||
                count == 0)
            {
                return false;
            }

            if (builder is [.., char secondBehind, char behind] &&
                secondBehind == letter &&
                behind == letter &&
                !TryAppend())
            {
                return false;
            }

            builder.Append(letter);
            queue.Enqueue(letter, --count);
            return true;
        }

        while (TryAppend());
        return builder.ToString();
    }
}
// @lc code=end


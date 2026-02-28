/*
 * @lc app=leetcode id=3507 lang=csharp
 *
 * [3507] Minimum Pair Removal to Sort Array I
 */

// @lc code=start
public class Solution {
    public int MinimumPairRemoval(int[] nums) {
        LinkedList<int> list = new ();
        foreach(int num in nums)
        {
            list.AddLast(num);
        }

        int result = 0,
            min = 0;
        LinkedListNode<int> node = list.First,
            current = null,
            minNode = null;
        while (node.Next != null)
        {
            if (node.Value <= node.Next.Value)
            {
                node = node.Next;
                continue;
            }

            current = list.First;
            min = current.Value + current.Next.Value;
            minNode = current;
            while (current.Next != null)
            {
                if (current.Value + current.Next.Value < min)
                {
                    min = current.Value + current.Next.Value;
                    minNode = current;
                }

                current = current.Next;
            }

            list.AddBefore(minNode, min);
            list.Remove(minNode.Next);
            list.Remove(minNode);
            node = list.First;
            result++;
        }

        return result;
    }
}
// @lc code=end


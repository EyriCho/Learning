/*
 * @lc app=leetcode id=1625 lang=csharp
 *
 * [1625] Lexicographically Smallest String After Applying Operations
 */

// @lc code=start
public class Solution {
    public string FindLexSmallestString(string s, int a, int b) {
        char[] adds = new char[10];
        for (int i = 0; i < 10; i++)
        {
            adds[i] = (char)('0' + (i + a) % 10);
        }

        string Add(string origin)
        {
            char[] array = origin.ToCharArray();
            for (int i = 1; i < array.Length; i += 2)
            {
                array[i] = adds[array[i] - '0'];
            }

            return new string(array);
        }

        string Rotate(string origin)
        {
            char[] array = origin.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                array[(i + b) % array.Length] = origin[i];
            }
            return new string(array);
        }

        HashSet<string> set = new ();
        set.Add(s);
        Queue<string> queue = new ();
        queue.Enqueue(s);
        string result = s,
            current = s,
            next = s;
        while (queue.Count > 0)
        {
            current = queue.Dequeue();

            if (current.CompareTo(result) < 0)
            {
                result = current;
            }

            next = Add(current);
            if (!set.Contains(next))
            {
                set.Add(next);
                queue.Enqueue(next);
            }

            next = Rotate(current);
            if (!set.Contains(next))
            {
                set.Add(next);
                queue.Enqueue(next);
            }
        }

        return result;
    }
}
// @lc code=end


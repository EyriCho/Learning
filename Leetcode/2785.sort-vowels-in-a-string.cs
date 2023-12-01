/*
 * @lc app=leetcode id=2785 lang=csharp
 *
 * [2785] Sort Vowels in a String
 */

// @lc code=start
public class Solution {
    public string SortVowels(string s) {
        HashSet<char> set = new () {
            'A', 'E', 'I', 'O', 'U',
            'a', 'e', 'i', 'o', 'u'
        };
        Queue<int> queue = new ();
        List<char> list = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (set.Contains(s[i]))
            {
                queue.Enqueue(i);
                list.Add(s[i]);
            }
        }
        list.Sort();

        char[] array = s.ToCharArray();
        int l = 0;
        while (queue.Count > 0)
        {
            int index = queue.Dequeue();
            array[index] = list[l++];
        }

        return new string(array);
    }
}
// @lc code=end


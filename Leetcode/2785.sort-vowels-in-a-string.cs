/*
 * @lc app=leetcode id=2785 lang=csharp
 *
 * [2785] Sort Vowels in a String
 */

// @lc code=start
public class Solution {
    public string SortVowels(string s) {
        char[] array = s.ToCharArray();
        List<char> list = new () {
            'A', 'E', 'I', 'O', 'U',
            'a', 'e', 'i', 'o', 'u'
        };
        Queue<int> queue = new ();
        Dictionary<char, int> dict = new ();
        int count = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (!list.Contains(s[i]))
            {
                continue;
            }

            queue.Enqueue(i);
            dict.TryGetValue(s[i], out count);
            dict[s[i]] = count + 1;
        }

        int index = 0;
        while (queue.Count > 0)
        {
            index = queue.Dequeue();
            foreach (char c in list)
            {
                dict.TryGetValue(c, out count);
                if (count == 0)
                {
                    continue;
                }

                array[index] = c;
                dict[c]--;
                break;
            }
        }
        return new string(array);
    }
}
// @lc code=end


/*
 * @lc app=leetcode id=752 lang=csharp
 *
 * [752] Open the Lock
 */

// @lc code=start
public class Solution {
    public int OpenLock(string[] deadends, string target) {
        HashSet<string> set = new (deadends);
        if (set.Contains("0000"))
        {
            return -1;
        }
        if (target == "0000")
        {
            return 0;
        }

        Queue<string> queue = new ();

        bool CheckString(char[] a)
        {
            string s = new string(a);
            if (s == target)
            {
                return true;
            }
            if (!set.Contains(s))
            {
                set.Add(s);
                queue.Enqueue(s);
            }
            return false;
        }

        set.Add("0000");
        queue.Enqueue("0000");
        int step = 1,
            count = 0;;
        string current = null;
        char c = '\0';
        char[] array = new char[4];
        while (queue.Count > 0)
        {
            count = queue.Count;
            while (count-- > 0)
            {
                current = queue.Dequeue();
                array = current.ToCharArray();

                for (int i = 0; i < current.Length; i++)
                {
                    c = array[i];

                    if (c == '9')
                    {
                        array[i] = '8';
                        if (CheckString(array))
                        {
                            return step;
                        }
                        array[i] = '0';
                        if (CheckString(array))
                        {
                            return step;
                        }
                    }
                    else if (c == '0')
                    {
                        array[i] = '9';
                        if (CheckString(array))
                        {
                            return step;
                        }
                        array[i] = '1';
                        if (CheckString(array))
                        {
                            return step;
                        }
                    }
                    else
                    {
                        array[i] = (char)(c + 1);
                        if (CheckString(array))
                        {
                            return step;
                        }
                        array[i] = (char)(c - 1);
                        if (CheckString(array))
                        {
                            return step;
                        }
                    }

                    array[i] = c;
                }
            }

            step++;
        }
        return -1;
    }
}
// @lc code=end


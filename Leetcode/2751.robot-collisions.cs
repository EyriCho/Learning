/*
 * @lc app=leetcode id=2751 lang=csharp
 *
 * [2751] Robot Collisions
 */

// @lc code=start
public class Solution {
    public IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions) {
        (int index, int pos, int heal, char dir)[] array = new (int, int, int, char)[positions.Length];
        for (int i = 0; i < positions.Length; i++)
        {
            array[i] = (i, positions[i], healths[i], directions[i]);
        }
        Array.Sort(array, (a, b) => a.pos.CompareTo(b.pos));

        Stack<int> stack = new ();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].dir == 'R')
            {
                stack.Push(i);
                continue;
            }

            while (stack.Count > 0 && array[stack.Peek()].dir == 'R')
            {
                if (array[i].heal == array[stack.Peek()].heal)
                {
                    stack.Pop();
                    array[i].heal = 0;
                    break;
                }
                else if (array[i].heal > array[stack.Peek()].heal)
                {
                    array[i].heal--;
                    stack.Pop();
                }
                else
                {
                    array[stack.Peek()].heal--;
                    array[i].heal = 0;
                    break;
                }
            }

            if (array[i].heal > 0)
            {
                stack.Push(i);
            }
        }

        (int index, int heal)[] remains = new (int, int)[stack.Count()];
        int j = stack.Count - 1;
        while (j >= 0)
        {
            remains[j--] = (array[stack.Peek()].index, array[stack.Peek()].heal);
            stack.Pop();
        }
        Array.Sort(remains, (a, b) => a.index.CompareTo(b.index));

        int[] result = new int[remains.Length];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = remains[i].heal;
        }
        return result;
    }
}
// @lc code=end


/*
 * @lc app=leetcode id=2751 lang=csharp
 *
 * [2751] Robot Collisions
 */

// @lc code=start
public class Solution {
    public IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions) {
        (int, int, char, int)[] robots = new (int, int, char, int)[positions.Length];
        for (int i = 0; i < positions.Length; i++)
        {
            robots[i] = (positions[i], healths[i], directions[i], i);
        }
        Array.Sort(robots, (a, b) => a.Item1 - b.Item1);

        Stack<(char, int, int)> stack = new ();
        for (int i = 0; i < robots.Length; i++)
        {
            (int position, int health, char direction, int index) = robots[i];
            if (direction == 'R')
            {
                stack.Push((direction, health, index));
            }
            else
            {
                while (stack.Count > 0 &&
                    stack.Peek().Item1 == 'R' &&
                    stack.Peek().Item2 < health)
                {
                    stack.Pop();
                    health--;
                }

                if (stack.Count > 0 &&
                    stack.Peek().Item1 == 'R' &&
                    stack.Peek().Item2 == health)
                {
                    stack.Pop();
                }
                else
                {
                    if (health > 0)
                    {
                        if (stack.Count > 0 &&
                            stack.Peek().Item1 == 'R')
                        {
                            (char, int, int) last = stack.Pop();
                            stack.Push((last.Item1, last.Item2 - 1, last.Item3));
                        }
                        else
                        {
                            stack.Push((direction, health, index));
                        }
                    }
                }
            }
        }

        (int, int)[] array = new (int, int)[stack.Count];
        int j = 0;
        while (stack.Count > 0)
        {
            (char direction, int health, int index) = stack.Pop();
            array[j++] = (index, health);
        }
        Array.Sort(array, (a, b) => a.Item1 - b.Item1);
        int[] result = new int[array.Length];
        for (j = 0; j < array.Length; j++)
        {
            result[j] = array[j].Item2;
        }
        return result;
    }
}
// @lc code=end


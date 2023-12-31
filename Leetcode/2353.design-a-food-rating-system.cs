/*
 * @lc app=leetcode id=2353 lang=csharp
 *
 * [2353] Design a Food Rating System
 */

// @lc code=start
public class FoodRatings {

    private class RankStack
    {
        (int, string)[] array;
        int length;

        internal RankStack ()
        {
            array = new (int, string)[40_001];
            length = 0;
        }

        internal bool Compare((int, string) a, (int, string) b)
        {
            if (a.Item1 == b.Item1)
            {
                return string.Compare(b.Item2, a.Item2) > 0;
            }
            else
            {
                return a.Item1 > b.Item1;
            }
        }

        internal void Add(string food, int rating)
        {
            int i = length++;
            array[i] = (rating, food);
            while (i > 0)
            {
                int p = (i - 1) / 2;
                if (Compare(array[p], array[i]))
                {
                    break;
                }

                (int, string) temp = array[i];
                array[i] = array[p];
                array[p] = temp;
                i = p;
            }
        }

        internal void Pop()
        {
            int i = 0;
            array[0] = array[--length];

            while (true)
            {
                int l = i * 2 + 1,
                    r = i * 2 + 2;

                if (l >= length)
                {
                    break;
                }

                if (Compare(array[l], array[i]) ||
                    (r < length && Compare(array[r], array[i])))
                {
                    if (r >= length || Compare(array[l], array[r]))
                    {
                        (int, string) temp = array[i];
                        array[i] = array[l];
                        array[l] = temp;
                        i = l;
                    }
                    else
                    {
                        (int, string) temp = array[i];
                        array[i] = array[r];
                        array[r] = temp;
                        i = r;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        internal (int, string) Highest()
        {
            return array[0];
        }

    }

    Dictionary<string, (string, int)> foods;
    Dictionary<string, RankStack> stacks;

    public FoodRatings(string[] foods, string[] cuisines, int[] ratings) {
        this.foods = new ();
        this.stacks = new ();

        for (int i = 0; i < foods.Length; i++)
        {
            this.foods[foods[i]] = (cuisines[i], ratings[i]);

            if (!stacks.TryGetValue(cuisines[i], out RankStack stack))
            {
                stacks[cuisines[i]] = stack = new RankStack();
            }

            stack.Add(foods[i], ratings[i]);
        }
    }
    
    public void ChangeRating(string food, int newRating) {
        string cuisine = foods[food].Item1;
        stacks[cuisine].Add(food, newRating);
        
        foods[food] = (cuisine, newRating);
    }
    
    public string HighestRated(string cuisine) {
        RankStack stack = stacks[cuisine];
        (int rating, string food) = stack.Highest();
        while (foods[food].Item2 != rating)
        {
            stack.Pop();
            (rating, food) = stack.Highest();
        }

        return food;
    }
}

/**
 * Your FoodRatings object will be instantiated and called as such:
 * FoodRatings obj = new FoodRatings(foods, cuisines, ratings);
 * obj.ChangeRating(food,newRating);
 * string param_2 = obj.HighestRated(cuisine);
 */
// @lc code=end


/*
 * @lc app=leetcode id=950 lang=csharp
 *
 * [950] Reveal Cards In Increasing Order
 */

// @lc code=start
public class Solution {
    public int[] DeckRevealedIncreasing(int[] deck) {
        Array.Sort(deck);
        if (deck.Length <= 2)
        {
            return deck;
        }

        int last = 0,
            i = deck.Length - 1;
        LinkedList<int> linked = new ();
        linked.AddFirst(deck[i--]);

        for (; i >= 0; i--)
        {
            last = linked.Last();
            linked.RemoveLast();
            linked.AddFirst(last);
            linked.AddFirst(deck[i]);
        }

        i = 0;
        foreach (int card in linked)
        {
            deck[i++] = card;
        }
        return deck;
    }
}
// @lc code=end


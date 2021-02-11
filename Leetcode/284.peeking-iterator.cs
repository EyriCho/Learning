/*
 * @lc app=leetcode id=284 lang=csharp
 *
 * [284] Peeking Iterator
 */

// @lc code=start
// C# IEnumerator interface reference:
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=netframework-4.8

class PeekingIterator {
    // iterators refers to the first element of the array.
    public PeekingIterator(IEnumerator<int> iterator) {
        // initialize any member here.
        this.iterator = iterator;
        next = iterator.Current;
    }
    
    private IEnumerator<int> iterator;
    private int? next;
    
    // Returns the next element in the iteration without advancing the iterator.
    public int Peek() {
        return next.Value;
    }
    
    // Returns the next element in the iteration and advances the iterator.
    public int Next() {
        var result = next.Value;
        if (iterator.MoveNext())
            next = iterator.Current;
        else
            next = null;
        return result;
    }
    
    // Returns false if the iterator is refering to the end of the array of true otherwise.
    public bool HasNext() {
        return next.HasValue;		
    }
}
// @lc code=end


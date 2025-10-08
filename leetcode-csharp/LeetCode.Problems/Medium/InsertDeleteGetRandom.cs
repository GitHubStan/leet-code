namespace LeetCode.Problems.Medium;

public class RandomizedSet
{
    private readonly Dictionary<int, int> valueToIndex = [];
    private readonly List<int> elements = [];
    private readonly Random random = new();

    public bool Insert(int val)
    {
        if (valueToIndex.ContainsKey(val))
        {
            return false;
        }
        var insertIndex = elements.Count;
        elements.Add(val);
        valueToIndex.Add(val, insertIndex);
        return true;
    }

    public bool Remove(int val)
    {
        if (!valueToIndex.TryGetValue(val, out int index))
        {
            return false;
        }
        // The following complexity is necessary for O(1) speed.

        // move the last item in the list to the index of the removed item,
        // then delete the last item from the list 
        var lastItem = elements[^1];
        elements[index] = lastItem;
        valueToIndex[lastItem] = index;

        // remove the value from the dictionary
        elements.RemoveAt(elements.Count - 1);
        valueToIndex.Remove(val);
        return true;
    }

    public int GetRandom()
    {
        var element = random.Next(elements.Count);
        return elements[element];
    }
}
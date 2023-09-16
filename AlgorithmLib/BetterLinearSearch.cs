namespace AlgorithmLib;

public static class BetterLinearSearch
{
    public static int Search(List<IComparable> data, IComparable target)
    {
        // Set result to default (-1).
        var result = -1;
        
        // Iterate through given list 'data'
        for (int i = 0; i < data.Count; i++)
        {
            // Compare elements. If the element matches the target, assign 'result' to the index value.
            if (data[i].Equals(target))
            {
                result = i;
            }
        }
        return result;
    }
}
namespace BinarySearch;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> array = new List<int>() { 1, 7, 6, 8, 6, 9 };
        array.Sort();
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(BinarySearch(array,9));
    }

    public static int BinarySearch(List<int> sortedArray, int item)
    {
        var low = sortedArray[0];
        var high = sortedArray.Count - 1;

        //Repeat till the low and high points meet into the middle which shows
        //that the item was in the middle
        while (low <= high)
        {
            var mid = (low + high) / 2;
            var guess = sortedArray[mid];
            if (guess == item)
            {
                return mid;
            }
            if (guess > item)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return -1;
    }
}
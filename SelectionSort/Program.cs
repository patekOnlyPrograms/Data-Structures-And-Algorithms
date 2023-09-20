namespace MyNamespace;

public class Program
{
    public static void Main(string[] args)
    {
        var data = new List<int>{ 1, 5, 6, 8, 9, 90,7 };
        SelectionSortClass ss = new SelectionSortClass();
        ss.SelectionSort(data);
    }
}

public class SelectionSortClass
{
    public void SelectionSort(List<int> unsortedArray)
    {
        foreach (var item in unsortedArray)
        {
            Console.Write(item);
        }
        Console.WriteLine(Environment.NewLine);
        //selection sort starts here
        
        for (int i = 0; i < unsortedArray.Count - 1; i++)
        {
            var minimum = i; //set minimum as the first element
            for (int j = i+1; j < unsortedArray.Count; j++) //go through the list to find the next element
            {
                if (unsortedArray[j] < unsortedArray[minimum]) //if item on the right is less than the item on left
                {
                    minimum = j; //set minimum as the right
                }
            }
            //swap
            var temp = unsortedArray[i]; //create temp variable to store first
            unsortedArray[i] = unsortedArray[minimum]; //
            unsortedArray[minimum] = temp;
        }
        
        foreach (var item in unsortedArray)
        {
            Console.Write(item);
        }
    }
}
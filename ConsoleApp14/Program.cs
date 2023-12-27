{
    static void Main()
    {
        int[] arr = { 5, 2, 8, 1, 9, 3 };
        
        SortDescending(arr);
        
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
    
    static void SortDescending(int[] arr)
    {
        Array.Sort(arr);
        Array.Reverse(arr);
    }
}
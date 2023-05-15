class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1000,2,9 , 1383,-1402 ,-2 ,-9 ,-1383,456,879,-975,2508,1388,-1849 };

        ISort sorter1 = new BubbleSort();
        int[] sortedArr1 = sorter1.Sort(arr);
        Console.WriteLine("Bubble sort result: " + string.Join(", ", sortedArr1));


        ISort sorter2 = new GeneticAlgorithmSort();
        int[] sortedArr2 = sorter2.Sort(arr);
        Console.WriteLine("Genetic algorithm sort result: " + string.Join(", ", sortedArr2));

    }
}
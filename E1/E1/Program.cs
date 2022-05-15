class Program
{
    static void Main()
    {
        int NumberInputData = int.Parse(Console.ReadLine());
        Console.ReadLine();
        for (int i = 0; i < NumberInputData; i++)
        {
            int NumberOfTask = int.Parse(Console.ReadLine());
            int[] result = new int[NumberOfTask];
            int Timestart = 0;
            for (int j = 0; j < NumberOfTask; j++)
            {
                int[] inputData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                ValueTuple<int, int> tuple = new ValueTuple<int, int>(inputData[0], inputData[1]);
                if (tuple.Item1 > Timestart)
                {
                    Timestart = tuple.Item1;
                }
                Timestart = result[j] = Timestart + tuple.Item2;
            }
            Console.WriteLine(String.Join(' ', result));
            Console.ReadLine();
        }
    }
}
class Program
{
    static void Main()
    {
        int NumberInputData = int.Parse(Console.ReadLine());
        Console.ReadLine();
        for (int i = 0; i < NumberInputData; i++)
        {
            int[] inputConfigData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int NumberOfTask = inputConfigData[1];          //Количество задач
            int NumberOfThreads = inputConfigData[0];       //Количество потоков
            int[] result = new int[NumberOfTask];
            SortedList<int,int> Times = new SortedList<int,int>();
            Times.Add(0, NumberOfThreads);            
            for (int j = 0; j < NumberOfTask; j++)
            {
                int[] inputData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int StartKeyValue = Times.Keys[0];
                ValueTuple<int, int> tuple = new ValueTuple<int, int>(inputData[0], inputData[1]);
                {
                    result[j] = tuple.Item1 > StartKeyValue ?  tuple.Item1 + tuple.Item2 : StartKeyValue + tuple.Item2;
                    Times[StartKeyValue]--;
                    if(Times[StartKeyValue] == 0)
                    {
                        Times.Remove(StartKeyValue);
                    }
                    AddList(ref Times, result[j]);
                }                
            }
            Console.WriteLine(String.Join(' ', result));
            Console.ReadLine();
        }

        static void AddList(ref SortedList<int,int> Times,int TimeStart)
        {
            try
            {
                Times.Add(TimeStart, 1);
            }
            catch (ArgumentException)
            {
                Times[TimeStart]++;
            }
        }
    }
}
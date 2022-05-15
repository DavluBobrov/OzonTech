class Program
{
    static void Main()
    {
        int count = Int32.Parse(Console.ReadLine());
        int[] deltacod = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] decodingData = new int[count + 1];
        bool isFinishedleft = false;
        bool isFinishedRight = false;
        for (int i = 0; i < count + 1; i++)
        {
            if (isFinishedleft && isFinishedRight) break;
            decodingData[i] = 0;
            if (i == decodingData.Length - 1) isFinishedRight = true;
            else
                for (int j = i; j < decodingData.Length - 1; j++)
                {
                    decodingData[j + 1] = decodingData[j] + deltacod[j];
                    if (decodingData[j + 1] < 0) break;
                    if (j == decodingData.Length - 2)
                    {
                        isFinishedRight = true; break;
                    }
                }
            if (i == 0) isFinishedleft = true;
            else
                for (int j = i; j > 0; j--)
                {
                    decodingData[j - 1] = decodingData[j] - deltacod[j - 1];
                    if (decodingData[j - 1] < 0) break;
                    if (j == 1)
                    {
                        isFinishedleft = true; break;
                    }
                }
        }
        Console.WriteLine(String.Join(" ", decodingData));
    }
}
class Program
{
    static void Main()
    {
        int count = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            int priority = 1;
            int CountData = Int32.Parse(Console.ReadLine());
            var data = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            var Hashdat = data.Distinct().ToArray();
            Array.Sort(Hashdat);
            Dictionary<int, int> kvp = new Dictionary<int, int>();
            #region Заполнение словаря
            for (int j = Hashdat.Length - 1; j >= 0;)
            {
                kvp.Add(Hashdat[j], priority);
                if (j != 0 && Hashdat[j - 1] == Hashdat[j] - 1)
                {
                    kvp.Add(Hashdat[j - 1], priority);
                    j -= 2;
                }
                else
                {
                    j--;
                }
                priority++;
            }
            #endregion
            #region РАсстановка приоритетов
            for (int j = 0; j < CountData; j++)
            {
                data[j] = kvp[data[j]];
                Console.Write($"{data[j]} ");
            }
            #endregion
        }
    }
}
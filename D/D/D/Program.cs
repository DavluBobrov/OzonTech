class Program
{
    static void Main()
    {
        char[] Source = Console.ReadLine().ToArray();
        char[] Input = Console.ReadLine().ToArray();

        char[] Output = new char[Source.Length];
        Dictionary<char, int> Symbols = new Dictionary<char, int>();
        for (int i = 0; i < Output.Length; i++)
        {
            if (Symbols.ContainsKey(Source[i]))
                Symbols[Source[i]]++;
            else
                Symbols.Add(Source[i], 1);
            if (Source[i] == Input[i])
            {
                Output[i] = 'G';
                Symbols[Input[i]]--;
            }
        }
        for (int i = 0; i < Output.Length; i++)
        {
            if (Output[i] == 0)
            {
                if (Symbols.ContainsKey(Input[i]) && Symbols[Input[i]] != 0)
                {
                    Output[i] = 'Y';
                    Symbols[Input[i]]--;
                }
                else
                {
                    Output[i] = '.';
                }
            }
        }
        Console.WriteLine(Output);
    }
}
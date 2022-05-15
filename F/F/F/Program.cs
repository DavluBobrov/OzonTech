class Program
{
    static void Main()
    {
        int NumberInputData = int.Parse(Console.ReadLine());
        for (int i = 0; i < NumberInputData; i++)
        {
            int[] ColRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = ColRow[0];
            int m = ColRow[1];
            char[][] Pool = new char[n][];
            for (int j = 0; j < n; j++)
            {
                Pool[j] = Console.ReadLine().ToCharArray();
            }
            #region Роняем плитки
            int empty = 0;
            for (int ii = 0; ii < m; ii++)
            {
                for (int jj = 0; jj < n; jj++)
                {
                    if (Pool[jj][ii] == '.')
                    {
                        empty++;
                    }
                }
                for (int jj = 0; jj < n; jj++)
                {
                    if (jj < empty) Pool[jj][ii] = '.';
                    else Pool[jj][ii] = '*';
                }
                empty = 0;
            }
            #endregion
            #region Заполняем воду
            int BlockStartIndex = 0;
            int BlockEndIndex = 0;
            bool isBlock = false;
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < m; row++)
                {
                    if (Pool[col][row] == '*')
                    {
                        if (!isBlock)
                        {
                            isBlock = true;
                            BlockStartIndex = row;
                        }
                        else
                        {
                            BlockEndIndex = row;
                            for(int j = BlockStartIndex + 1; j < BlockEndIndex; j++)
                            {
                                Pool[col][j] = '~';
                            }
                            BlockStartIndex = BlockEndIndex;
                        }
                    }
                }
            }
            #endregion
            Print(Pool);
            Console.WriteLine();
        }
    }

    private static void Print(char[][] Pool)
    {
        foreach (var item in Pool)
        {
            Console.WriteLine(item);
        }
    }
}
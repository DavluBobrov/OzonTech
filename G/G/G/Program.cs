class Program
{
    static void Main()
    {
        int NumberInputData = int.Parse(Console.ReadLine());
        for (int i = 0; i < NumberInputData; i++)
        {
            Console.ReadLine();
            char[][] GameField = new char[3][];
            for (int j = 0; j < 3; j++)
            {
                GameField[j] = Console.ReadLine().ToCharArray();
            }
            short X = 0;
            short O = 0;
            bool isWinX = false;
            bool isWin0 = false;
            bool result = true;
            for (int ii = 0; ii < 3; ii++)
            {
                for (int jj = 0; jj < 3; jj++)
                {
                    if (GameField[ii][jj] == 'X')
                        X++;
                    else
                        if (GameField[ii][jj] == '0')
                        O++;
                }
            }
            if (Math.Abs(X - O) > 1 || X < O)
            {
                result = false;
                PrintRresult(result);
                continue;
            }
            else
            {
                for (int row = 0; row < 3; row++)
                {
                    if (GameField[row][0] == GameField[row][1] && GameField[row][1] == GameField[row][2])
                        if (GameField[row][0] == 'X')
                        {
                            isWinX = true;
                        }
                        else
                        if (GameField[row][0] == '0')
                        {
                            isWin0 = true;
                        }
                }
                for (int column = 0; column < 3; column++)
                {
                    if (GameField[0][column] == GameField[1][column] && GameField[1][column] == GameField[2][column])
                        if (GameField[0][column] == 'X')
                        {
                            isWinX = true;
                        }
                        else
                        if (GameField[0][column] == '0')
                        {
                            isWin0 = true;
                        }
                }
                if (GameField[0][0] == GameField[1][1] && GameField[1][1] == GameField[2][2])
                {
                    if (GameField[1][1] == 'X')
                    {
                        isWinX = true;
                    }
                    else
                    if (GameField[1][1] == '0')
                    {
                        isWin0 = true;
                    }
                }
                if (GameField[2][0] == GameField[1][1] && GameField[1][1] == GameField[0][2])
                    if (GameField[1][1] == 'X')
                    {
                        isWinX = true;
                    }
                    else
                    if (GameField[1][1] == '0')
                    {
                        isWin0 = true;
                    }

                if (isWinX && X == O)
                {
                    result = false;
                    PrintRresult(result);
                    continue;
                }
                if (isWin0 && X > O)
                {
                    result = false;
                    PrintRresult(result);
                    continue;
                }
                result = isWinX && isWin0 ? false : true;
            }
            PrintRresult(result);
        }
    }

    private static void PrintRresult(bool result)
    {
        Console.WriteLine(result ? "YES" : "NO");
    }
}
class Parser
{
    static void Main()
    {
        var ETALON = File.ReadAllLines("07.a");
        using (StreamReader sw = new StreamReader("07"))
        {
            int NumberInputData = Int32.Parse(sw.ReadLine());
            for (int i = 0; i < NumberInputData; i++)
            {
                sw.ReadLine();
                char[][] GameField = new char[3][];
                for (int j = 0; j < 3; j++)
                {
                    GameField[j] = sw.ReadLine().ToCharArray();
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
                    //PrintRresult(result);

                    VerifyResult(result, ETALON[i], i);
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
                        if (isWinX)
                        {
                            result = false;

                            VerifyResult(result, ETALON[i], i);
                            //PrintRresult(result);
                            continue;
                        }
                    if (isWin0 && X > O)
                    {
                        result = false;

                        VerifyResult(result, ETALON[i], i);
                        //PrintRresult(result);
                        continue;
                    }
                    result = isWinX && isWin0 ? false : true;
                }
                //PrintRresult(result);
                VerifyResult(result, ETALON[i], i);
            }
            Console.ReadLine();
        }
    }

    private static void VerifyResult(bool result, string Etalon, int i)
    {
        string verify = result ? "YES" : "NO";
        if (verify != Etalon) Console.WriteLine($"{i} is false");
    }

    private static void PrintRresult(bool result)
    {
        Console.WriteLine(result ? "YES" : "NO");
    }


}
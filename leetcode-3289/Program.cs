class leetcode
{
    public static int[] GetSneakyNumbers(int[] numbers)
    {
        int num = numbers.Length - 2;
        bool[] verify = new bool[num];
        List<int> sneakyNumbers = new List<int>();

        foreach (var n in numbers)
        {
            if (verify[n])
            {
                sneakyNumbers.Add(n);
            }
            else
            {
                verify[n] = true;
            }
        }
        return sneakyNumbers.OrderBy(n => n).ToArray();
    }

    public static void Main(string[] args)
    {
        int[] exempleOne = [0, 1, 1, 0];
        var get1 = GetSneakyNumbers(exempleOne);
        System.Console.WriteLine($"[{string.Join(",", get1)}]");

        int[] exempleTwo = [0, 3, 2, 1, 3, 2];
        var get2 = GetSneakyNumbers(exempleTwo);
        System.Console.WriteLine($"[{string.Join(",", get2)}]");

        int[] exempleThree = [7, 1, 5, 4, 3, 4, 6, 0, 9, 5, 8, 2];
        var get3 = GetSneakyNumbers(exempleThree);
        System.Console.WriteLine($"[{string.Join(",", get3)}]");
    }
}

class Program
{
    static void Main()
    {
        int count = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            var data = Console.ReadLine().Split(' ');
            Console.WriteLine(Int32.Parse(data[0]) + Int32.Parse(data[1]));
        }
    } 
}
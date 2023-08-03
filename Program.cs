internal static class Program
{
    internal static void Main(string[] args)
    {
        var input = Console.ReadLine();

        int r = 0;
        for (var i = 0; i < input.Length; ++i)
        {
            var c = input[i];

            var n = c == ' '
                ? 26
                : (int)c - (int)'A';

            n += r;

            var d = n / 9;
            r = n % 9;

            Console.Write((char)d);
        }

        Console.WriteLine("");
    }
}

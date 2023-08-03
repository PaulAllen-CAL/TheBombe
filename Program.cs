internal static class Program
{
    internal static void Main(string[] args)
    {
        // var input = Console.ReadLine();
        var input = args[0];
        var divisor = int.Parse(args[1]);

        int r = 0;
        for (var i = 0; i < input.Length; ++i)
        {
            var c = input[i];

            var n = c == ' '
                ? 26
                : (int)c - (int)'A';

            n += (r * 27);

            var d = n / divisor;
            r = n % divisor;

            Console.Write(d == 26 ? ' ' : (char)(d + (int)'A'));
        }

        Console.WriteLine("");
    }
}

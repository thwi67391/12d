namespace HenningsenLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(string.Format("{0} {1} {2}", i, i + 1, i + 2));
            }
        }
    }
}

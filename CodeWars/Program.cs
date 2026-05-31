namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)        
        {
            Console.WriteLine(string.Join(' ', ArrayDiff.ArrayDiffM(new int[] { 1, 2, 3 }, new int[] { 1, 2 })));
        }
    }
}

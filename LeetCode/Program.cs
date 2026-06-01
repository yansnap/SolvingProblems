namespace LeetCode
{
    internal class Program
    {
        static void Main()
        {
            MoveZeroes moveZeroes = new MoveZeroes();
            Console.WriteLine(string.Join(", ", moveZeroes.MoveZeroesM(new int[] {0,1,0,3,12})));
        }
    }
}

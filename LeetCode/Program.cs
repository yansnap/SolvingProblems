namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CanIPlaceFlowers CPF = new CanIPlaceFlowers();
            Console.WriteLine(string.Join(", ", CPF.CanPlaceFlowers(new int[] {1,0,0,0,1}, 2)));
        }
    }
}

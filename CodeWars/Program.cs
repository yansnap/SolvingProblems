namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)        
        {

            string[] strings = new string[] { "Alex", "Jacob", "Mark", "Max" };
            Console.WriteLine(string.Join(' ', WhoLikesIt.Likes(strings)));

        }
    }
}

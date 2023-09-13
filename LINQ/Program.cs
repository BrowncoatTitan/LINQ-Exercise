namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>() { "Fallout", "Halo", "Fable", "World of Warcraft" };
            var sortedGames = videoGames.OrderBy(x => x.Length);
            foreach (var videoGame in sortedGames)
            {
                Console.WriteLine(videoGame);
            }
        }
    }
}

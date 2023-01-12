namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string> { "Super Mario World", "Mortal Kombat", "The Legend of Zelda", "Street Fighter", "Donkey Kong Country", "Mario Kart" };


            IEnumerable<string> gamesOrdered = videoGames.OrderByDescending(x => x.Length);

            foreach (string game in gamesOrdered)
            {
                Console.WriteLine(game);
            }

        }
    }
}

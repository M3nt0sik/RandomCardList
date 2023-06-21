using Game_Card;

internal class Program
{
    private static void Main(string[] args)
    {
        
        List<Card> ListCard = new List<Card>();

        for(int i= 0; i < random.Next(1, 15); i++)
        {
            ListCard.Add(RandomCard(random));
        }
        
        PrintCards(ListCard);

        
    }
    static Random random = new Random();

    static Card RandomCard( Random rand)
    {
        Card card = new Card((EValue)rand.Next(1, 14), (ESuit)rand.Next(4));
        return card;

    }

    static void PrintCards(List<Card> cards)
    {
        int i = cards.Count;
        for(int j =0; j < i; j++)
        {
            Console.WriteLine($"{j}: {cards[j].Name}");
        }
    }
}
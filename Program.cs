using Game_Card;
using RandomCardList;

internal class Program
{
    private static void Main(string[] args)
    {
        //Creade new list of Card object
        List<Card> ListCard = new List<Card>();
        // add random value cards to list
        for(int i= 0; i < random.Next(1, 15); i++)
        {
            ListCard.Add(RandomCard(random));
        }
        //Show in terminal content of list
        PrintCards(ListCard);
        Console.WriteLine("Cards now are sorted:");
        //Sort cards into list
        CardComparerByValue sortCard = new CardComparerByValue();
        ListCard.Sort(sortCard);
        //Show in terminal content of list
        PrintCards(ListCard);

        
    }
    //object class Random available for all sub functions 
    static Random random = new Random();
    //static functions to add Card object to list 
    static Card RandomCard( Random rand)
    {
        Card card = new Card((EValue)rand.Next(1, 14), (ESuit)rand.Next(4));
        return card;

    }
    //static functions to show contents list on screen
    static void PrintCards(List<Card> cards)
    {
        int i = cards.Count;
        for(int j =0; j < i; j++)
        {
            Console.WriteLine($"{j}: {cards[j].Name}");
        }
    }
}
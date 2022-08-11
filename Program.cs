public class Program
{

    public static void Main()
    {

        string? metalType = Console.ReadLine();

        switch (metalType)
        {
            case "iron":
                Console.WriteLine("Good against monsters");
                break;

            case "gold":
                Console.WriteLine("Good for luring the other kind of monster");
                break;

        }

    }

}
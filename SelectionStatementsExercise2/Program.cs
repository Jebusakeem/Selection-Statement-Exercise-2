namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your favorite subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is great because it is consistent");
                    break;
                case "science":
                    Console.WriteLine("Science holds many interesting mysteries");
                    break;
                case "english":
                    Console.WriteLine("English is the 3rd most spoken native language");
                    break;
                case "history":
                    Console.WriteLine("History is the backbone of culture");
                    break;
                case "spanish":
                    Console.WriteLine("Spanish is the 2rd most spoken native language");
                    break;
                default:
                    Console.WriteLine($"I bet a lot of people like {favoriteSubject} ");
                    break;
            }
        }
    }
}
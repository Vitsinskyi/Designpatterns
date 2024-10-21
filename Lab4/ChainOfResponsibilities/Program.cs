namespace ChainOfResponsibilities;

internal class Program
{
    public static void Main(string[] args)
    {
        // Створення обробників
        SupportHandler levelOneHandler = new LevelOneSupportHandler();
        SupportHandler levelTwoHandler = new LevelTwoSupportHandler();
        SupportHandler levelThreeHandler = new LevelThreeSupportHandler();
        SupportHandler levelFourHandler = new LevelFourSupportHandler();
        
        levelOneHandler.SetNextHandler(levelTwoHandler);
        levelTwoHandler.SetNextHandler(levelThreeHandler);
        levelThreeHandler.SetNextHandler(levelFourHandler);
        
        SupportRequest request = new SupportRequest();

        do
        {
            Console.WriteLine("Please answer the following questions (Yes/No):");
            request.Question = "Are you connected to the internet?";
            request.Answer = GetAnswerFromUser(request.Question);
            levelOneHandler.HandleRequest(request);
            
            request.Question = "Is your device charged?";
            request.Answer = GetAnswerFromUser(request.Question);
            levelOneHandler.HandleRequest(request);

            request.Question = "Have you restarted your device?";
            request.Answer = GetAnswerFromUser(request.Question);
            levelOneHandler.HandleRequest(request);

            request.Question = "Is the issue related to a hardware problem?";
            request.Answer = GetAnswerFromUser(request.Question);
            levelOneHandler.HandleRequest(request);
            
        } while (!GetAnswerFromUser("Would you like to close the program? (Yes/No)"));
    }

    static bool GetAnswerFromUser(string question)
    {
        string? input;
        do
        {
            Console.WriteLine(question);
            Console.Write("Your answer: ");
            input = Console.ReadLine()?.Trim().ToLower();
        } while (input != "yes" && input != "no");

        return input == "yes";
    }
}
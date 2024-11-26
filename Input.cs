namespace par_programmering_02
{
    public class Bot
    {
        public string Name;
        public List<string> Answers = new List<string>();

        public void PromptName()
        {
            Console.Write("Write the name of your chatbot: ");
            Name = Console.ReadLine() ?? "";
        }

        public void PromptPossibleAnswers()
        {
            Console.WriteLine("\nEnter a blank character [Enter] to stop giving answers!");

            while (true)
            {
                Console.Write("Write some answers for your bot!: ");
                var userInput = Console.ReadLine();
                if (userInput != "")
                {
                    Answers.Add(userInput);
                }
                else
                {
                    break;
                }
            }
        }

        public string GetMenuSelect()
        {
            string option;

            do
            {
                Console.WriteLine("\nWelcome!\nChoose your option!\n[1] Create a chatbot\n[2] Chat with chatbot");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        return "1";
                    case "2":
                        return "2";
                    default:
                        Console.WriteLine("NOT AN OPTION, TRY AGAIN. PLEASE.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }
            }
            while (true);

        }

        public string GetRandomAnswer()
        {
            Random rand = new Random();
            int index = rand.Next(0, Answers.Count);
            return Answers[index];
        }

        public void Chat()
        {
            Console.WriteLine("\nStart chatting with your bot! Ask a question!");
            Console.WriteLine("\nType 'Bye!' to stop chatting!");

            while (true)
            {
                var userInput = Console.ReadLine();
                if (userInput != "Bye!")
                {
                    Console.WriteLine($"You wrote: {userInput}");
                    Console.WriteLine($"{Name} wrote: {GetRandomAnswer()}");
                }
                else
                {
                    break;
                }
            }
        }
    }
}

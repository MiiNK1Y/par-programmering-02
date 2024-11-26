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

        public int GetMenuSelect()
        {
            int option;

            do
            {
                Console.WriteLine("\nWelcome!\nCoose your option!\n[1] Create a chatbot\n[2] Chat with chatbot");
                var o = Console.ReadLine();

                try
                {
                    option = Int32.Parse(o);
                }
                catch (FormatException)
                {
                    Console.WriteLine("NOT A NUMBER, TRY AGAIN!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

                //try
                //{
                //    guessNum = Int32.Parse(guess);
                //}
                //// if the input is anything but a number.
                //catch (FormatException)
                //{
                //    CleanConsole(1);
                //    continue;
                //}

                if (option != 1 || option != 2)
                {
                    Console.WriteLine("You need to choose between either [1] or [2]!");
                    Console.Clear();
                }
            }
            while (option != 1 || option != 2);

            Console.WriteLine($"You chose {option}");
            return option;
        }
    }
}

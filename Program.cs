// CURRENTLY CAN'T CREATE NEW BOTS, ONLY RENAME THE ORIGINAL AND ADD TO THE ANSWER-LIST.
// OUT OF TIME


using par_programmering_02;

Console.Clear();

// Create an instance of a bot
Bot bot_1 = new Bot();

string currentSelected;

while (true)
{
    // Get the name of the bot
    bot_1.PromptName();
    Console.WriteLine($"Bot name: {bot_1.Name}");

    // Give input to bot to get later as answers
    bot_1.PromptPossibleAnswers();
    // Clean the console after getting answers
    Console.Clear();

    currentSelected = bot_1.GetMenuSelect();

    if (currentSelected == "1")
    {
        // Rename the original bot / restart
        Console.Clear();
        continue;
    }
    else if (currentSelected == "2")
    {
        // ChatLoop
        bot_1.Chat();
    }
}


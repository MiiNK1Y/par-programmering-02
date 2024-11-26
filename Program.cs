// # PP- Oppgaver Uke 3!
//2) **Chættbått’n**
//Du skal lage en app hvor man kan lage sin egen chatbot - og deretter velge å snakke med den 🙂
//Brukeren skal få prompt på chættbått navn, og deretter mulighet til å skrive inn forskjellige tilbakemeldinger/ svar som chættbått’n skal trekke et tilfeldig svar fra og svare brukeren med når den startes opp.
//Bruk gjerne en meny for å gå inn i de forskjellige modusene: “mekke en chættbått” og “preke med en chættbått”
//***BONUS:***
//Mulighet til å lage flere chættbåtts, brukeren skal kunne se en liste av tilgjengelige chættbåtts og velge hvem h*n vil snakke med - her må det brukes List fra neste ukes pensum. 
//
//*Lykke til!*

using par_programmering_02;

Console.Clear();

// Create an instance of a bot
Bot bot_1 = new Bot();

// Get the name of the bot
bot_1.PromptName();
Console.WriteLine($"Bot name: {bot_1.Name}");

// Give input to bot to get later as answers
bot_1.PromptPossibleAnswers();
Console.Clear();

// Print menu
int currentSelected = bot_1.GetMenuSelect();

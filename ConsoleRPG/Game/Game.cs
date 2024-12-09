public class Game
{
    static bool skipIntro = false;
    static bool skipRegister = true;

    static Player? player;

    public static void Main(string[] args) {
        Startup();

        Console.Read();
    }

    static void Startup() {
        Console.Title = "CrystalGames' ConsoleRPG";
        if (!skipIntro)StartIntro();

        if (!skipRegister) {
            player = new Player(null, null, null, null, null);
            PlayerDataManager.RegisterCharacter(player);
        }



    }

    static void StartIntro() {
        Console.WriteLine("Getting Things Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Processing Data...");
        Thread.Sleep(1500);
        Console.WriteLine("Finishing Things Up...");
        Thread.Sleep(1750);
        Console.Clear();
        #region Logo
        Console.WriteLine("=======================================================================");
        Thread.Sleep(350);
        Console.WriteLine("\r _____                _        _ _____                           \r");
        Thread.Sleep(350);
        Console.WriteLine("/  __ \\              | |      | |  __ \\                          \r");
        Thread.Sleep(350);
        Console.WriteLine("| /  \\/_ __ _   _ ___| |_ __ _| | |  \\/ __ _ _ __ ___   ___  ___ \r");
        Thread.Sleep(350);
        Console.WriteLine("| |   | '__| | | / __| __/ _` | | | __ / _` | '_ ` _ \\ / _ \\/ __|\r");
        Thread.Sleep(350);
        Console.WriteLine("| \\__/\\ |  | |_| \\__ \\ || (_| | | |_\\ \\ (_| | | | | | |  __/\\__ \\\r");
        Thread.Sleep(350);
        Console.WriteLine(" \\____/_|   \\__, |___/\\__\\__,_|_|\\____/\\__,_|_| |_| |_|\\___||___/\r");
        Thread.Sleep(350);
        Console.WriteLine("             __/ |                                               \r");
        Thread.Sleep(350);
        Console.WriteLine("            |___/                                                \r");
        Thread.Sleep(350);
        Console.WriteLine(" _____                       _     ____________ _____            \r");
        Thread.Sleep(350);
        Console.WriteLine("/  __ \\                     | |    | ___ \\ ___ \\  __ \\           \r");
        Thread.Sleep(350);
        Console.WriteLine("| /  \\/ ___  _ __  ___  ___ | | ___| |_/ / |_/ / |  \\/           \r");
        Thread.Sleep(350);
        Console.WriteLine("| |    / _ \\| '_ \\/ __|/ _ \\| |/ _ \\    /|  __/| | __            \r");
        Thread.Sleep(350);
        Console.WriteLine("| \\__/\\ (_) | | | \\__ \\ (_) | |  __/ |\\ \\| |   | |_\\ \\           \r");
        Thread.Sleep(350);
        Console.WriteLine(" \\____/\\___/|_| |_|___/\\___/|_|\\___\\_| \\_\\_|    \\____/           \r"); Thread.Sleep(350);
        Console.WriteLine("=======================================================================");
        Thread.Sleep(250);
        Console.WriteLine("Press anything to continue");
        Console.ReadKey();
        Console.Clear();
        #endregion
    }
}
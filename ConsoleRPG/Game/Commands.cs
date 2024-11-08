public class Commands
{
    public static void CheckForCommand(string text) {
        string[] words = text.Split(text, ' ');
        switch (words[0].ToUpper()) {
            case "EXIT":
                Environment.Exit(0);
                break;
        }
    }
}
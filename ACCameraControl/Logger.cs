#if DEBUG

public static class Logger
{
    /// <summary>
    /// 输出带时间戳的日志信息，并根据类型上色。
    /// </summary>
    /// <param name="type">日志类型：I(信息)、W(警告)、E(错误)、D(调试)</param>
    /// <param name="message">日志内容</param>
    public static void Log(char type, string message)
    {
        string timestamp = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
        char typeUpper = char.ToUpper(type);

        ConsoleColor originalColor = Console.ForegroundColor;

        switch (typeUpper)
        {
            case 'I':
                Console.ForegroundColor = ConsoleColor.Cyan;
                break;
            case 'O':
                Console.ForegroundColor = ConsoleColor.White;
                break;
            case 'W':
            case 'S':
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case 'E':
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case 'D':
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            default:
                typeUpper = 'D';
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
        }
        Console.WriteLine($"[{timestamp}][{typeUpper}] {message}");
        Console.ForegroundColor = originalColor;
    }
}

#endif
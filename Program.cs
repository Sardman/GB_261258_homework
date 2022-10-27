class GB_261258_homework_project
{
    static Random rnd = new Random();
    static int array_lenght = rnd.Next(2, 20);
    static string[] text_array = new string[array_lenght];
    const string symbols_collection = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

    private static void FillArray()
    {
        for (int i = 0; i != array_lenght; i++)
            text_array[i] = FillString();
    }

    private static string FillString()
    {
        char rndchar;
        string a = "";
        int string_lenght = rnd.Next(5, 15);
        for (int i = 0; i != string_lenght; i++)
        {
            rndchar = symbols_collection.Substring(rnd.Next(0, 61), 1).ToCharArray()[0];
            a += rndchar;
        }
        return a;
    }

    private static void ParceArray()
    {

    }

    private static string ParceString(string a)
    {
        return a;
    }

    private static void PrintArray()
    {

    }

    static void Main()
    {
        FillArray();
        Console.WriteLine("Массив до обработки: \n");
        PrintArray();
        ParceArray();
        Console.WriteLine("Массив после обработки: \n");
        PrintArray();
    }
}
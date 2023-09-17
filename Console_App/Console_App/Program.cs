using Console_App;

internal class Program
{
    private static void Main(string[] args)
    {
        islem isl = new();
        isl.topla(7,6);
        isl.topla(2,15);


        Console.WriteLine("\n \n \n ");


        isl.kare(6);
        Console.Read();
    }
}
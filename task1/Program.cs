internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter text: ");

        string text = Convert.ToString(Console.ReadLine());
        char[] obrtext = text.ToCharArray();
        Array.Reverse(obrtext);
        string finaltext = new string(obrtext);

        if(finaltext == text){
            Console.WriteLine( "yes");
        }
        if (finaltext != text){
            Console.WriteLine("NO");
        }
        //Console.WriteLine();

    }
}
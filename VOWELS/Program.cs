namespace vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Vowels :");
            char input = char.ToLower(Convert.ToChar(Console.ReadLine()));
            if(input=='a' || input=='e' || input=='i' || input=='o' || input=='u')
            {
                Console.Write("The given word is Vowel");
            }
            else
            {
                Console.Write("This is not an Vowels");
                Console.ReadLine();
            }
        }
    }
}

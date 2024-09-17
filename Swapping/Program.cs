namespace swap2no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, k;
            Console.WriteLine("Enter the two numbers");
            i = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Before swapping i={0} and k={1}", i, k);
            i = i ^ k;
            k = i ^ k;
            i = i ^ k;
            Console.Write("After swapping i={0} and k={1}", i, k);
            Console.ReadLine();
        }
    }
}

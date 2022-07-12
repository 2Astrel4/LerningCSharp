namespace AkademyCifra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string name = "Astrel";
            Console.WriteLine("Hello, World!" + Environment.NewLine);
            Console.WriteLine(name);
            while (i < 10)
            {
                Console.WriteLine("!");
                i++;
            }
        }
    }
}
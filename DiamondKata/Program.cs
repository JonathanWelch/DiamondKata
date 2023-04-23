namespace DiamondKata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("A single letter of the alphabet is required to print a diamond.");
                return;
            }
            
            var diamond = new Diamond();
            var diamondString = diamond.Create(char.Parse(args[0]));

            Console.WriteLine(diamondString);
        }
    }
}

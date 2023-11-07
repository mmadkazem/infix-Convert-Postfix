namespace infix
{
    class Program
    {
        static void Main(string[] args)
        {           
            System.Console.Write("Enter your Infix phrase: ");
            string infix = System.Console.ReadLine();
            string postfix = ConvetInfix.ConvertToPostfix(infix);
            System.Console.WriteLine(postfix);
            System.Console.WriteLine(Compute.CalculatePostfix(postfix));
        }
    }
}

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            BankAccount acc1 = new BankAccount();

            Console.WriteLine("How much money will you be depositing today?");
            var input = double.Parse(Console.ReadLine());
            acc1.Deposit(input);
            acc1.GetBalance(); 
        }
    }
}

namespace _04_Banka;

class Program
{
    static void Main(string[] args)
    {
        ATM local_atm = new(100000);
        Bank my_account = new(local_atm);
        my_account.Login();
        Console.ReadKey();
    }
}

using System.Diagnostics.Tracing;
using System.Net;
using System.Net.NetworkInformation;

namespace _04_Banka;

class Bank
{
    
    private string account_owner, name, surname, PIN;
    private int account_ID;
    private double money_balance;
    public Bank()
    {
        SetName();
        Console.WriteLine();
        SetPIN();
    }
    private void SetName()
    {
        Console.WriteLine("Enter your name:");
        name = Console.ReadLine();
        Console.WriteLine("Enter your surname:");
        surname = Console.ReadLine();
        account_owner = name + " " + surname;
        Console.WriteLine($"Your name is {account_owner}");
    }
    private void SetPIN()
    {
        Console.WriteLine("Enter your PIN:");
        PIN = "";
        while(PIN.Length < 4)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            char keyPressed = keyInfo.KeyChar;

            if (char.IsDigit(keyPressed))
            {
                PIN += keyPressed;
                Console.Write("*");
            }
            else if (keyInfo.Key == ConsoleKey.Backspace)
            {
                if (PIN.Length == 0)
                {
                    continue;
                }
                PIN = PIN.Substring(0, PIN.Length - 1);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Console.Write("\b");
                Console.Write(" ");
                Console.Write("\b");
            } 
            else
            {
                continue;
            }
            // TODO: program se zavre hned po zadani 4teho cisla a neda se smazat
        }
    }
}
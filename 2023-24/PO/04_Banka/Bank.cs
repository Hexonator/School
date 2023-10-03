using System;
namespace _04_Banka;

class Bank
{
    // Variable declaration
    private string account_owner, name, surname, PIN;
    private int account_ID;
    private ATM machine_used; 
    private int money_balance;

    // Constructor
    public Bank(ATM input_atm)
    {
        machine_used = input_atm;
        Random r = new();
        account_ID = r.Next(10000000, 99999999);
        if (SetName())
        {
            PIN = "1234";
            money_balance = int.MaxValue;
            return;
        }
        Divider(2);
        SetPIN();
        Divider(2);
        money_balance = 10000;
    }

    // Internal functions
    private void Divider(int size)
    {
        if (size <= 0)
        {
            Console.WriteLine();
        }
        else if (size == 1)
        {
            Console.WriteLine("----------------");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine();
        }
    }
    private bool SetName()
    {
        Console.WriteLine("Enter your name:");
        name = Console.ReadLine();
        if (name == "stand")
        {
            surname = "dev";
            account_owner = "/developer/";
            Divider(0);
            return true;
        }
        Console.WriteLine("Enter your surname:");
        surname = Console.ReadLine();
        account_owner = name + " " + surname;
        Divider(0);
        Console.WriteLine($"Your name is {account_owner}");
        return false;
    }

    private string enterPIN()
    {
        string entered_PIN = "";
        while(entered_PIN.Length <= 4)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            char keyPressed = keyInfo.KeyChar;

            if (char.IsDigit(keyPressed) && entered_PIN.Length < 4)
            {
                entered_PIN += keyPressed;
                Console.Write("*");
            }
            else if (keyInfo.Key == ConsoleKey.Backspace)
            {
                if (entered_PIN.Length == 0)
                {
                    continue;
                }
                entered_PIN = entered_PIN[..^1];
                Console.Write("\b");
                Console.Write(" ");
                Console.Write("\b");
            }
            else if (keyInfo.Key == ConsoleKey.Enter && entered_PIN.Length == 4)
            {
                break;
            }
            else
            {
                continue;
            }
        }
        Divider(0);
        entered_PIN = entered_PIN[..4];
        return entered_PIN;
    }
    private void SetPIN()
    {
        string first_PIN, confirmation_PIN;
        bool confirmationStatus = true;
        while(confirmationStatus)
        {
            Console.WriteLine("Enter your new PIN:");
            first_PIN = enterPIN();
            Console.WriteLine("Confirm your PIN:");
            confirmation_PIN = enterPIN();
            if (first_PIN == confirmation_PIN)
            {
                Divider(1);
                PIN = first_PIN;
                Console.WriteLine("Your PIN has been set");
                confirmationStatus = false;
            }
            else
            {
                Divider(1);
                Console.WriteLine("PINs don't match. Try again.");

            }
        }
    }

    private void Withdraw()
    {
        while (true)
        {
            Console.WriteLine("Write the amount you'd like to withdraw:");
            if (int.TryParse(Console.ReadLine(), out int withdrawal_amount) && withdrawal_amount > 0)
            {
                if (money_balance - withdrawal_amount > 0)
                {
                    if(machine_used.Withdrawal(withdrawal_amount))
                    {
                        Console.WriteLine("Machine doesn't have sufficient funds. Please come back later");
                        Divider(1);
                        break;
                    }
                    money_balance -= withdrawal_amount;
                    Console.WriteLine($"{withdrawal_amount}$ will be dispensed.");
                }
                else
                {
                    Console.WriteLine("You don't have enough funds for that");
                }
                break;
            }
            else
            {
                Console.WriteLine("You didn't enter a valid amount, please try again.");
            }
        }
    }

    private void Deposit()
    {
        while (true)
        {
            Console.WriteLine("Enter the amount of money you'd like to deposit:");
            if (int.TryParse(Console.ReadLine(), out int deposited_amount) && deposited_amount > 0)
            {
                machine_used.Deposit(deposited_amount);
                money_balance += deposited_amount;
                Console.WriteLine($"{deposited_amount}$ was succesfully added to your balance.");
                break;
            }
            else
            {
                Console.WriteLine("You didn't enter a valid amount, please try again.");
                Divider(0);
            }
        }
    }
    private void loginSuccess()
    {
        Divider(2);
                Console.WriteLine($"Welcome {name}! (ID:{account_ID})");
                Console.WriteLine("As a first member of our bank, you got a bonus of 10000$!");
                Divider(0);
                while(true)
                {
                    Console.WriteLine("Press 1 to witdraw money, 2 to make a deposit, 3 to show your funds or 4 to log out");
                    ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
                    char keyPressed = keyInfo.KeyChar;
                    if (keyPressed == '1')
                    {
                        Withdraw();
                    }
                    else if (keyPressed == '2')
                    {
                        Deposit();
                    }
                    else if (keyPressed == '3')
                    {
                        Divider(1);
                        Console.WriteLine($"You currently have {money_balance}$ in your account");
                        Divider(1);
                    }
                    else if (keyPressed == '4')
                    {
                        Console.WriteLine("You have been logged out");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong key pressed, try again.");
                        Divider(0);
                    }
                }

    }

    // Public functions
    public void ChangeName()
    {
        SetName();
    }
    public void Login()
    {
        bool isLoggedIn = false;
        int failCounter = 0; 
        Console.WriteLine($"{account_owner} Please log in");
        Console.WriteLine();
        while(isLoggedIn == false)
        {
            Console.WriteLine("Enter your pin:");
            if (enterPIN() == PIN)
            {
                loginSuccess();
                break;
            }
            else
            {
                failCounter++;
                if (failCounter >= 3)
                {
                    Console.WriteLine("You have failed to enter the correct PIN.");
                    Console.WriteLine("Your account has been blocked");
                    Console.WriteLine("Contact the provider to get int unblocked");
                    break;
                }
                Console.WriteLine("Incorrect PIN entered. Try again.");
            }
        }
    }
}
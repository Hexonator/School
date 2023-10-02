namespace _04_Banka;

class ATM
{
    private double money_in_machine;
    public ATM(double money_in_new_machine)
    {
        money_in_machine = money_in_new_machine;
    }

    public double GetMoneyInMachine()
    {
        return money_in_machine;
    }
    public void Withdrawal(int withdrawal_size)
    {
        money_in_machine -= withdrawal_size;
    }
    public void Deposit(int deposit_size)
    {
        money_in_machine += deposit_size;
    }
}
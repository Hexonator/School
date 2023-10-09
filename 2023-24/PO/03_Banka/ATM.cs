namespace _04_Banka;

class ATM
{
    private int money_in_machine, machine_id;
    public ATM(int money_in_new_machine)
    {
        money_in_machine = money_in_new_machine;
        Random r = new();
        machine_id = r.Next(10000000, 99999999);
    }

    public int GetMoneyInMachine()
    {
        return money_in_machine;
    }
    public int GetMachineID()
    {
        return machine_id;
    }
    public bool Withdrawal(int withdrawal_size)
    {
        if (money_in_machine - withdrawal_size > 0)
        {
            return false;
        }
        else
        {
            money_in_machine -= withdrawal_size;
            return true;
        }
    }
    public void Deposit(int deposit_size)
    {
        money_in_machine += deposit_size;
    }
}
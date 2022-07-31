using ATMClassLibrary;

void Auth(object sender, AtmAuthEventArgs e)
{
    Console.WriteLine($"Authentication {e.Result}.") ;
}
void ShowBalance(object sender, AtmBalanceEventArgs e)
{
    Console.WriteLine($"Your Balance: {e.Balance}");
}
void WithdrawMoney(object sender, AtmWithdrawEventArgs e)
{
    if (e.Result)
        Console.WriteLine($"{e.Sum} is debited from your balance.");
    else
        Console.WriteLine("Not enough money on our balance.");
}
void SendMoney(object sender, AtmSendEventArgs e)
{
    if(e.Result)
    Console.WriteLine("Transaction successful.");
    else
        Console.WriteLine("An error occur. Transaction unsuccessful.");
}
void Log_out(object sender, EventArgs e)
{
    Console.WriteLine("Log out...");
    Console.WriteLine("Data saving...");
}

Atm atm = new Atm();
atm.AuthEvent += Auth;
atm.BalanceEvent += ShowBalance;
atm.WithdrawEvent += WithdrawMoney;
atm.SendEvent += SendMoney;
atm.LogoutEvent += Log_out;

atm.showcards();
bool auted = true;
while (auted)
{
    Console.Write("Enter a card number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Enter a pincode: ");
    int pincode = int.Parse(Console.ReadLine());
    Cards card1 = new Cards(number, pincode);
    if (atm.Authenticate(card1) == "Successfull")
        auted = false;
}

bool cikl = true;
while (cikl)
{
    Console.WriteLine("Choose a number for action:");
    Console.WriteLine("1 - Show balance\n2 - Add money\n3 - Withdraw money\n4 - Send money\n0 - Log out");
    int choose = int.Parse(Console.ReadLine());
    switch (choose)
    {
        case 1:
            atm.ShowBalance();
            break;
        case 2:
            Console.Write("Enter a sum for add:");
            int sum = int.Parse(Console.ReadLine());
            if(sum <= 0)
                Console.WriteLine("Sum can't be 0.");
            else
            atm.Add(sum);
            break;
        case 3:
            Console.Write("Enter a sum for withdraw:");
            int wr = int.Parse(Console.ReadLine());
            if (wr <= 0)
                Console.WriteLine("Sum can't be 0.");
            else
                atm.Withdraw(wr);
            break;
        case 4:
            Console.Write("Enter a number of card: ");
            int dest = int.Parse(Console.ReadLine());
            Console.Write("Enter a sum of money you want to send: ");
            int pr = int.Parse(Console.ReadLine());
            if (pr <= 0)
                Console.WriteLine("Sum can't be 0.");
            else
                atm.Send(pr, dest);
            break;
        default:
            atm.Logout();
            cikl = false;
            break;
    }
}
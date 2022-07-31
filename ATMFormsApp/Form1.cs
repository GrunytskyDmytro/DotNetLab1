using ATMClassLibrary;

namespace ATMFormsApp
{
    public partial class Form1 : Form
    {
        Atm atm = new Atm();
        public Form1()
        {
            InitializeComponent();
        }
        private void Gobutton_Click(object sender, EventArgs e)
        {
            atm.AuthEvent += (obj, e) =>
            {
                MessageBox.Show($"Authentication {e.Result}");
                if (e.Result == "Successfull")
                {
                    Sum_Box.PlaceholderText = "Balance(Sum)";
                    Sum_Box.Text = "";
                    Dest_Box.PlaceholderText = "Destination";
                    Dest_Box.Text = "";
                    Auth_button.Visible = false;

                    Add_Button.Visible = true;
                    Withdraw_Button.Visible = true;
                    Button_ShowBalance.Visible = true;
                    Send_Button.Visible = true;
                    Logout_Button.Visible = true;
                }
            };
            Cards card = new Cards(int.Parse(Sum_Box.Text), int.Parse(Dest_Box.Text));
            atm.Authenticate(card);
        }
        private void BalanceButton_Click(object sender, EventArgs e)
        {
            atm.BalanceEvent += (obj, e) =>
            {
                MessageBox.Show($"Your Balance: {e.Balance}.");
            };
            atm.ShowBalance();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            atm.AddEvent += (obj, e) =>
            {
                MessageBox.Show("Transaction successful.");
            };
            int n;
            if (int.TryParse(Sum_Box.Text, out n))
                atm.Add(n);
            else
            {
                MessageBox.Show("Enter sum.");
            }
        }
        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            atm.WithdrawEvent += (obj, e) =>
            {
                if (e.Result)
                    MessageBox.Show($"{e.Sum} is debited from your balance");
                else
                    MessageBox.Show("Not enough money on our balance.");

            };
            int n;
            if (int.TryParse(Sum_Box.Text, out n))
                atm.Withdraw(n);
            else
            {
                MessageBox.Show("Enter sum.");
            }
        }
        private void SendButton_Click(object sender, EventArgs e)
        {
            atm.SendEvent += (obj, e) =>
            {
                if (e.Result)
                    MessageBox.Show("Transaction successful.");
                else
                    MessageBox.Show("An error occur. Transaction unsuccessful.");

            };
            int a,b;
            if (int.TryParse(Sum_Box.Text, out a))
                if(int.TryParse(Dest_Box.Text, out b))
                    atm.Send(a, b);
            else 
            {
                MessageBox.Show("Enter sum and destination correctly.");
            }
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            atm.LogoutEvent += (obj, e) =>
            { 
                MessageBox.Show("Log out...");
                MessageBox.Show("Data saving...");

                Sum_Box.PlaceholderText = "Card number";
                Sum_Box.Text = "";
                Dest_Box.PlaceholderText = "Pin Code";
                Dest_Box.Text = "";
                Auth_button.Visible = true;

                Add_Button.Visible = false;
                Withdraw_Button.Visible = false;
                Button_ShowBalance.Visible = false;
                Send_Button.Visible = false;
                Logout_Button.Visible = false;
            };
            atm.Logout();
        }
    }
}
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static int depos;
        public int change;
        public static void Pay(ref int a, ref int b)
        {
            depos = User.Deposit;
            if (a > 0)
            {
                if (User.Deposit >= b)
                {
                    a--;
                    User.Deposit -= b;
                    MessageBox.Show("Спасибо");
                }
                else
                {
                    MessageBox.Show("Недостаточно средств");
                }
            }
            else
            {
                MessageBox.Show("Товар закончился");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
       
        
        private void Form1_Load(object sender, EventArgs e)
        {
            summ.Text = Convert.ToString(User.Deposit) + " руб"; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Per = new Form2(this);
            Per.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            walletVM wallet = new walletVM(this);
            wallet.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        } 

        private void button4_Click(object sender, EventArgs e)
        {
            if(User.Deposit > 0)
            {
                if(User.Deposit >= 10 && VendingMachine.TenRub > 0)
                {
                    change = User.Deposit / 10;
                    User.TenRub += change;
                    VendingMachine.TenRub -= change;
                    User.Deposit %= 10;
                    User.balance +=change * 10;

                }
                if (User.Deposit >= 5 && VendingMachine.FiveRub > 0)
                {
                    change = User.Deposit / 5;
                    User.FiveRub += change;
                    VendingMachine.FiveRub -= change;
                    User.Deposit %= 5;
                    User.balance +=change * 5;

                }
                if (User.Deposit >= 2 && VendingMachine.TwoRub > 0)
                {
                    change = User.Deposit / 2;
                    User.TwoRub += change;
                    VendingMachine.TwoRub -= change;
                    User.Deposit %= 2;
                    User.balance +=change * 2;
                }
                if (User.Deposit >= 1 && VendingMachine.OneRub > 0)
                {
                    change = User.Deposit / 1;
                    User.OneRub += change;
                    VendingMachine.OneRub -= change;
                    User.balance +=change;
                }
                User.Deposit = 0;
                summ.Text = Convert.ToString(User.Deposit + "руб");
            }
        }

        private void circleButton1_Click(object sender, EventArgs e)
        {
            Pay(ref VendingMachine.Tea, ref VendingMachine.TeaPrice);
            tea.Text = $"({VendingMachine.Tea})";
            summ.Text = Convert.ToString(User.Deposit + "руб");
        }

        private void circleButton2_Click(object sender, EventArgs e)
        {
            Pay(ref VendingMachine.Coffee, ref VendingMachine.CoffeePrice);
            coffee.Text = $"({VendingMachine.Coffee})";
            summ.Text = Convert.ToString(User.Deposit + "руб");
        }

        private void circleButton3_Click(object sender, EventArgs e)
        {
            Pay(ref VendingMachine.Coffeemilk, ref VendingMachine.CoffeemilkPrice);
            coffeemilk.Text = $"({VendingMachine.Coffeemilk})";
            summ.Text = Convert.ToString(User.Deposit + "руб");
        }

        private void circleButton4_Click(object sender, EventArgs e)
        {
            Pay(ref VendingMachine.Juice, ref VendingMachine.JuicePrice);
            juice.Text = $"({VendingMachine.Juice})";
            summ.Text = Convert.ToString(User.Deposit + "руб");
        }
    }
}

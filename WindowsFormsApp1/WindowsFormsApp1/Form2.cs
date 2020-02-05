using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form1 form1;
        
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            
            label2.Text = Convert.ToString(User.balance) + "руб";
            onerub.Text = Convert.ToString(User.OneRub) + "купюр";
            tworub.Text = Convert.ToString(User.TwoRub) + "купюр";
            fiverub.Text = Convert.ToString(User.FiveRub) + "купюр";
            tenrub.Text = Convert.ToString(User.TenRub) + "купюр";
            deposit.Text = Convert.ToString(User.Deposit) + "руб";


        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (User.OneRub > 0)
            {
                User.OneRub--;
                User.balance -= 1;
                User.Deposit += 1;
                VendingMachine.OneRub++;
            }
            else
            {
                MessageBox.Show("У вас закончились рублевые купюры");
            }


            label2.Text = Convert.ToString(User.balance) + "руб";
            onerub.Text = Convert.ToString(User.OneRub) + "купюр";
            deposit.Text = Convert.ToString(User.Deposit) + "руб";
            form1.summ.Text = Convert.ToString(User.Deposit + "руб");
            
            

            

        }

        private void circleButton3_Click(object sender, EventArgs e)
        {
            if (User.TwoRub > 0)
            {
                User.TwoRub--;
                User.balance -= 2;
                User.Deposit += 2;
                VendingMachine.TwoRub++;
            }
            else
            {
                MessageBox.Show("У вас закончились 2рублевые купюры");
            }


            label2.Text = Convert.ToString(User.balance) + "руб";
            tworub.Text = Convert.ToString(User.TwoRub) + "купюр";
            deposit.Text = Convert.ToString(User.Deposit) + "руб";
            form1.summ.Text = Convert.ToString(User.Deposit + "руб");
        }

        private void circleButton2_Click(object sender, EventArgs e)
        {
            if (User.FiveRub > 0)
            {
                User.FiveRub--;
                User.balance -= 5;
                User.Deposit += 5;
                VendingMachine.FiveRub++;
            }
            else
            {
                MessageBox.Show("У вас закончились 5рублевые купюры");
            }


            label2.Text = Convert.ToString(User.balance) + "руб";
            fiverub.Text = Convert.ToString(User.FiveRub) + "купюр";
            deposit.Text = Convert.ToString(User.Deposit) + "руб";
            form1.summ.Text = Convert.ToString(User.Deposit + "руб");
        }

        private void circleButton4_Click(object sender, EventArgs e)
        {
            if (User.TenRub > 0)
            {
                User.TenRub--;
                User.balance -= 10;
                User.Deposit += 10;
                VendingMachine.TenRub++;
            }
            else
            {
                MessageBox.Show("У вас закончились 10рублевые купюры");
            }


            label2.Text = Convert.ToString(User.balance) + "руб";
            tenrub.Text = Convert.ToString(User.TenRub) + "купюр";
            deposit.Text = Convert.ToString(User.Deposit) + "руб";
            form1.summ.Text = Convert.ToString(User.Deposit + "руб");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Close();
            form1.Show();
            


        }
    }

}

    


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class walletVM : Form
    {
        public Form1 kek;
        public walletVM()
        {
            InitializeComponent();
        }
        public walletVM(Form1 f)
        {
            InitializeComponent();
            kek = f;
        }

        private void walletVM_Load(object sender, EventArgs e)
        {
            onerub.Text = Convert.ToString(VendingMachine.OneRub + "купюр");
            tworub.Text = Convert.ToString(VendingMachine.TwoRub + "купюр");
            fiverub.Text = Convert.ToString(VendingMachine.FiveRub + "купюр");
            tenrub.Text = Convert.ToString(VendingMachine.TenRub + "купюр");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kek.Show();
            Close();
            
        }
    }
}

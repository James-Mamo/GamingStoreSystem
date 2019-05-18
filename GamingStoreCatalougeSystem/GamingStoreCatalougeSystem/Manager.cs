using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamingStoreCatalougeSystem
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            this.Hide();

            Insert insert = new Insert();
            insert.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Update update = new Update();

            update.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewGames vg = new ViewGames();
            vg.Show();
        }

        private void btnInserPeriph_Click(object sender, EventArgs e)
        {
            this.Hide();
            PeripheralAdd p = new PeripheralAdd();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PeripheraUpdate p = new PeripheraUpdate();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewPeripherals p = new ViewPeripherals();
            p.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MakeOrder mo = new MakeOrder();

            this.Hide();
            mo.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login lo = new Login();

            this.Hide();
            lo.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addCustomer ac = new addCustomer();

            this.Hide();
            ac.Show();
        }
    }
}

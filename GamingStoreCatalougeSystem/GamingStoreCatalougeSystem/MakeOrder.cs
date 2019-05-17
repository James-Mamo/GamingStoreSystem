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
    public partial class MakeOrder : Form
    {
        public MakeOrder()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Order o = new Order(txtoName.Text,txtoDescription.Text);

            o.add();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string username = Login.username;
            string password = Login.password;

            if (username == "manager" && password == "manager123")
            {
                this.Hide();
                Manager m = new Manager();
                m.Show();
            }
            else if (username == "employee" && password == "employee123")
            {
                this.Hide();
                Employee em = new Employee();
                em.Show();
            }
        }
    }
}

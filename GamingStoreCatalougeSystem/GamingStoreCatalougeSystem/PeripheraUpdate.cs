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
    public partial class PeripheraUpdate : Form
    {
        public PeripheraUpdate()
        {
            InitializeComponent();
        }

        private void btnUpdateP_Click(object sender, EventArgs e)
        {
            Peripherals p = new Peripherals(txtNameP.Text, txtPriceU.Text);

            p.update();
        }

        private void button1_Click(object sender, EventArgs e)
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

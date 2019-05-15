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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Games games = new Games(txtNameU.Text,"n/a",txtPriceU.Text);

            games.update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = Login.username;
            string password = Login.password;

            if (username == "manager" && password == "manager123")
            {
                this.Hide();
                Manager m = new Manager();
                m.Show();
            }
            else if(username == "employee" && password == "employee123")
            {
                this.Hide();
                Employee em = new Employee();
                em.Show();
            }
           
            
        }
    }
}

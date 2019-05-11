using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamingStoreCatalougeSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
           
        }

        
    
    private void btnLogin_Click(object sender, EventArgs e)
        {


          


            if(txtUsername.Text == "manager" && txtPassword.Text== "manager123")
            {
                this.Hide();

                Manager employee = new Manager();

                employee.Show();

            }
            else if(txtUsername.Text == "employee" && txtPassword.Text == "password123")
            {
              //go to employee screen 
            }
            else
            {
                MessageBox.Show("Invalid Credentials.", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }
    }
}

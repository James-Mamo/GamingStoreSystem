using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamingStoreCatalougeSystem
{
    public partial class Login : Form
    {
        public static string username;
        public static string password;

        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
           
        }

        
    
    private void btnLogin_Click(object sender, EventArgs e)
        {


            username = txtUsername.Text;
            password = txtPassword.Text;


            if(username == "manager" && password== "manager123")
            {
                this.Hide();

                Manager manager = new Manager();

                manager.Show();

            }
            else if(username == "employee" && password == "employee123")
            {
                this.Hide();

                Employee employee = new Employee();

                employee.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials.", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}

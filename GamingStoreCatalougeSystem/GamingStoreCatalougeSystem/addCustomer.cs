using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamingStoreCatalougeSystem
{
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            
            string name = txtName.Text;
            string surname = txtSurname.Text;
            int telephone = Convert.ToInt32(txtTelephone.Text);
            string idNumber = txtID.Text;

            checkName(name, surname, telephone, idNumber);
           
            
        }


        private bool checkName (string name, string surname, int telephone, string idNumber)
        {
            string telephoneNum = telephone.ToString();
            Regex r = new Regex("^[a-zA-Z ]+$");

            if((r.IsMatch(name)) && (r.IsMatch(surname)) && (telephoneNum.Length == 8))
            {
                Client clients = new Client(name, surname, telephone, idNumber);
                clients.add();

                return true;
            }
            else
            {
                MessageBox.Show("Error Invalid credentials");
                return false;
            }
        }
        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

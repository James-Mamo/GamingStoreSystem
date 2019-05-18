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

            Client clients = new Client(name,surname,telephone,idNumber);
            clients.add();

            
        }
    }
}

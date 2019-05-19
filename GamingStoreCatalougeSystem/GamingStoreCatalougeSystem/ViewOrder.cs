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
    public partial class View_Order : Form
    {
        public View_Order()
        {
            InitializeComponent();
            getAllData();
        }

        public void getAllData()
        {
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"F:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database Copies\\GamingStoreDatabase.mdf\";Integrated Security=True;Connect Timeout=30";
            //string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"I:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database\\GamingStoreDatabase.mdf\"; Integrated Security = True; Connect Timeout = 30";


            string query = "Select * FROM Orders";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(query, conn);

            SqlDataReader reader;
            listView1.View = View.Details;

            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String[] row = { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2) };

                        ListViewItem lvi = new ListViewItem(row);
                        listView1.Items.Add(lvi);
                        //listView1.Items.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with Query");
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void ViewGames_Load(object sender, EventArgs e)
        {

            if (Login.username == "employee" && Login.password == "employee123")
            {
                btnDelete.Hide();
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            listView1.Items.Clear();
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"F:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database Copies\\GamingStoreDatabase.mdf\";Integrated Security=True;Connect Timeout=30";
            //string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"I:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database\\GamingStoreDatabase.mdf\"; Integrated Security = True; Connect Timeout = 30";

            string userChoise = textBox1.Text;

            string query = "Select * FROM Orders WHERE Name LIKE '%" + userChoise + "%'";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(query, conn);

            SqlDataReader reader;
            listView1.View = View.Details;

            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String[] row = { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2) };

                        ListViewItem lvi = new ListViewItem(row);
                        listView1.Items.Add(lvi);
                        //listView1.Items.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with Query");
                MessageBox.Show(ex.StackTrace);
            }

        }

        
        private void View_Order_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = listView1.SelectedItems[0].Text;
            listView1.Items.Clear();
            Order.DeleteOrder(id);

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

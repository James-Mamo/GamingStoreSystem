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
    public partial class ViewGames : Form
    {
        public ViewGames()
        {
            InitializeComponent();
            getAllData();
        }




        public void getAllData()
        {
          string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"F:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database Copies\\GamingStoreDatabase.mdf\";Integrated Security=True;Connect Timeout=30";
           //string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"I:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database\\GamingStoreDatabase.mdf\"; Integrated Security = True; Connect Timeout = 30";


            string query = "Select * FROM Game";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(query, conn);

            SqlDataReader reader;
            listView1.View = View.Details;

            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String[] row = { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetDouble(2).ToString() };

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
            
                
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            listView1.Items.Clear();
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"F:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database Copies\\GamingStoreDatabase.mdf\";Integrated Security=True;Connect Timeout=30";
            //string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"I:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database\\GamingStoreDatabase.mdf\"; Integrated Security = True; Connect Timeout = 30";

            string userChoise = textBox1.Text;

            string query = "Select * FROM Game WHERE [Game Name] LIKE '%"+userChoise+"%'";

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
                        String[] row = { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetDouble(2).ToString() };

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

        

        private void button1_Click(object sender, EventArgs e)
        {
            string id = listView1.SelectedItems[0].Text;
            listView1.Items.Clear();
            Games.Delete(id);
            Games.DeleteGame(id);
            getAllData();

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            listView1.Items.Clear();
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"F:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database Copies\\GamingStoreDatabase.mdf\";Integrated Security=True;Connect Timeout=30";
            //string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"I:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database\\GamingStoreDatabase.mdf\"; Integrated Security = True; Connect Timeout = 30";

            string userChoise = textBox2.Text;

            string query = "Select * FROM Game WHERE Price = '"+userChoise+"'";

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
                        String[] row = { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetDouble(2).ToString() };

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager m = new Manager();
            m.Show();
        }
    }
}


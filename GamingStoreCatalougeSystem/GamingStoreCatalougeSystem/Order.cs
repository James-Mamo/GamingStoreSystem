using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamingStoreCatalougeSystem
{
    class Order
    {

       protected string orderName;
       protected string orderDescription;


        public string OrderName
        {
            get
            {
                return orderName;
            }
        }

        public string OrderDescription
        {
            get
            {
                return orderDescription;
            }
        }

        public Order(string pOrderName, string pOrderDescription)
        {
            orderDescription = pOrderDescription;
            orderName = pOrderName;
        }

        //string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"F:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database Copies\\GamingStoreDatabase.mdf\";Integrated Security=True;Connect Timeout=30";
        string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"I:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database\\GamingStoreDatabase.mdf\"; Integrated Security = True; Connect Timeout = 30";



        public void add()
        {


            string query = "INSERT INTO Orders ([Order Name],[Order Description]) VALUES ('" + orderName + "','" + orderDescription + "')";



            SqlConnection databaseConnection = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(query, databaseConnection);

            SqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                MessageBox.Show("Order has been added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with Query");
                MessageBox.Show(ex.Message);
            }
        }

    }
}

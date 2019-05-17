using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamingStoreCatalougeSystem
{
    class Peripherals : Item
    {

        string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"F:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database Copies\\GamingStoreDatabase.mdf\";Integrated Security=True;Connect Timeout=30";
        //string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"I:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database\\GamingStoreDatabase.mdf\"; Integrated Security = True; Connect Timeout = 30";


        private static void email()
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.office365.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("gss231112@outlook.com", "test123321");
            string message = "Data was deleted at " + DateTime.Now.ToString();

            MailMessage mm = new MailMessage("gss231112@outlook.com", "james.mamo.a101038@mcast.edu.mt", "Data deleted from Database", message);
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
        }

        public Peripherals(string pName, string pPrice) : base()
        {
            name = pName;
            price = pPrice;
        }



        public void add()
        {


            string query = "INSERT INTO Pheripherals (Name,Price) VALUES ('" + name + "','" + price + "')";


            SqlConnection databaseConnection = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(query, databaseConnection);

            SqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                MessageBox.Show("Item has been Added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with Query");
                MessageBox.Show(ex.Message);
            }
        }


        public void update()
        {
            string query = "UPDATE Pheripherals SET price = '" + price + "' WHERE Name = '" + name + "'";


            SqlConnection databaseConnection = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(query, databaseConnection);

            SqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                MessageBox.Show("Item has been Updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with Query");
                MessageBox.Show(ex.Message);
            }
        }

        public static void DeletePeripheral(string id)
        {


            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"F:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database Copies\\GamingStoreDatabase.mdf\";Integrated Security=True;Connect Timeout=30";
            //string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"I:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database\\GamingStoreDatabase.mdf\"; Integrated Security = True; Connect Timeout = 30";

            string query = "DELETE FROM Game WHERE [Game ID] = " + id + "";


            SqlConnection databaseConnection = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(query, databaseConnection);

            SqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                MessageBox.Show("Item has been Deleted!");
                email();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with Query");
                MessageBox.Show(ex.Message);
            }

        }

    }
}

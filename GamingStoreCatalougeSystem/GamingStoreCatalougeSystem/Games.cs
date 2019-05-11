using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace GamingStoreCatalougeSystem
{
    public class Games : Item
    {
        string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"F:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database Copies\\GamingStoreDatabase.mdf\";Integrated Security=True;Connect Timeout=30";
        //string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"I:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database\\GamingStoreDatabase.mdf\"; Integrated Security = True; Connect Timeout = 30";

        public Games(string pName, string pGenre, string pPrice) : base ()
        {
            name = pName;
            genre = pGenre;
            price = pPrice;
        }

        public void add()
        {
            
           
            string query = "INSERT INTO Game([Game Name],Price) VALUES ('" + name + "','" + price + "')";
           

            SqlConnection databaseConnection = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(query, databaseConnection);

            SqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                MessageBox.Show("Game has been Added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with Query");
                MessageBox.Show(ex.Message);
            }
        }

        public void update()
        {
            string query = "UPDATE Game SET price = '"+price+"' WHERE [Game Name] = '"+name+"'";


            SqlConnection databaseConnection = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(query, databaseConnection);

            SqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                MessageBox.Show("Game has been Updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with Query");
                MessageBox.Show(ex.Message);
            }
        }


        public static void Delete(string id)
        {
            

            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"F:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database Copies\\GamingStoreDatabase.mdf\";Integrated Security=True;Connect Timeout=30";
            //string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"I:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database\\GamingStoreDatabase.mdf\"; Integrated Security = True; Connect Timeout = 30";
            
            if(id != "0")
            {
                string query = "DELETE FROM [Game-Genre] WHERE [Game ID] = " + id + "";


                SqlConnection databaseConnection = new SqlConnection(connectionString);
                SqlCommand commandDatabase = new SqlCommand(query, databaseConnection);

                SqlDataReader reader;

               
                    databaseConnection.Open();

                    reader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();

            }
            else
            {
                MessageBox.Show("No item selected");
              
            }

        }


        public static void DeleteGame(string id)
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
                MessageBox.Show("Game has been Deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with Query");
                MessageBox.Show(ex.Message);
            }

        }
    }


    }



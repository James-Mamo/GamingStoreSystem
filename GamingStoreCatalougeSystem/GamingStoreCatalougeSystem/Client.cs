using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamingStoreCatalougeSystem
{
    class Client
    {
        protected string name;
        protected string surname;
        protected int telephone;
        protected string id;

        public string Name
        {
            get
            {
                return name;
            }
        }


        public string Surname
        {
            get
            {
                return surname;
            }
        }



        public int Telephone
        {
            get
            {
                return telephone;
            }
        }


        public string ID
        {
            get
            {
                return id;
            }
        }

        public Client(string pName, string pSurname, int pTelephone,string pID)
        {
            name = pName;
            surname = pSurname;
            telephone = pTelephone;
            id = pID;
        }

        string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"F:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database Copies\\GamingStoreDatabase.mdf\";Integrated Security=True;Connect Timeout=30";
        //string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"I:\\ICT Level 4\\4.2A\\SoftwareProject\\JamesMamoSWD 4.2A\\GamingStoreCatalougeSystem\\Database\\GamingStoreDatabase.mdf\"; Integrated Security = True; Connect Timeout = 30";
        public void add()
        {


            string query = "INSERT INTO Client(Name,Surname,[ID Number],[Tel Number]) VALUES ('" + name + "','" + surname + "','"+id+"','"+telephone+"')";


            SqlConnection databaseConnection = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(query, databaseConnection);

            SqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                MessageBox.Show("Client has been Added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with Query");
                MessageBox.Show(ex.Message);
            }
        }
    }
}

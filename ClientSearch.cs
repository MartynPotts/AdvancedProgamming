using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwayDayPlanner
{
    public partial class ClientSearch : Form
    {
        SqlConnection Connection;
        DataSet Tables;
        DataSet ClientsTable;
        SqlDataAdapter allTables;

        public ClientSearch()
        {
            InitializeComponent();
        }

        /*  TODO: implement search box - SELECT * WHERE COMPANY NAME = "COMPANY NAME";
         *        create an add new client button to form
         *        
         *        ################################################################
         *        Create second form - view client
         *        populate with the data in editable fields
         *        create a save changes button
         *        create a button to launch client request feature
        */
        
        private void ClientSearch_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(Properties.Settings.Default.ClientsDatabase);

            String allTableSQL = "SELECT * FROM Address; SELECT * FROM CITY; SELECT * FROM Client; " +
                "SELECT * FROM Company; SELECT * FROM Department;";
            allTables = new SqlDataAdapter(allTableSQL, Connection);
            Tables = new DataSet("Clients");
            allTables.Fill(Tables);

            string JoinTable = "SELECT ContactName,ContactEmail,ContactPhoneNumber,CompanyName,DepartmentName, BuildingNameNumber, CityName, Postcode FROM Client " +
                "LEFT JOIN Company ON Client.CompanyID = Company.CompanyID " +
                "LEFT JOIN Department ON Client.DepartmentID = Department.DepartmentID " +
                "LEFT JOIN Address ON Client.AddressID = Address.AddressID " +
                "LEFT JOIN City ON Address.CityID = City.CityID";
            SqlDataAdapter Join = new SqlDataAdapter(JoinTable, Connection);
            ClientsTable = new DataSet("Join");
            Join.Fill(ClientsTable);

            dgvClientsList.DataSource = ClientsTable.Tables[0];
            dgvClientsList.AllowUserToDeleteRows = false;
            dgvClientsList.AllowUserToAddRows = false;
            for (int i = 0; i < dgvClientsList.ColumnCount; i++)
                dgvClientsList.Columns[i].ReadOnly = true;           
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}

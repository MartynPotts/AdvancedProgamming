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

            using (var mycontext = new Context())
            {
                City city = new City
                {
                    CityName = "Newcastle"
                };
                
                Address address = new Address
                {
                    BuildingNameNumber = "CIS",
                    Postcode = "NE1 8ST",
                    CityName = city
                };

                Company company = new Company
                {
                    CompanyName = "Northumbria"
                };

                Department department = new Department
                {
                    DepartmentName = "Computer and Information Sciences"
                };

                Client client = new Client
                {
                    ContactName = "Martyn Amos",
                    ContactEmail = "Martyn.Amos@Northumbria.ac.uk",
                    ContactPhoneNumber = "+441912437655"
                };

                client.Address = address;
                client.Company = company;
                client.Department = department;

                mycontext.City.Add(city);
                mycontext.Addresses.Add(address);
                mycontext.Companies.Add(company);
                mycontext.Departments.Add(department);
                mycontext.Clients.Add(client);
                mycontext.SaveChanges();

                
            }
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}

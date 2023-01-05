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

        /*  TODO: create an add new client button to form
         *        ################################################################
         *        create a save changes button
        */

        private void ClientSearch_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(Properties.Settings.Default.ClientsDatabase);

            String allTableSQL = "SELECT * FROM Address; SELECT * FROM CITY; SELECT * FROM Client; " +
                "SELECT * FROM Company; SELECT * FROM Department;";
            allTables = new SqlDataAdapter(allTableSQL, Connection);
            Tables = new DataSet("Clients");
            allTables.Fill(Tables);

            string JoinTable = "SELECT ClientID, ContactName,ContactEmail,ContactPhoneNumber,CompanyName,DepartmentName, BuildingNameNumber, CityName, Postcode FROM Client " +
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
            dgvClientsList.Columns["ClientID"].Width = -1;
            for (int i = 0; i < dgvClientsList.ColumnCount; i++)
                dgvClientsList.Columns[i].ReadOnly = true;
        }

        private void DgvClientsList_CellContentDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            RowSelected(dgvClientsList.CurrentCell.RowIndex);
        }

        private void DgvClientsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RowSelected(dgvClientsList.CurrentCell.RowIndex);
        }

        private void RowSelected(int index)
        {
            DataRow dr = ClientsTable.Tables[0].Rows[index];
            int clientID = dr.Field<int>(0);
            ValidateClientDetails validateClientDetails = new ValidateClientDetails(ClientsTable, clientID);
            this.Hide();
            validateClientDetails.ShowDialog();
            this.Show();

        }

        private void TxtCompanySearch_TextChanged(object sender, EventArgs e)
        {
            (dgvClientsList.DataSource as DataTable).DefaultView.RowFilter = string.Format("CompanyName LIKE '{0}%'", txtCompanySearch.Text);
        }

        private void TxtClientSearch_TextChanged(object sender, EventArgs e)
        {
            (dgvClientsList.DataSource as DataTable).DefaultView.RowFilter = string.Format("ContactName LIKE '{0}%'", txtClientSearch.Text);
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            ValidateClientDetails validateClientDetails = new ValidateClientDetails();
            this.Hide();
            validateClientDetails.ShowDialog();
            this.Show();
        }

        private void btnViewClient_Click(object sender, EventArgs e)
        {
            RowSelected(dgvClientsList.CurrentCell.RowIndex);
        }
    }
}

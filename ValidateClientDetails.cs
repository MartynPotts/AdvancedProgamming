using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwayDayPlanner
{
    public partial class ValidateClientDetails : Form
    {
        DataSet Clients;
        int ClientID;

        public ValidateClientDetails(DataSet clients, int clientID)
        {
            this.Clients = clients;
            this.ClientID = clientID;
            InitializeComponent();
        }

        public ValidateClientDetails()
        {
            InitializeComponent();
        }

        private void ValidateClientDetails_Load(object sender, EventArgs e)
        {
            if (ClientID != 0)
            {
                PopulateFormDetails();
            }

        }

        private void ChkVerify_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVerify.Checked)
            {
                btnStartEstimate.Enabled = true;
            }
            else
            {
                btnStartEstimate.Enabled = false;
            }
        }


        public void PopulateFormDetails()
        {
            var query = from Client in Clients.Tables[0].AsEnumerable()
                        where Client.Field<int>(0) == ClientID
                        select new
                        {
                            contactName = Client.Field<string>(1),
                            contactEmail = Client.Field<string>(2),
                            contactNumber = Client.Field<string>(3),
                            companyName = Client.Field<string>(4),
                            department = Client.Field<string>(5),
                            buildingNameNumber = Client.Field<string>(6),
                            city = Client.Field<string>(7),
                            postcode = Client.Field<string>(8)
                        };
            var clientList = query.ToList();
            txtContactName.Text = clientList[0].contactName;
            txtContactEmail.Text = clientList[0].contactEmail;
            txtContactNumber.Text = clientList[0].contactNumber;
            txtCompany.Text = clientList[0].companyName;
            txtDepartment.Text = clientList[0].department;
            txtBuildingNameNumber.Text = clientList[0].buildingNameNumber;
            txtCity.Text = clientList[0].city;
            txtPostcode.Text = clientList[0].postcode;
        }

        private void TxtContactName_TextChanged(object sender, EventArgs e)
        {
            EnableSaveButton();
        }

        private void EnableSaveButton()
        {
            btnSave.Enabled = true;
        }

        private void TxtContactEmail_TextChanged(object sender, EventArgs e)
        {
            EnableSaveButton();
        }

        private void TxtContactNumber_TextChanged(object sender, EventArgs e)
        {
            EnableSaveButton();
        }

        private void TxtCompany_TextChanged(object sender, EventArgs e)
        {
            EnableSaveButton();
        }

        private void TxtDepartment_TextChanged(object sender, EventArgs e)
        {
            EnableSaveButton();
        }

        private void TxtBuildingNameNumber_TextChanged(object sender, EventArgs e)
        {
            EnableSaveButton();
        }

        private void TxtCity_TextChanged(object sender, EventArgs e)
        {
            EnableSaveButton();
        }

        private void TxtPostcode_TextChanged(object sender, EventArgs e)
        {
            EnableSaveButton();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {

                var city = new City
                { 
                    CityName = txtCity.Text 
                };
                context.City.Add(city);
                context.SaveChanges();

                var address = new Address
                {
                    BuildingNameNumber = txtBuildingNameNumber.Text,
                    CityID = city.CityID,
                    Postcode = txtPostcode.Text,
                };
                context.Addresses.Add(address);
                context.SaveChanges();
                this.Hide();

                /*
                var CityList = context.City.ToList<City>();
                City city = new City();
                city.CityName = txtCity.Text.ToString();

                var AddressList = context.Addresses.ToList<Address>();
                Address address = new Address();
                address.BuildingNameNumber = txtBuildingNameNumber.Text.ToString();
                address.Postcode = txtPostcode.Text.ToString();
                address.CityID = city.CityID;

                var CompanyList = context.Companies.ToList<Company>();
                Company company = new Company();
                company.CompanyName = txtCompany.Text.ToString();

                var DepartmentList = context.Departments.ToList<Department>();
                Department department = new Department();
                department.DepartmentName = txtDepartment.Text.ToString();

                var ClientList = context.Clients.ToList<Client>();
                Client client = new Client();
                client.ContactName = txtContactName.Text.ToString();
                client.ContactEmail = txtContactEmail.Text.ToString();
                client.ContactPhoneNumber = txtContactNumber.Text.ToString();
                client.AddressID = address.AddressID;
                client.CompanyID = company.CompanyID;
                client.DepartmentID = department.DepartmentID;

                context.City.Add(city);
                context.Addresses.Add(address);
                context.Companies.Add(company);
                context.Departments.Add(department);
                context.Clients.Add(client);
                context.SaveChanges();
                this.Hide();
                */
            }
        }
    }
}

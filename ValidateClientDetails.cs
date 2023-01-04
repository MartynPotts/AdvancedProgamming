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

        private void ValidateClientDetails_Load(object sender, EventArgs e)
        {
            Console.WriteLine(Clients.Tables[0].ToString());
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
    }
}

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
            var query = from Client in Clients.Tables[0].AsEnumerable()
                        join Company in Clients.Tables[1].AsEnumerable()
                        on Client.Field<string>(1) equals Company.Field<string>(0)
                        where Client.Field<int>(0) == ClientID
                        select new
                        {
                           ContactName = Client.Field<string>("ContactName"),
                           ContactEmail = Client.Field<string>("ContactEmail"),
                           ContactPhoneNumber = Client.Field<string>("ContactPhoneNumber"),
                           Company = Client.Field<string>("Company"),
                           //department = client.field<string>("department"),
                           //buildingnamenumber = client.field<string>("buildingnamenumber"),
                           //city = client.field<string>("city"),
                           //postcode = client.field<string>("postcode")
                        };
            var ClientDetails = query.ToList();
            txtContactName.Text = ClientDetails[0].ContactName;
            txtContactEmail.Text = ClientDetails[1].ContactEmail;
            txtContactNumber.Text = ClientDetails[2].ContactPhoneNumber;
            txtCompany.Text = ClientDetails[3].Company;
            //txtDepartment.Text = ClientDetails[4].Department;
            //txtBuildingNameNUmber.Text = ClientDetails[5].BuildingNameNumber;
            //txtCity.Text = ClientDetails[6].City;
            //txtPostcode.Text = ClientDetails[7].Postcode;
              
        }
    }
}

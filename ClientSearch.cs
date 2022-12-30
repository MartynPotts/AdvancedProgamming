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
    public partial class ClientSearch : Form
    {
        public ClientSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ClientSearch_Load(object sender, EventArgs e)
        {
            using (var mycontext = new Context())
            {
                City City1 = new City(1, "Newcastle");
                Address Address1 = new Address(1, "CIS", City1, "NE1");
                Company Company1 = new Company(1, "Northumbria University");
                Department Department1 = new Department(1, "Computer and Information Sciences");
                Client Client1 = new Client(1, "Martyn Amos", Company1, Department1, "Martyn.Amos@Northumbria.ac.uk", "+441912437655", Address1);

                mycontext.City.Add(City1);
                mycontext.Addresses.Add(Address1);
                mycontext.Companies.Add(Company1);
                mycontext.Departments.Add(Department1);
                mycontext.Clients.Add(Client1);

                mycontext.SaveChanges();
                
            }
        }
    }
}

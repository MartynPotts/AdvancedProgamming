using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwayDayPlanner
{
    public partial class ChooseOptionsForm : MetroFramework.Forms.MetroForm
    {
        ChooseOptionsContext db;
        string bookingType;
        string fromDate;
        int plannedDays;
        int attendeescount ;
        string facilityDescription;


        public ChooseOptionsForm()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            this.fromDate = metroDateTime1.Text.ToString();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChooseOptions_Load(object sender, EventArgs e)
        {
            db = new ChooseOptionsContext();
            {
                awaydayRequestEstimationBindingSource.DataSource = db.RequestEstimationsdb.ToList();

            }

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AwaydayRequestEstimation obj =awaydayRequestEstimationBindingSource.Current as AwaydayRequestEstimation;
        }
      
        
        /*
          Upon Entering enquiry details ,data values are binded to context object and saves into database.
        */
        private void metroButton1_Click(object sender, EventArgs e)
        {

            awaydayRequestEstimationBindingSource.Add(new AwaydayRequestEstimation());
            awaydayRequestEstimationBindingSource.MoveLast();
            metroDateTime1.Focus();
            using (ChooseOptionsContext db = new ChooseOptionsContext())
            {
               
                AwaydayRequestEstimation obj = awaydayRequestEstimationBindingSource.Current as AwaydayRequestEstimation;
                
                //Adding the values to the database object
                obj.plannedFromDate = fromDate;
                obj.bookingServiceType = bookingType;
                obj.plannedAwayDays = plannedDays;
                obj.eventattendeescount = attendeescount;
                obj.AdditionalFacilityDescription = facilityDescription;
               
                if (obj != null)
                {
                    if (db.Entry<AwaydayRequestEstimation>(obj).State == EntityState.Detached)
                        db.Set<AwaydayRequestEstimation>().Attach(obj);
                    if (obj.clientID == 0)
                        db.Entry<AwaydayRequestEstimation>(obj).State = EntityState.Added;
                    else
                        db.Entry<AwaydayRequestEstimation>(obj).State = EntityState.Modified;
                   
                    db.SaveChanges();

                    MetroFramework.MetroMessageBox.Show(this, "Received Initial Enquiry Form successfully!! Within 24hrs, You will receive an email with further details to your registered email !!");

                    metroGrid1.Refresh();
                    

                }

            }

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookingType = metroComboBox1.Text.ToString();
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            plannedDays = Convert.ToInt32(metroComboBox2.Text);
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            attendeescount = Convert.ToInt32(metroComboBox3.Text);
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            facilityDescription = metroTextBox1.Text;
        }

        /*Exits from the application upon button click*/
        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

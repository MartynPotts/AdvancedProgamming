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
    public partial class ChooseOptionsForm : Form
    {
        Context db;
        string bookingType;
        string fromDate;
        int plannedDays;
        int attendeescount;
        string facility_Addon;


        public ChooseOptionsForm()
        {
            InitializeComponent();
        }



        private void ChooseOptions_Load(object sender, EventArgs e)
        {
            db = new Context();
            {
                awaydayRequestEstimationBindingSource.DataSource = db.RequestEstimationsdb.ToList();
                
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        /*Exits from the application upon button click*/
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fromDate = dateTimePicker1.Text.ToString();
            Console.WriteLine(fromDate);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookingType = comboBox1.Text.ToString();
            Console.WriteLine(bookingType);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            plannedDays = Convert.ToInt32(comboBox2.Text);
            Console.WriteLine(plannedDays);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            attendeescount = Convert.ToInt32(comboBox3.Text);
            Console.WriteLine(attendeescount);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            facility_Addon = comboBox4.Text.ToString();
            Console.WriteLine(facility_Addon);
        }

        /*
          Upon Entering enquiry details ,data values are binded to context object and saves into database.
        */
        private void button1_Click(object sender, EventArgs e)
        {
            awaydayRequestEstimationBindingSource.Add(new AwaydayRequestEstimation());
            awaydayRequestEstimationBindingSource.MoveLast();
            dateTimePicker1.Focus();
            using (Context db = new Context())
            {

                AwaydayRequestEstimation obj = awaydayRequestEstimationBindingSource.Current as AwaydayRequestEstimation;

                //Adding the values to the database object
                obj.plannedFromDate = fromDate;
                obj.bookingServiceType = bookingType;
                obj.plannedAwayDays = plannedDays;
                obj.eventattendeescount = attendeescount;
                obj.AdditionalFacilityDescription = facility_Addon;

                if (obj != null)
                {
                    if (db.Entry<AwaydayRequestEstimation>(obj).State == EntityState.Detached)
                        db.Set<AwaydayRequestEstimation>().Attach(obj);
                    if (obj.clientID == 0)
                        db.Entry<AwaydayRequestEstimation>(obj).State = EntityState.Added;
                    else
                        db.Entry<AwaydayRequestEstimation>(obj).State = EntityState.Modified;

                    db.SaveChanges();

                    MessageBox.Show(this, "Received Initial Enquiry Form successfully!! Within 24hrs, You will receive an email with further details to your registered email !!");




                }

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

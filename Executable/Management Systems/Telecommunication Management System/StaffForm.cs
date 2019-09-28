using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Telecommunication_Management_System
{
    public partial class StaffForm : Form
    {
        SqlConnection sqlConnection = null;

        Administrator administrator = null;
        Staff staff = null;

        public StaffForm()
        {
            InitializeComponent();
        }

        public StaffForm(Administrator administrator)
        {
            InitializeComponent();
            this.administrator = administrator;
        }

        public StaffForm(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=.; Initial Catalog=TelecommunicationManagementSystem; Integrated Security=true;";
            sqlConnection.Open();

            if (administrator!=null)
            {
                textBoxStaffIDNewStaff.Text = administrator.adminDetails[0];
                textBoxNameNewStaff.Text = administrator.adminDetails[1];
                textBoxDesignationNewStaff.Text = administrator.adminDetails[2];
                textBoxIdNoNewStaff.Text = administrator.adminDetails[3];
                textBoxAddressNewStaff.Text = administrator.adminDetails[4];
                textBoxSalaryNewStaff.Text = administrator.adminDetails[5];
                textBoxBankAccountNoNewStaff.Text = administrator.adminDetails[6];
                textBoxLoginPasswordNewStaff.Text = administrator.adminDetails[7];
            }
            else if(staff!=null)
            {
                textBoxStaffIDNewStaff.Text = staff.staffDetails[0];
                textBoxNameNewStaff.Text = staff.staffDetails[1];
                textBoxDesignationNewStaff.Text = staff.staffDetails[2];
                textBoxIdNoNewStaff.Text = staff.staffDetails[3];
                textBoxAddressNewStaff.Text = staff.staffDetails[4];
                textBoxSalaryNewStaff.Text = staff.staffDetails[5];
                textBoxBankAccountNoNewStaff.Text = staff.staffDetails[6];
                textBoxLoginPasswordNewStaff.Text = staff.staffDetails[7];
            }
        }

        private void buttonOKNewStaff_Click(object sender, EventArgs e)
        {
            if(administrator!=null || staff!=null)
            {
                SqlTransaction tran = sqlConnection.BeginTransaction();

                try
                {
                    SqlCommand command = new SqlCommand();
                    command.Transaction = tran;
                    command.Connection = sqlConnection;

                    command.CommandText = "UPDATE Staff" +
                                        " SET " + string.Format("StaffName= '{0}', Designation='{1}', NIC={2}, Address= '{3}', Salary={4}, BankAccountNumber={5}, LoginPassword='{6}'" +
                                        " WHERE StaffID={7}",
                                            textBoxNameNewStaff.Text, textBoxDesignationNewStaff.Text, Convert.ToInt64(textBoxIdNoNewStaff.Text),
                                            textBoxAddressNewStaff.Text, Convert.ToInt64(textBoxSalaryNewStaff.Text), Convert.ToInt64(textBoxBankAccountNoNewStaff.Text), textBoxLoginPasswordNewStaff.Text, Convert.ToInt32(textBoxStaffIDNewStaff.Text));
                    command.ExecuteNonQuery();

                    tran.Commit();
                    MessageBox.Show("Changes saved permanently. ");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                SqlTransaction tran = sqlConnection.BeginTransaction();

                try
                {
                    SqlCommand command = new SqlCommand();
                    command.Transaction = tran;
                    command.Connection = sqlConnection;

                    command.CommandText = "INSERT Staff (StaffName, Designation, NIC, Address, Salary, BankAccountNumber, LoginPassword)" +
                                            string.Format("VALUES ('{0}', '{1}', {2}, '{3}', {4}, {5}, '{6}')",
                                            textBoxNameNewStaff.Text, textBoxDesignationNewStaff.Text, Convert.ToInt32(textBoxIdNoNewStaff.Text),
                                            textBoxAddressNewStaff.Text, Convert.ToInt32(textBoxSalaryNewStaff.Text), Convert.ToInt32(textBoxBankAccountNoNewStaff.Text), textBoxLoginPasswordNewStaff.Text);
                    command.ExecuteNonQuery();

                    tran.Commit();
                    MessageBox.Show("Changes saved permanently. ");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }

                //new staff entry

                /** insert query on Staff table **/
            }
            
        }

        private void buttonCancelNewStaff_Click(object sender, EventArgs e)
        {
            if(administrator!=null)
            {
                administrator.Show();
                this.Close();
            }
            else if(staff!=null)
            {
                staff.Show();
                this.Close();
            }
            else
            {
                /** Think of a scenario. Think of a form to get open in default case. **/
            }
        }
    }
}

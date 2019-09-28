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
    public partial class Administrator : Form
    {
        SqlConnection sqlConnection;
		FrontPage frontPage;

        public List<string> adminDetails = new List<string>();
        public List<string> staffDetails = new List<string>();
        public List<string> clientDetails = new List<string>();
        public List<string> clientNetworks = new List<string>();


        public Administrator(FrontPage frontPage)
        {
            InitializeComponent();

            this.frontPage = frontPage;

            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=.; Initial Catalog=TelecommunicationManagementSystem; Integrated Security=true;";
            sqlConnection.Open();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "SELECT s.StaffID, s.StaffName, s.Designation, s.NIC, s.Address, s.Salary, s.BankAccountNumber, s.LoginPassword" +
                                    " FROM Staff s, Administrator a" +
                                    string.Format(" WHERE s.StaffID=a.Staff_StaffID AND s.StaffName LIKE '{0}'", frontPage.loginDetails[0]);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read() == true)
            {
                textBoxIDAdmin.Text = reader[0].ToString();
                textBoxNameAdmin.Text = reader[1].ToString();
                textBoxDesignationAdmin.Text = reader[2].ToString();
                textBoxIdentificationNoAdmin.Text = reader[3].ToString();
                textBoxAddressAdmin.Text = reader[4].ToString();
                textBoxSalaryAdmin.Text = reader[5].ToString();
                textBoxBankAccountNoAdmin.Text = reader[6].ToString();
                textBoxLoginPasswordAdmin.Text = reader[7].ToString();
            }
            reader.Close();

            adminDetails.Add(textBoxIDAdmin.Text);
            adminDetails.Add(textBoxNameAdmin.Text);
            adminDetails.Add(textBoxDesignationAdmin.Text);
            adminDetails.Add(textBoxIdentificationNoAdmin.Text);
            adminDetails.Add(textBoxAddressAdmin.Text);
            adminDetails.Add(textBoxSalaryAdmin.Text);
            adminDetails.Add(textBoxBankAccountNoAdmin.Text);
            adminDetails.Add(textBoxLoginPasswordAdmin.Text);

            command.CommandText = "SELECT NetworkName FROM Networks";
            command.CommandType = CommandType.Text;
            SqlDataReader reader2 = command.ExecuteReader();
            while(reader2.Read())
            {
                comboBoxNetworks.Items.Add(reader2[0]);
            }
            reader2.Close();

            for(int i=65; i<91; i++)
            {
                comboBoxInitialAlphabet.Items.Add((char)i);
                comboBoxAlphabetStaffDetails.Items.Add((char)i);
            }
        }

        private void buttonEditAdmin_Click(object sender, EventArgs e)
        {
            StaffForm staff = new StaffForm(this);
            staff.Show();
        }

        private void buttonNewClientAdmin_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
        }

        private void buttonBackAdmin_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Unsaved changes will be lost. Do you want to continue?", "Confirmation Message.", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (frontPage != null)
                {
                    /*foreach (string s in frontPage.loginDetails)
                    {
                        frontPage.loginDetails.Remove(s);
                    }
                    frontPage.Show();*/
                    FrontPage frontPage2 = new FrontPage();
                    frontPage2.Show();
                }
                this.Close();
            }
        }

        private void buttonNewStaffAdmin_Click(object sender, EventArgs e)
        {
            StaffForm staffForm = new StaffForm();
            staffForm.Show();
        }

        private void buttonClientSearchAdmin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = sqlConnection;

            if (comboBoxInitialAlphabet.SelectedIndex < 0 && comboBoxNetworks.SelectedIndex < 0)
            {
                DialogResult result;
                result = MessageBox.Show("You didn't specify any search criteria, all customers will be displayed. Do you want to continue?", "Confirmation Message.", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    command.CommandText = "SELECT c.UserName AS [User Name], nwe.CellNumber AS [Cell Number], c.UserNIC AS [CNIC], c.Occupation, c.Constituency, c.Address, c.LoginPassword AS [Account Password], " +
                                    "nwe.RegistrationDate AS [Date of Activation], nwe.Active AS [Activation Status], nwe.DeactivationDate AS [Date of De-activation], n.NetworkName AS [Network]" +
                                    "FROM Customer c " +
                                    "LEFT OUTER JOIN Network_WeakEntity nwe on c.UserID=nwe.Customer_UserID " +
                                    "LEFT OUTER JOIN Networks n ON nwe.Networks_idNetworks=n.idNetworks ";

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();

                    adapter.Fill(ds, "SearchResult");

                    dataGridViewResultsClient.DataSource = ds.Tables["SearchResult"];
                    dataGridViewResultsClient.Refresh();
                }
            }
            else
            {
                string initialAlphabet = comboBoxInitialAlphabet.GetItemText(comboBoxInitialAlphabet.SelectedItem);
                Console.WriteLine(initialAlphabet);
                string network = comboBoxNetworks.GetItemText(comboBoxNetworks.SelectedItem);

                try
                {
                    command.CommandText = "SELECT c.UserName AS [User Name], nwe.CellNumber AS [Cell Number], c.UserNIC AS [CNIC], c.Occupation, c.Constituency, c.Address, c.LoginPassword AS [Account Password], " +
                                    "nwe.RegistrationDate AS [Date of Activation], nwe.Active AS [Activation Status], nwe.DeactivationDate AS [Date of De-activation], n.NetworkName AS [Network]" +
                                    "FROM Customer c " +
                                    "LEFT OUTER JOIN Network_WeakEntity nwe on c.UserID=nwe.Customer_UserID " +
                                    "LEFT OUTER JOIN Networks n ON nwe.Networks_idNetworks=n.idNetworks " +
                                    string.Format("WHERE c.UserName LIKE '{0}%' AND n.NetworkName LIKE '{1}' ", initialAlphabet, network);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();

                    adapter.Fill(ds, "SearchResult");

                    dataGridViewResultsClient.DataSource = ds.Tables["SearchResult"];
                    dataGridViewResultsClient.Refresh();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Please select a valid search criteria");
                }
            }
        }

        private void buttonClientViewAdmin_Click(object sender, EventArgs e)
        {
            int row = dataGridViewResultsClient.CurrentCell.RowIndex;
            string selectedClient = dataGridViewResultsClient.Rows[row].Cells[0].Value.ToString();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = sqlConnection;
            command.CommandText = string.Format("SELECT c.UserID, c.UserName, c.UserNIC, c.Occupation, c.Constituency, c.Address, c.LoginPassword" +
                                    " FROM Customer c" +
                                    " WHERE c.UserName LIKE '{0}' ", selectedClient);
            SqlDataReader reader = command.ExecuteReader();
            
            if(reader.Read())
            {
                int i = 0;
                while (i<7)
                {
                    clientDetails.Add(reader[i].ToString());
                    i++;
                }
            }
            reader.Close();

            command.CommandText = string.Format("SELECT n.NetworkName" +
                                    " FROM Customer c, Network_WeakEntity nwe, Networks n" +
                                    " WHERE c.UserID=nwe.Customer_UserID AND nwe.Networks_idNetworks=n.idNetworks AND " +
                                    "c.UserID=(SELECT UserID FROM Customer WHERE UserName LIKE '{0}')", selectedClient);
            reader = command.ExecuteReader();

            while(reader.Read())
            {
                clientNetworks.Add(reader[0].ToString());
            }
            reader.Close();

            Client client = new Client(this);
            client.Show();
        }

        private void dataGridViewResultsClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show(e.RowIndex.ToString());
        }

        private void buttonStaffSearchAdmin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = sqlConnection;

            if (comboBoxAlphabetStaffDetails.SelectedIndex < 0 && textBoxDesignationStaffDetails.Text.Length==0 && 
                textBoxSalaryFromStaffDetails.Text.Length==0 && textBoxSalaryToStaffDetails.Text.Length==0)
            {
                DialogResult result;
                result = MessageBox.Show("You didn't specify any search criteria, all customers will be displayed. Do you want to continue?", "Confirmation Message.", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    command.CommandText = "SELECT s.StaffName AS [Staff Name], s.Designation, s.NIC AS [CNIC], s.Salary, s.BankAccountNumber AS [Bank Account], s.Address, s.LoginPassword AS [Account Password], " +
                                    "sdr.Summary AS [Summary of Disciplinary Record], sdr.DateTime_2 AS [Date of Addition of Disciplinary Record]" +
                                    "FROM Staff s " +
                                    "LEFT OUTER JOIN StaffDisciplinaryRecord sdr on s.StaffID=sdr.Staff_StaffID";

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();

                    adapter.Fill(ds, "SearchResult");

                    dataGridViewResultsStaffDetails.DataSource = ds.Tables["SearchResult"];
                    dataGridViewResultsStaffDetails.Refresh();
                }
            }
            else
            {
                string initialAlphabet = comboBoxAlphabetStaffDetails.GetItemText(comboBoxAlphabetStaffDetails.SelectedItem);
                Console.WriteLine(initialAlphabet);
                string designation = textBoxDesignationStaffDetails.Text.ToString();

                try
                {
                    command.CommandText = "SELECT s.StaffName AS [Staff Name], s.Designation, s.NIC AS [CNIC], s.Salary, s.BankAccountNumber AS [Bank Account], s.Address, s.LoginPassword AS [Account Password], " +
                                    "sdr.Summary AS [Summary of Disciplinary Record], sdr.DateTime_2 AS [Date of Addition of Disciplinary Record] " +
                                    "FROM Staff s " +
                                    "LEFT OUTER JOIN StaffDisciplinaryRecord sdr on s.StaffID=sdr.Staff_StaffID " +
                                    string.Format("WHERE s.StaffName LIKE '{0}%' OR s.Designation LIKE '{1}' OR s.Salary BETWEEN {2} AND {3} ", initialAlphabet, designation, Convert.ToInt32(textBoxSalaryFromStaffDetails.Text.ToString()), Convert.ToInt32(textBoxSalaryToStaffDetails.Text.ToString()));

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();

                    adapter.Fill(ds, "SearchResult");

                    dataGridViewResultsStaffDetails.DataSource = ds.Tables["SearchResult"];
                    dataGridViewResultsStaffDetails.Refresh();
                }
                catch(Exception eee)
                {
                    MessageBox.Show("Please select a valid search criteria. ");
                }
            }
        }

        private void buttonStaffViewAdmin_Click(object sender, EventArgs e)
        {
            int row = dataGridViewResultsStaffDetails.CurrentCell.RowIndex;
            string selectedStaff = dataGridViewResultsStaffDetails.Rows[row].Cells[0].Value.ToString();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = sqlConnection;
            command.CommandText = string.Format("SELECT s.StaffID, s.StaffName, s.Designation, s.NIC, s.Address, s.Salary, s.BankAccountNumber, s.LoginPassword" +
                                    " FROM Staff s" +
                                    " WHERE s.StaffName LIKE '{0}' ", selectedStaff);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                int i = 0;
                while (i < 8)
                {
                    staffDetails.Add(reader[i].ToString());
                    i++;
                }
            }
            reader.Close();

            Staff staff = new Staff(this);
            staff.Show();
        }

        private void tabPageCustomerDetails_Click(object sender, EventArgs e)
        {

        }

        private void buttonStaffDeleteAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridViewResultsStaffDetails.CurrentCell.RowIndex;
                string selectedStaff = dataGridViewResultsStaffDetails.Rows[row].Cells[0].Value.ToString();

                DialogResult result;
                result = MessageBox.Show("Do you really want to delete the record permanently?", "Confirmation Message.", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.Connection = sqlConnection;
                    command.CommandText = string.Format("DELETE FROM {0} WHERE StaffName LIKE '{1}' ", "Staff", selectedStaff);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Record deleted permanently. ");
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("System could not delete the specified record. Try again later. ");
                    }
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show("Please select a valid cell. ");
            }
        }

        private void buttonClientDeleteAdmin_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void buttonClientDeleteAdmin_Click_1(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridViewResultsClient.CurrentCell.RowIndex;
                string selectedClient = dataGridViewResultsClient.Rows[row].Cells[0].Value.ToString();
                string cellNumber = "";
            
                SqlCommand command2 = new SqlCommand();
                command2.CommandType = CommandType.Text;
                command2.Connection = sqlConnection;

                command2.CommandText = "SELECT CellNumber FROM Network_WeakEntity WHERE Customer_UserID = " +
                string.Format("(SELECT UserID FROM Customer WHERE UserName LIKE '{0}' ) ", selectedClient);

                SqlDataReader dataReader = command2.ExecuteReader();
                if (dataReader.Read() == true)
                {
                    cellNumber = dataReader[0].ToString();
                }
                dataReader.Close();

                DialogResult result;
                result = MessageBox.Show("Do you really want to delete the record permanently?", "Confirmation Message.", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.Connection = sqlConnection;

                    SqlTransaction transaction = sqlConnection.BeginTransaction();
                    command.Transaction = transaction;
                    try
                    {
                        command.CommandText = string.Format("DELETE FROM {0} WHERE Network_WeakEntity_CellNumber LIKE '{1}' ", "MessageLog", cellNumber);
                        command.ExecuteNonQuery();

                        command.CommandText = string.Format("DELETE FROM {0} WHERE Network_WeakEntity_CellNumber1 LIKE '{1}' ", "CallLog", cellNumber);
                        command.ExecuteNonQuery();

                        command.CommandText = string.Format("DELETE FROM {0} WHERE Network_WeakEntity_CellNumber LIKE '{1}' ", "Payment", cellNumber);
                        command.ExecuteNonQuery();

                        command.CommandText = string.Format("DELETE FROM {0} WHERE Customer_UserID =  ", "Network_WeakEntity") +
                            string.Format("(SELECT UserID FROM Customer WHERE UserName LIKE '{0}' ) ", selectedClient);
                        command.ExecuteNonQuery();

                        command.CommandText = string.Format("DELETE FROM {0} WHERE UserName LIKE '{1}' ", "Customer", selectedClient);
                        command.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Record deleted permanently. ");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show("Please select a valid cell. ");
            }
        }
    }
}

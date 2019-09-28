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
    public partial class Staff : Form
    {
        SqlConnection sqlConnection;
        FrontPage frontPage = null;
        Administrator administrator = null;

        public List<string> staffDetails = new List<string>();
        public List<string> clientDetails = new List<string>();
        public List<string> clientNetworks = new List<string>();

        public Staff(Administrator administrator)
        {
            InitializeComponent();

            this.administrator = administrator;

            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=.; Initial Catalog=TelecommunicationManagementSystem; Integrated Security=true;";
            sqlConnection.Open();
        }

        public Staff(FrontPage frontPage)
        {
            InitializeComponent();

            this.frontPage = frontPage;

            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=.; Initial Catalog=TelecommunicationManagementSystem; Integrated Security=true;";
            sqlConnection.Open();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            if(frontPage!=null)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("SELECT s.StaffID, s.StaffName, s.Designation, s.NIC, s.Address, s.Salary, s.BankAccountNumber, s.LoginPassword" +
                                        " FROM Staff s" +
                                        " WHERE s.StaffName LIKE '{0}'", frontPage.loginDetails[0]);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read() == true)
                {
                    textBoxStaffIDStaff.Text = reader[0].ToString();
                    textBoxNameStaff.Text = reader[1].ToString();
                    textBoxDesignationStaff.Text = reader[2].ToString();
                    textBoxIDNoStaff.Text = reader[3].ToString();
                    textBoxAddressStaff.Text = reader[4].ToString();
                    textBoxSalaryStaff.Text = reader[5].ToString();
                    textBoxAccountNoStaff.Text = reader[6].ToString();
                    textBoxLoginPasswordStaff.Text = reader[7].ToString();
                }
                reader.Close();

            }
            else if(administrator!=null)
            {
                textBoxStaffIDStaff.Text = administrator.staffDetails[0].ToString();
                textBoxNameStaff.Text = administrator.staffDetails[1].ToString();
                textBoxDesignationStaff.Text = administrator.staffDetails[2].ToString();
                textBoxIDNoStaff.Text = administrator.staffDetails[3].ToString();
                textBoxAddressStaff.Text = administrator.staffDetails[4].ToString();
                textBoxSalaryStaff.Text = administrator.staffDetails[5].ToString();
                textBoxAccountNoStaff.Text = administrator.staffDetails[6].ToString();
                textBoxLoginPasswordStaff.Text = administrator.staffDetails[7].ToString();
            }

            staffDetails.Add(textBoxStaffIDStaff.Text);
            staffDetails.Add(textBoxNameStaff.Text);
            staffDetails.Add(textBoxDesignationStaff.Text);
            staffDetails.Add(textBoxIDNoStaff.Text);
            staffDetails.Add(textBoxAddressStaff.Text);
            staffDetails.Add(textBoxSalaryStaff.Text);
            staffDetails.Add(textBoxAccountNoStaff.Text);
            staffDetails.Add(textBoxLoginPasswordStaff.Text);

            SqlCommand command2 = new SqlCommand();

            command2.CommandText = "SELECT NetworkName FROM Networks";
            command2.CommandType = CommandType.Text;
            command2.Connection = sqlConnection;
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                comboBoxNetworkStaff.Items.Add(reader2[0]);
            }
            reader2.Close();

            for (int i = 65; i < 91; i++)
            {
                comboBoxInitialAlphabetStaff.Items.Add((char)i);
            }
        }

        private void buttonEditStaff_Click(object sender, EventArgs e)
        {
            StaffForm staff = new StaffForm(this);
            staff.Show();
        }

        private void buttonNewClientStaff_Click(object sender, EventArgs e)
        {
            ClientForm form = new ClientForm();
            form.Show();
        }

        private void buttonSearchCustomer_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = sqlConnection;

            if (comboBoxInitialAlphabetStaff.SelectedIndex < 0 && comboBoxNetworkStaff.SelectedIndex < 0)
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

                    dataGridViewResultsStaff.DataSource = ds.Tables["SearchResult"];
                    dataGridViewResultsStaff.Refresh();
                }
            }
            else
            {
                string initialAlphabet = comboBoxInitialAlphabetStaff.GetItemText(comboBoxInitialAlphabetStaff.SelectedItem);
                Console.WriteLine(initialAlphabet);
                string network = comboBoxNetworkStaff.GetItemText(comboBoxNetworkStaff.SelectedItem);

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

                    dataGridViewResultsStaff.DataSource = ds.Tables["SearchResult"];
                    dataGridViewResultsStaff.Refresh();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Please select a valid search criteria");
                }
            }
        }

        private void buttonClientViewStaff_Click(object sender, EventArgs e)
        {
            int row = dataGridViewResultsStaff.CurrentCell.RowIndex;
            string selectedClient = dataGridViewResultsStaff.Rows[row].Cells[0].Value.ToString();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = sqlConnection;
            command.CommandText = string.Format("SELECT c.UserID, c.UserName, c.UserNIC, c.Occupation, c.Constituency, c.Address, c.LoginPassword" +
                                    " FROM Customer c" +
                                    " WHERE c.UserName LIKE '{0}' ", selectedClient);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                int i = 0;
                while (i < 7)
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

            while (reader.Read())
            {
                clientNetworks.Add(reader[0].ToString());
            }
            reader.Close();

            Client client = new Client(this);
            client.Show();
        }

        private void tabPagePersonalDetails_Click(object sender, EventArgs e)
        {

        }

        private void buttonBackStaff_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Unsaved changes will be lost. Do you want to continue?", "Confirmation Message.", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (frontPage != null)
                {
                    /*foreach(string s in frontPage.loginDetails)
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

        private void buttonClientDeleteStaff_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridViewResultsStaff.CurrentCell.RowIndex;
                string selectedClient = dataGridViewResultsStaff.Rows[row].Cells[0].Value.ToString();
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

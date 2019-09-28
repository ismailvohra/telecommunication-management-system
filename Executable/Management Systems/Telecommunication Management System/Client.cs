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
    public partial class Client : Form
    {
        SqlConnection sqlConnection;
        FrontPage frontPage = null;
        Administrator administrator = null;
        Staff staff = null;

        
        public List<string> clientDetails = new List<string>();
        public List<string> clientNetworks = new List<string>();

        public Client(Staff staff)
        {
            this.staff = staff;
            InitializeComponent();
        }

        public Client(Administrator administrator)
        {
            this.administrator = administrator;
            InitializeComponent();
        }

        public Client(FrontPage frontPage)
        {
            InitializeComponent();

            this.frontPage = frontPage;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Call Log");
            comboBox1.Items.Add("Message Log");
            comboBox1.Items.Add("Total Bill");

            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=.; Initial Catalog=TelecommunicationManagementSystem; Integrated Security=true;";
            sqlConnection.Open();

            comboBoxMonth.Items.Add("January");
            comboBoxMonth.Items.Add("February");
            comboBoxMonth.Items.Add("March");
            comboBoxMonth.Items.Add("April");
            comboBoxMonth.Items.Add("May");
            comboBoxMonth.Items.Add("June");
            comboBoxMonth.Items.Add("July");
            comboBoxMonth.Items.Add("August");
            comboBoxMonth.Items.Add("September");
            comboBoxMonth.Items.Add("October");
            comboBoxMonth.Items.Add("November");
            comboBoxMonth.Items.Add("December");

            comboBoxYear.Items.Add("2012");
            comboBoxYear.Items.Add("2013");
            comboBoxYear.Items.Add("2014");
            comboBoxYear.Items.Add("2015");
            comboBoxYear.Items.Add("2016");
            comboBoxYear.Items.Add("2017");

            comboBoxNetworks.Items.Add("Zong");
            comboBoxNetworks.Items.Add("Jazz");
            comboBoxNetworks.Items.Add("Telenor");
            comboBoxNetworks.Items.Add("Ufone");
            comboBoxNetworks.Items.Add("Djuice");

            if (frontPage!=null)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT c.UserID, c.UserName, c.UserNIC, c.Occupation, c.Constituency, c.Address, c.LoginPassword" +
                                        " FROM Customer c" +
                                        string.Format(" WHERE c.UserName LIKE '{0}' ",frontPage.loginDetails[0]);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read() == true)
                {
                    textBoxUserIDClient.Text = reader[0].ToString();
                    textBoxUserNameClient.Text = reader[1].ToString();
                    textBoxIDNoClient.Text = reader[2].ToString();
                    textBoxOccupationClient.Text = reader[3].ToString();
                    textBoxConstituencyClient.Text = reader[4].ToString();
                    textBoxAddressClient.Text = reader[5].ToString();
                    textBoxLoginPasswordClient.Text = reader[6].ToString();
                }
                reader.Close();

                SqlCommand command2 = new SqlCommand();
                command2.Connection = sqlConnection;
                command2.CommandText = "SELECT n.NetworkName " +
                                        "FROM Networks n, Network_WeakEntity nwe, Customer c " +
                                        string.Format("WHERE n.idNetworks=nwe.Networks_idNetworks AND c.UserID=nwe.Customer_UserID AND c.UserName LIKE '{0}' ", frontPage.loginDetails[0]);
                command2.CommandType = CommandType.Text;
                SqlDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {
                    listBoxNetworksClient.Items.Add(reader2[0].ToString());
                }
                reader2.Close();
            }
            else if(administrator!=null || staff!=null)
            {
                if(administrator!=null)
                {
                    textBoxUserIDClient.Text = administrator.clientDetails[0].ToString();
                    textBoxUserNameClient.Text = administrator.clientDetails[1].ToString();
                    textBoxIDNoClient.Text = administrator.clientDetails[2].ToString();
                    textBoxOccupationClient.Text = administrator.clientDetails[3].ToString();
                    textBoxConstituencyClient.Text = administrator.clientDetails[4].ToString();
                    textBoxAddressClient.Text = administrator.clientDetails[5].ToString();
                    textBoxLoginPasswordClient.Text = administrator.clientDetails[6].ToString();

                    foreach (string s in administrator.clientNetworks)
                    {
                        listBoxNetworksClient.Items.Add(s);
                    }
                }
                else if(staff!=null)
                {
                    textBoxUserIDClient.Text = staff.clientDetails[0].ToString();
                    textBoxUserNameClient.Text = staff.clientDetails[1].ToString();
                    textBoxIDNoClient.Text = staff.clientDetails[2].ToString();
                    textBoxOccupationClient.Text = staff.clientDetails[3].ToString();
                    textBoxConstituencyClient.Text = staff.clientDetails[4].ToString();
                    textBoxAddressClient.Text = staff.clientDetails[5].ToString();
                    textBoxLoginPasswordClient.Text = staff.clientDetails[6].ToString();

                    foreach (string s in staff.clientNetworks)
                    {
                        listBoxNetworksClient.Items.Add(s);
                    }
                }
            }

            clientDetails.Add(textBoxUserIDClient.Text);
            clientDetails.Add(textBoxUserIDClient.Text);
            clientDetails.Add(textBoxIDNoClient.Text);
            clientDetails.Add(textBoxOccupationClient.Text);
            clientDetails.Add(textBoxConstituencyClient.Text);
            clientDetails.Add(textBoxAddressClient.Text);
            clientDetails.Add(textBoxLoginPasswordClient.Text);

            foreach(object li in listBoxNetworksClient.Items)
            {
                clientNetworks.Add(li.ToString());
            }
        }

        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm(this);
            clientForm.Show();
        }

        private void buttonBackClient_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Unsaved changes will be lost. Do you want to continue?", "Confirmation Message.", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if(frontPage!=null)
                {
                    /*foreach (string s in frontPage.loginDetails)
                    {
                        frontPage.loginDetails.Remove(s);
                    }*/
                    FrontPage frontPage2 = new FrontPage();
                    frontPage2.Show();
                }
                this.Close();
            }
        }

        private void textBoxMonthYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            //SqlDataReader dataReader = ;

            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    sqlCommand.CommandText = string.Format("select * from CallLog, Network_WeakEntity, Networks, Rate, Customer where DATEPART(month, DateTime_2) = {0} and DATEPART(year, DateTime_2) = {1} and CallLog.Rate_CallType = Rate.CallType and Network_WeakEntity.Customer_UserID = Customer.UserID and Customer_UserID = {2} and Network_WeakEntity.Networks_idNetworks = Networks.idNetworks and Networks.NetworkName = '{3}'", Convert.ToInt32(comboBoxMonth.SelectedIndex) + 1, comboBoxYear.SelectedItem, Convert.ToInt32(textBoxUserIDClient.Text), comboBoxNetworks.SelectedItem);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    sqlCommand.CommandText = string.Format("select * from MessageLog, Network_WeakEntity, Networks, Rate, Customer where DATEPART(month, DateTime_2) = {0} and DATEPART(year, DateTime_2) = {1} and Network_WeakEntity.Customer_UserID = Customer.UserID and Customer_UserID = {2} and Network_WeakEntity.Networks_idNetworks = Networks.idNetworks and Networks.NetworkName = '{3}'", Convert.ToInt32(comboBoxMonth.SelectedIndex) + 1, comboBoxYear.SelectedItem, Convert.ToInt32(textBoxUserIDClient.Text), comboBoxNetworks.SelectedItem);
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    sqlCommand.CommandText = string.Format("select((select SUM(Call_Duration * Rateperminute) from CallLog, Network_WeakEntity, Networks, Rate, Customer where DATEPART(month, DateTime_2) = {0} and DATEPART(year, DateTime_2) = {1} and CallLog.Rate_CallType = Rate.CallType and Network_WeakEntity.Customer_UserID = Customer.UserID and Customer_UserID = {2} and Network_WeakEntity.Networks_idNetworks = Networks.idNetworks and Networks.NetworkName like '{3}'", Convert.ToInt32(comboBoxMonth.SelectedIndex) + 1, comboBoxYear.SelectedItem, Convert.ToInt32(textBoxUserIDClient.Text), comboBoxNetworks.SelectedItem) +
                                                    string.Format(") + (select SUM(Rate) from MessageLog, Networks, Rate, Customer, Network_WeakEntity where DATEPART(month, DateTime_2) = {0} and DATEPART(year, DateTime_2) = {1} and Network_WeakEntity.Customer_UserID = Customer.UserID and Customer_UserID = {2} and Network_WeakEntity.Networks_idNetworks = Networks.idNetworks and Networks.NetworkName like '{3}'", Convert.ToInt32(comboBoxMonth.SelectedIndex) + 1, comboBoxYear.SelectedItem, Convert.ToInt32(textBoxUserIDClient.Text), comboBoxNetworks.SelectedItem) +
                                                    ")) as TotalBill";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "SearchResult");

                dataGridViewBilling.DataSource = ds.Tables["SearchResult"];
                dataGridViewBilling.Refresh();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Please fill all fields. ");
            }
        }
    }
}


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
    public partial class ClientForm : Form
    {
        SqlConnection sqlConnection;

        Client client = null;
        List<string> n = new List<string>();

        public ClientForm()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=.; Initial Catalog=TelecommunicationManagementSystem; Integrated Security=true;";
            sqlConnection.Open();

        }

        public ClientForm(Client client)
        {
            InitializeComponent();
            this.client = client;

            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=.; Initial Catalog=TelecommunicationManagementSystem; Integrated Security=true;";
            sqlConnection.Open();

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            foreach (string network in listBoxNetworkNewClient.Items)
            {
                n.Add(network);
            }
            
            if (client!=null)
            {
                textBoxUserIDNewClient.Text = client.clientDetails[0];
                textBoxUserNameNewClient.Text = client.clientDetails[1];
                textBoxIDNoNewClient.Text = client.clientDetails[2];
                textBoxOccupationNewClient.Text = client.clientDetails[3];
                textBoxConstituencyNewClient.Text = client.clientDetails[4];
                textBoxAddressNewClient.Text = client.clientDetails[5];
                textBoxLoginPasswordNewClient.Text = client.clientDetails[6];

                foreach (string data in client.clientNetworks)
                {
                    listBoxNetworkNewClient.Items.Add(data);
                }
            }
        }

        private void buttonOKNewClient_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                SqlTransaction tran = sqlConnection.BeginTransaction();

                try
                {
                    SqlCommand command = new SqlCommand();
                    command.Transaction = tran;
                    command.Connection = sqlConnection;

                    command.CommandText = "UPDATE Customer " +
                        "SET " + string.Format(" UserNIC={0}, UserName='{1}', Occupation='{2}', Constituency='{3}', Address='{4}', LoginPassword='{5}' " +
                        "WHERE UserID={6}",
                                            Convert.ToInt64(textBoxIDNoNewClient.Text), textBoxUserNameNewClient.Text, textBoxOccupationNewClient.Text,
                                            textBoxConstituencyNewClient.Text, textBoxAddressNewClient.Text, textBoxLoginPasswordNewClient.Text, textBoxUserIDNewClient.Text);
                    command.ExecuteNonQuery();

                    int len = n.Count - listBoxNetworkNewClient.Items.Count;

                    foreach(string s in n)
                    {
                        listBoxNetworkNewClient.Items.Remove(s);
                    }

                    foreach (string networkname in listBoxNetworkNewClient.Items)
                    {
                        command.CommandText = "INSERT Network_WeakEntity (CellNumber, Networks_idNetworks, Customer_UserID, RegistrationDate, Active) " +
                                            string.Format("VALUES ({0}, " +
                                                        "(SELECT idNetworks FROM Networks WHERE NetworkName LIKE '{1}'), " +
                                                        "(SELECT UserID FROM Customer WHERE UserName LIKE '{2}'), DATEFROMPARTS({3}, {4}, {5}), {6})", 03119332534,
                                            networkname, textBoxUserNameNewClient.Text, DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day,
                                            1);
                        command.ExecuteNonQuery();

                    }

                    foreach(string net in n)
                    {
                        listBoxNetworkNewClient.Items.Add(n);
                    }
                    tran.Commit();
                    MessageBox.Show("Changes saved permanently. ");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }

                /** update query on Customer table **/
            }
            else
            {
                SqlTransaction tran = sqlConnection.BeginTransaction();

                try
                {
                    SqlCommand command = new SqlCommand();
                    command.Transaction = tran;
                    command.Connection = sqlConnection;
                
                    command.CommandText = "INSERT Customer (UserNIC, UserName, Occupation, Constituency, Address, LoginPassword)" +
                                            string.Format("VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}')", 
                                            Convert.ToInt32(textBoxIDNoNewClient.Text), textBoxUserNameNewClient.Text, textBoxOccupationNewClient.Text, 
                                            textBoxConstituencyNewClient.Text, textBoxAddressNewClient.Text, textBoxLoginPasswordNewClient.Text);
                    command.ExecuteNonQuery();



                    foreach(string networkname in listBoxNetworkNewClient.Items)
                    {
                        command.CommandText = "INSERT Network_WeakEntity (CellNumber, Networks_idNetworks, Customer_UserID, RegistrationDate, Active) " +
                                            string.Format("VALUES ({0}, " +
                                                        "(SELECT idNetworks FROM Networks WHERE NetworkName LIKE '{1}'), " +
                                                        "(SELECT UserID FROM Customer WHERE UserName LIKE '{2}'), DATEFROMPARTS({3}, {4}, {5}), {6})", 03119332534,
                                            networkname, textBoxUserNameNewClient.Text, DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day,
                                            1);
                        command.ExecuteNonQuery();

                    }
                    tran.Commit();
                    MessageBox.Show("Changes saved permanently. ");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonCancelNewClient_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                client.Show();
                this.Close();
            }
            else
            {
                /** Think of a scenario. Think of a form to get open in default case. **/
            }
        }

        /*private void buttonAddNetwork_Click(object sender, EventArgs e)
        {
            if (comboBoxNetworkNewClient.Text.Length != 0)
            {
                listBoxNetworkNewClient.Items.Add(comboBoxNetworkNewClient.Text);
            }
        }*/

        private void textBoxLoginPasswordNewClient_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

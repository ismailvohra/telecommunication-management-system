using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;


namespace Telecommunication_Management_System
{
    public partial class FrontPage : Form
    {
		SqlConnection sqlConnection;
        public List<string> loginDetails = new List<string>();

        public FrontPage()
        {
			Thread thread = new Thread(new ThreadStart(SplashStart));

			thread.Start();
			Thread.Sleep(4000);
			InitializeComponent();
			thread.Abort();

			sqlConnection = new SqlConnection();
			sqlConnection.ConnectionString = "Data Source=.; Initial Catalog=TelecommunicationManagementSystem; Integrated Security=true;";
			sqlConnection.Open();
		}

		private void FrontPage_Load(object sender, EventArgs e)
		{

		}

		public void SplashStart()
		{
			Application.Run(new SplashScreen());
		}

		private void buttonLogin_Click(object sender, EventArgs e)
        {
			/*if(!(textBoxUserName.Text=="1" && textBoxPassword.Text=="1"))
            {
                MessageBox.Show("Invalid username or password.", "Login Failure!");
            }*/
			

			if (radioButtonAdministrator.Checked==false && radioButtonStaff.Checked==false && radioButtonClient.Checked==false)
			{
				MessageBox.Show("Please select a user type.", "Login Failure!");
			}
			else
			{
				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.Connection = sqlConnection;
				SqlDataReader dataReader;

				if (radioButtonAdministrator.Checked == true)
				{
                    sqlCommand.CommandText = "SELECT s.StaffName " +
                                            "FROM Staff s, Administrator a " +
                                            "WHERE a.Staff_StaffID=s.StaffID AND CurrentAdmin=1";
					sqlCommand.CommandType = CommandType.Text;

					dataReader = sqlCommand.ExecuteReader();

					int columnCount = dataReader.FieldCount;

					string adminName = "";
					while (dataReader.Read() == true)
					{
						if (dataReader.GetValue(0).ToString().Equals(textBoxUserName.Text.ToString()))
						{
							adminName = textBoxUserName.Text.ToString();
							break;
						}
					}
					dataReader.Close();

					if (adminName != "")
					{
						sqlCommand.CommandText = string.Format("SELECT LoginPassword FROM Staff WHERE StaffName like '{0}'", adminName);
						sqlCommand.CommandType = CommandType.Text;

                        dataReader = sqlCommand.ExecuteReader();

                        if (dataReader.Read() == true)
						{
							if (textBoxPassword.Text.ToString().Equals(dataReader.GetValue(0)))
							{
                                loginDetails.Add(textBoxUserName.Text);
                                loginDetails.Add(textBoxPassword.Text);

                                Administrator administrator = new Administrator(this);
								administrator.Show();
                                this.Hide();
                            }
							else
							{
								MessageBox.Show("Invalid username or password.", "Login Failure!");
							}
						}
                        dataReader.Close();
                    }
					else
					{
						MessageBox.Show("Invalid username or password.", "Login Failure!");
					}
				}
				else if (radioButtonStaff.Checked == true)
				{
					sqlCommand.CommandText = "SELECT StaffName FROM Staff";
					sqlCommand.CommandType = CommandType.Text;

					dataReader = sqlCommand.ExecuteReader();

					int columnCount = dataReader.FieldCount;

					string staffName = "";
					while (dataReader.Read() == true)
					{
						if (dataReader.GetValue(0).ToString().Equals(textBoxUserName.Text.ToString()))
						{
							staffName = textBoxUserName.Text.ToString();
							break;
						}
					}
					dataReader.Close();

					if (staffName != "")
					{
						sqlCommand.CommandText = string.Format("SELECT LoginPassword FROM Staff WHERE StaffName like '{0}'", staffName);
						sqlCommand.CommandType = CommandType.Text;

                        dataReader = sqlCommand.ExecuteReader();

                        if (dataReader.Read() == true)
						{
							if (textBoxPassword.Text.ToString().Equals(dataReader.GetValue(0)))
							{
                                loginDetails.Add(textBoxUserName.Text);
                                loginDetails.Add(textBoxPassword.Text);

                                Staff staff = new Staff(this);
								staff.Show();
                                this.Hide();
                            }
							else
							{
								MessageBox.Show("Invalid username or password.", "Login Failure!");
							}
						}
                        dataReader.Close();
                    }
					else
					{
						MessageBox.Show("Invalid username or password.", "Login Failure!");
					}					
				}
				else if (radioButtonClient.Checked == true)
				{
					sqlCommand.CommandText = "SELECT UserName FROM Customer";
					sqlCommand.CommandType = CommandType.Text;

					dataReader = sqlCommand.ExecuteReader();

					int columnCount = dataReader.FieldCount;

					string customerName = "";
					while (dataReader.Read() == true)
					{
						if (dataReader.GetValue(0).ToString().Equals(textBoxUserName.Text.ToString()))
						{
							customerName = textBoxUserName.Text.ToString();
							break;
						}
					}
					dataReader.Close();

					if (customerName != "")
					{
						sqlCommand.CommandText = string.Format("SELECT LoginPassword FROM Customer WHERE UserName like '{0}'", customerName);
						sqlCommand.CommandType = CommandType.Text;

                        dataReader = sqlCommand.ExecuteReader();

                        if (dataReader.Read() == true)
						{
							if (textBoxPassword.Text.ToString().Equals(dataReader.GetValue(0)))
							{
                                loginDetails.Add(textBoxUserName.Text);
                                loginDetails.Add(textBoxPassword.Text);

                                Client client = new Client(this);
								client.Show();
                                this.Hide();
                            }
							else
							{
								MessageBox.Show("Invalid username or password.", "Login Failure!");
							}
						}
                        dataReader.Close();
                    }
					else
					{
						MessageBox.Show("Invalid username or password.", "Login Failure!");
					}
				}
                //MessageBox.Show(loginDetails[0]);
			}
        }
        
		private void buttonExitApplication_Click(object sender, EventArgs e)
		{
			DialogResult result;
			result = MessageBox.Show("Do you really want to exit?", "Confirmation Message.", MessageBoxButtons.YesNo);

			if (result == System.Windows.Forms.DialogResult.Yes)
			{
				Thread thread = new Thread(new ThreadStart(SplashStart));
				thread.Start();
				Thread.Sleep(4000);
				thread.Abort();

				this.Close();
			}
		}

    }
}

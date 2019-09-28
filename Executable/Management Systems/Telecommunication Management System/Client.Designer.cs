namespace Telecommunication_Management_System
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.tabPagePersonalDetails = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEditClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLoginPasswordClient = new System.Windows.Forms.TextBox();
            this.listBoxNetworksClient = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxUserIDClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAddressClient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUserNameClient = new System.Windows.Forms.TextBox();
            this.textBoxConstituencyClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOccupationClient = new System.Windows.Forms.TextBox();
            this.textBoxIDNoClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageBillingInfo = new System.Windows.Forms.TabPage();
            this.dataGridViewBilling = new System.Windows.Forms.DataGridView();
            this.groupBoxSearchCriteria = new System.Windows.Forms.GroupBox();
            this.comboBoxNetworks = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelMonthYear = new System.Windows.Forms.Label();
            this.buttonBackClient = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControlClient.SuspendLayout();
            this.tabPagePersonalDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageBillingInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBilling)).BeginInit();
            this.groupBoxSearchCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlClient
            // 
            this.tabControlClient.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlClient.Controls.Add(this.tabPagePersonalDetails);
            this.tabControlClient.Controls.Add(this.tabPageBillingInfo);
            this.tabControlClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlClient.Location = new System.Drawing.Point(-1, 0);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(1178, 638);
            this.tabControlClient.TabIndex = 1;
            this.tabControlClient.Tag = "";
            // 
            // tabPagePersonalDetails
            // 
            this.tabPagePersonalDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPagePersonalDetails.BackgroundImage")));
            this.tabPagePersonalDetails.Controls.Add(this.groupBox1);
            this.tabPagePersonalDetails.Location = new System.Drawing.Point(4, 28);
            this.tabPagePersonalDetails.Name = "tabPagePersonalDetails";
            this.tabPagePersonalDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonalDetails.Size = new System.Drawing.Size(1170, 606);
            this.tabPagePersonalDetails.TabIndex = 0;
            this.tabPagePersonalDetails.Text = "Personal Details";
            this.tabPagePersonalDetails.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonEditClient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxLoginPasswordClient);
            this.groupBox1.Controls.Add(this.listBoxNetworksClient);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxUserIDClient);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxAddressClient);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxUserNameClient);
            this.groupBox1.Controls.Add(this.textBoxConstituencyClient);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxOccupationClient);
            this.groupBox1.Controls.Add(this.textBoxIDNoClient);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(28, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 554);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Info";
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditClient.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditClient.Location = new System.Drawing.Point(304, 478);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(75, 23);
            this.buttonEditClient.TabIndex = 20;
            this.buttonEditClient.Text = "Edit";
            this.buttonEditClient.UseVisualStyleBackColor = true;
            this.buttonEditClient.Click += new System.EventHandler(this.buttonEditClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "User ID:";
            // 
            // textBoxLoginPasswordClient
            // 
            this.textBoxLoginPasswordClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBoxLoginPasswordClient.Enabled = false;
            this.textBoxLoginPasswordClient.Location = new System.Drawing.Point(178, 408);
            this.textBoxLoginPasswordClient.Name = "textBoxLoginPasswordClient";
            this.textBoxLoginPasswordClient.PasswordChar = '*';
            this.textBoxLoginPasswordClient.Size = new System.Drawing.Size(201, 23);
            this.textBoxLoginPasswordClient.TabIndex = 18;
            // 
            // listBoxNetworksClient
            // 
            this.listBoxNetworksClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listBoxNetworksClient.Enabled = false;
            this.listBoxNetworksClient.FormattingEnabled = true;
            this.listBoxNetworksClient.ItemHeight = 18;
            this.listBoxNetworksClient.Location = new System.Drawing.Point(178, 300);
            this.listBoxNetworksClient.Name = "listBoxNetworksClient";
            this.listBoxNetworksClient.Size = new System.Drawing.Size(201, 76);
            this.listBoxNetworksClient.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Login Password:";
            // 
            // textBoxUserIDClient
            // 
            this.textBoxUserIDClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBoxUserIDClient.Enabled = false;
            this.textBoxUserIDClient.Location = new System.Drawing.Point(178, 34);
            this.textBoxUserIDClient.Name = "textBoxUserIDClient";
            this.textBoxUserIDClient.Size = new System.Drawing.Size(201, 23);
            this.textBoxUserIDClient.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name:";
            // 
            // textBoxAddressClient
            // 
            this.textBoxAddressClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBoxAddressClient.Enabled = false;
            this.textBoxAddressClient.Location = new System.Drawing.Point(178, 233);
            this.textBoxAddressClient.Name = "textBoxAddressClient";
            this.textBoxAddressClient.Size = new System.Drawing.Size(201, 23);
            this.textBoxAddressClient.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Networks:";
            // 
            // textBoxUserNameClient
            // 
            this.textBoxUserNameClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBoxUserNameClient.Enabled = false;
            this.textBoxUserNameClient.Location = new System.Drawing.Point(178, 72);
            this.textBoxUserNameClient.Name = "textBoxUserNameClient";
            this.textBoxUserNameClient.Size = new System.Drawing.Size(201, 23);
            this.textBoxUserNameClient.TabIndex = 11;
            // 
            // textBoxConstituencyClient
            // 
            this.textBoxConstituencyClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBoxConstituencyClient.Enabled = false;
            this.textBoxConstituencyClient.Location = new System.Drawing.Point(178, 187);
            this.textBoxConstituencyClient.Name = "textBoxConstituencyClient";
            this.textBoxConstituencyClient.Size = new System.Drawing.Size(201, 23);
            this.textBoxConstituencyClient.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Identification Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address:";
            // 
            // textBoxOccupationClient
            // 
            this.textBoxOccupationClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBoxOccupationClient.Enabled = false;
            this.textBoxOccupationClient.Location = new System.Drawing.Point(177, 146);
            this.textBoxOccupationClient.Name = "textBoxOccupationClient";
            this.textBoxOccupationClient.Size = new System.Drawing.Size(201, 23);
            this.textBoxOccupationClient.TabIndex = 12;
            // 
            // textBoxIDNoClient
            // 
            this.textBoxIDNoClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBoxIDNoClient.Enabled = false;
            this.textBoxIDNoClient.Location = new System.Drawing.Point(178, 108);
            this.textBoxIDNoClient.Name = "textBoxIDNoClient";
            this.textBoxIDNoClient.Size = new System.Drawing.Size(201, 23);
            this.textBoxIDNoClient.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Occupation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Constituency:";
            // 
            // tabPageBillingInfo
            // 
            this.tabPageBillingInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageBillingInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageBillingInfo.BackgroundImage")));
            this.tabPageBillingInfo.Controls.Add(this.dataGridViewBilling);
            this.tabPageBillingInfo.Controls.Add(this.groupBoxSearchCriteria);
            this.tabPageBillingInfo.Location = new System.Drawing.Point(4, 28);
            this.tabPageBillingInfo.Name = "tabPageBillingInfo";
            this.tabPageBillingInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBillingInfo.Size = new System.Drawing.Size(1170, 606);
            this.tabPageBillingInfo.TabIndex = 1;
            this.tabPageBillingInfo.Text = "Billing Info";
            // 
            // dataGridViewBilling
            // 
            this.dataGridViewBilling.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBilling.Location = new System.Drawing.Point(13, 235);
            this.dataGridViewBilling.Name = "dataGridViewBilling";
            this.dataGridViewBilling.Size = new System.Drawing.Size(1146, 335);
            this.dataGridViewBilling.TabIndex = 1;
            // 
            // groupBoxSearchCriteria
            // 
            this.groupBoxSearchCriteria.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSearchCriteria.Controls.Add(this.comboBox1);
            this.groupBoxSearchCriteria.Controls.Add(this.comboBoxNetworks);
            this.groupBoxSearchCriteria.Controls.Add(this.label10);
            this.groupBoxSearchCriteria.Controls.Add(this.comboBoxYear);
            this.groupBoxSearchCriteria.Controls.Add(this.comboBoxMonth);
            this.groupBoxSearchCriteria.Controls.Add(this.label9);
            this.groupBoxSearchCriteria.Controls.Add(this.buttonSearch);
            this.groupBoxSearchCriteria.Controls.Add(this.labelMonthYear);
            this.groupBoxSearchCriteria.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearchCriteria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBoxSearchCriteria.Location = new System.Drawing.Point(18, 11);
            this.groupBoxSearchCriteria.Name = "groupBoxSearchCriteria";
            this.groupBoxSearchCriteria.Size = new System.Drawing.Size(398, 209);
            this.groupBoxSearchCriteria.TabIndex = 0;
            this.groupBoxSearchCriteria.TabStop = false;
            this.groupBoxSearchCriteria.Text = "Search Criteria";
            // 
            // comboBoxNetworks
            // 
            this.comboBoxNetworks.FormattingEnabled = true;
            this.comboBoxNetworks.Location = new System.Drawing.Point(151, 24);
            this.comboBoxNetworks.Name = "comboBoxNetworks";
            this.comboBoxNetworks.Size = new System.Drawing.Size(172, 26);
            this.comboBoxNetworks.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Network:";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(151, 119);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(172, 26);
            this.comboBoxYear.TabIndex = 6;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(151, 70);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(172, 26);
            this.comboBoxMonth.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Year:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(36, 175);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(84, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelMonthYear
            // 
            this.labelMonthYear.AutoSize = true;
            this.labelMonthYear.Location = new System.Drawing.Point(33, 78);
            this.labelMonthYear.Name = "labelMonthYear";
            this.labelMonthYear.Size = new System.Drawing.Size(49, 18);
            this.labelMonthYear.TabIndex = 1;
            this.labelMonthYear.Text = "Month:";
            // 
            // buttonBackClient
            // 
            this.buttonBackClient.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonBackClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackClient.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackClient.Location = new System.Drawing.Point(1080, 604);
            this.buttonBackClient.Name = "buttonBackClient";
            this.buttonBackClient.Size = new System.Drawing.Size(75, 23);
            this.buttonBackClient.TabIndex = 2;
            this.buttonBackClient.Text = "Back";
            this.buttonBackClient.UseVisualStyleBackColor = false;
            this.buttonBackClient.Click += new System.EventHandler(this.buttonBackClient_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 26);
            this.comboBox1.TabIndex = 2;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 639);
            this.Controls.Add(this.buttonBackClient);
            this.Controls.Add(this.tabControlClient);
            this.MaximizeBox = false;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.tabControlClient.ResumeLayout(false);
            this.tabPagePersonalDetails.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageBillingInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBilling)).EndInit();
            this.groupBoxSearchCriteria.ResumeLayout(false);
            this.groupBoxSearchCriteria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClient;
        private System.Windows.Forms.TabPage tabPagePersonalDetails;
        private System.Windows.Forms.TabPage tabPageBillingInfo;
        private System.Windows.Forms.GroupBox groupBoxSearchCriteria;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelMonthYear;
        private System.Windows.Forms.DataGridView dataGridViewBilling;
        private System.Windows.Forms.Button buttonBackClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEditClient;
        private System.Windows.Forms.ListBox listBoxNetworksClient;
        private System.Windows.Forms.TextBox textBoxLoginPasswordClient;
        private System.Windows.Forms.TextBox textBoxAddressClient;
        private System.Windows.Forms.TextBox textBoxConstituencyClient;
        private System.Windows.Forms.TextBox textBoxOccupationClient;
        private System.Windows.Forms.TextBox textBoxUserNameClient;
        private System.Windows.Forms.TextBox textBoxIDNoClient;
        private System.Windows.Forms.TextBox textBoxUserIDClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxNetworks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
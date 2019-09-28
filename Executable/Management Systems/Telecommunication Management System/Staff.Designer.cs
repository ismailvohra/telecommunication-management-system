namespace Telecommunication_Management_System
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.tabControlStaff = new System.Windows.Forms.TabControl();
            this.tabPagePersonalDetails = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonEditStaff = new System.Windows.Forms.Button();
            this.textBoxStaffIDStaff = new System.Windows.Forms.TextBox();
            this.textBoxLoginPasswordStaff = new System.Windows.Forms.TextBox();
            this.textBoxAccountNoStaff = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNameStaff = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSalaryStaff = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDesignationStaff = new System.Windows.Forms.TextBox();
            this.textBoxAddressStaff = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIDNoStaff = new System.Windows.Forms.TextBox();
            this.tabPageCustomerDetails = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewResultsStaff = new System.Windows.Forms.DataGridView();
            this.buttonClientViewStaff = new System.Windows.Forms.Button();
            this.buttonNewClientStaff = new System.Windows.Forms.Button();
            this.buttonClientDeleteStaff = new System.Windows.Forms.Button();
            this.groupBoxSearchCustomer = new System.Windows.Forms.GroupBox();
            this.comboBoxNetworkStaff = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxInitialAlphabetStaff = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSearchCustomer = new System.Windows.Forms.Button();
            this.buttonBackStaff = new System.Windows.Forms.Button();
            this.tabControlStaff.SuspendLayout();
            this.tabPagePersonalDetails.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageCustomerDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultsStaff)).BeginInit();
            this.groupBoxSearchCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlStaff
            // 
            this.tabControlStaff.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlStaff.Controls.Add(this.tabPagePersonalDetails);
            this.tabControlStaff.Controls.Add(this.tabPageCustomerDetails);
            this.tabControlStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlStaff.Location = new System.Drawing.Point(-5, 0);
            this.tabControlStaff.Name = "tabControlStaff";
            this.tabControlStaff.SelectedIndex = 0;
            this.tabControlStaff.Size = new System.Drawing.Size(1184, 647);
            this.tabControlStaff.TabIndex = 0;
            // 
            // tabPagePersonalDetails
            // 
            this.tabPagePersonalDetails.BackColor = System.Drawing.Color.Black;
            this.tabPagePersonalDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPagePersonalDetails.BackgroundImage")));
            this.tabPagePersonalDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPagePersonalDetails.Controls.Add(this.groupBox3);
            this.tabPagePersonalDetails.Location = new System.Drawing.Point(4, 28);
            this.tabPagePersonalDetails.Name = "tabPagePersonalDetails";
            this.tabPagePersonalDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonalDetails.Size = new System.Drawing.Size(1176, 615);
            this.tabPagePersonalDetails.TabIndex = 0;
            this.tabPagePersonalDetails.Text = "Personal Details";
            this.tabPagePersonalDetails.Click += new System.EventHandler(this.tabPagePersonalDetails_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.buttonEditStaff);
            this.groupBox3.Controls.Add(this.textBoxStaffIDStaff);
            this.groupBox3.Controls.Add(this.textBoxLoginPasswordStaff);
            this.groupBox3.Controls.Add(this.textBoxAccountNoStaff);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxNameStaff);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxSalaryStaff);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxDesignationStaff);
            this.groupBox3.Controls.Add(this.textBoxAddressStaff);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxIDNoStaff);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(39, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 565);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personal Info";
            // 
            // buttonEditStaff
            // 
            this.buttonEditStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditStaff.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditStaff.Location = new System.Drawing.Point(293, 503);
            this.buttonEditStaff.Name = "buttonEditStaff";
            this.buttonEditStaff.Size = new System.Drawing.Size(75, 23);
            this.buttonEditStaff.TabIndex = 26;
            this.buttonEditStaff.Text = "Edit";
            this.buttonEditStaff.UseVisualStyleBackColor = true;
            this.buttonEditStaff.Click += new System.EventHandler(this.buttonEditStaff_Click);
            // 
            // textBoxStaffIDStaff
            // 
            this.textBoxStaffIDStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxStaffIDStaff.Enabled = false;
            this.textBoxStaffIDStaff.Location = new System.Drawing.Point(179, 49);
            this.textBoxStaffIDStaff.Name = "textBoxStaffIDStaff";
            this.textBoxStaffIDStaff.Size = new System.Drawing.Size(189, 23);
            this.textBoxStaffIDStaff.TabIndex = 13;
            // 
            // textBoxLoginPasswordStaff
            // 
            this.textBoxLoginPasswordStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxLoginPasswordStaff.Enabled = false;
            this.textBoxLoginPasswordStaff.Location = new System.Drawing.Point(179, 410);
            this.textBoxLoginPasswordStaff.Name = "textBoxLoginPasswordStaff";
            this.textBoxLoginPasswordStaff.PasswordChar = '*';
            this.textBoxLoginPasswordStaff.Size = new System.Drawing.Size(189, 23);
            this.textBoxLoginPasswordStaff.TabIndex = 24;
            // 
            // textBoxAccountNoStaff
            // 
            this.textBoxAccountNoStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxAccountNoStaff.Enabled = false;
            this.textBoxAccountNoStaff.Location = new System.Drawing.Point(179, 351);
            this.textBoxAccountNoStaff.Name = "textBoxAccountNoStaff";
            this.textBoxAccountNoStaff.Size = new System.Drawing.Size(189, 23);
            this.textBoxAccountNoStaff.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Login Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Staff ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Name:";
            // 
            // textBoxNameStaff
            // 
            this.textBoxNameStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxNameStaff.Enabled = false;
            this.textBoxNameStaff.Location = new System.Drawing.Point(179, 101);
            this.textBoxNameStaff.Name = "textBoxNameStaff";
            this.textBoxNameStaff.Size = new System.Drawing.Size(189, 23);
            this.textBoxNameStaff.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Bank Account No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Designation:";
            // 
            // textBoxSalaryStaff
            // 
            this.textBoxSalaryStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxSalaryStaff.Enabled = false;
            this.textBoxSalaryStaff.Location = new System.Drawing.Point(179, 295);
            this.textBoxSalaryStaff.Name = "textBoxSalaryStaff";
            this.textBoxSalaryStaff.Size = new System.Drawing.Size(189, 23);
            this.textBoxSalaryStaff.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Salary:";
            // 
            // textBoxDesignationStaff
            // 
            this.textBoxDesignationStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxDesignationStaff.Enabled = false;
            this.textBoxDesignationStaff.Location = new System.Drawing.Point(179, 147);
            this.textBoxDesignationStaff.Name = "textBoxDesignationStaff";
            this.textBoxDesignationStaff.Size = new System.Drawing.Size(189, 23);
            this.textBoxDesignationStaff.TabIndex = 15;
            // 
            // textBoxAddressStaff
            // 
            this.textBoxAddressStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxAddressStaff.Enabled = false;
            this.textBoxAddressStaff.Location = new System.Drawing.Point(179, 247);
            this.textBoxAddressStaff.Name = "textBoxAddressStaff";
            this.textBoxAddressStaff.Size = new System.Drawing.Size(189, 23);
            this.textBoxAddressStaff.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Identification No:";
            // 
            // textBoxIDNoStaff
            // 
            this.textBoxIDNoStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxIDNoStaff.Enabled = false;
            this.textBoxIDNoStaff.Location = new System.Drawing.Point(179, 199);
            this.textBoxIDNoStaff.Name = "textBoxIDNoStaff";
            this.textBoxIDNoStaff.Size = new System.Drawing.Size(189, 23);
            this.textBoxIDNoStaff.TabIndex = 14;
            // 
            // tabPageCustomerDetails
            // 
            this.tabPageCustomerDetails.BackColor = System.Drawing.Color.Black;
            this.tabPageCustomerDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageCustomerDetails.BackgroundImage")));
            this.tabPageCustomerDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPageCustomerDetails.Controls.Add(this.groupBox2);
            this.tabPageCustomerDetails.Controls.Add(this.groupBoxSearchCustomer);
            this.tabPageCustomerDetails.Location = new System.Drawing.Point(4, 28);
            this.tabPageCustomerDetails.Name = "tabPageCustomerDetails";
            this.tabPageCustomerDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomerDetails.Size = new System.Drawing.Size(1176, 615);
            this.tabPageCustomerDetails.TabIndex = 2;
            this.tabPageCustomerDetails.Text = "Client Details";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridViewResultsStaff);
            this.groupBox2.Controls.Add(this.buttonClientViewStaff);
            this.groupBox2.Controls.Add(this.buttonNewClientStaff);
            this.groupBox2.Controls.Add(this.buttonClientDeleteStaff);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(513, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 412);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // dataGridViewResultsStaff
            // 
            this.dataGridViewResultsStaff.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewResultsStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultsStaff.Location = new System.Drawing.Point(20, 21);
            this.dataGridViewResultsStaff.Name = "dataGridViewResultsStaff";
            this.dataGridViewResultsStaff.Size = new System.Drawing.Size(595, 256);
            this.dataGridViewResultsStaff.TabIndex = 0;
            // 
            // buttonClientViewStaff
            // 
            this.buttonClientViewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClientViewStaff.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientViewStaff.ForeColor = System.Drawing.Color.Red;
            this.buttonClientViewStaff.Location = new System.Drawing.Point(459, 329);
            this.buttonClientViewStaff.Name = "buttonClientViewStaff";
            this.buttonClientViewStaff.Size = new System.Drawing.Size(75, 23);
            this.buttonClientViewStaff.TabIndex = 4;
            this.buttonClientViewStaff.Text = "View";
            this.buttonClientViewStaff.UseVisualStyleBackColor = true;
            this.buttonClientViewStaff.Click += new System.EventHandler(this.buttonClientViewStaff_Click);
            // 
            // buttonNewClientStaff
            // 
            this.buttonNewClientStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNewClientStaff.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewClientStaff.ForeColor = System.Drawing.Color.Red;
            this.buttonNewClientStaff.Location = new System.Drawing.Point(459, 367);
            this.buttonNewClientStaff.Name = "buttonNewClientStaff";
            this.buttonNewClientStaff.Size = new System.Drawing.Size(156, 23);
            this.buttonNewClientStaff.TabIndex = 5;
            this.buttonNewClientStaff.Text = "New Client";
            this.buttonNewClientStaff.UseVisualStyleBackColor = true;
            this.buttonNewClientStaff.Click += new System.EventHandler(this.buttonNewClientStaff_Click);
            // 
            // buttonClientDeleteStaff
            // 
            this.buttonClientDeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClientDeleteStaff.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientDeleteStaff.ForeColor = System.Drawing.Color.Red;
            this.buttonClientDeleteStaff.Location = new System.Drawing.Point(540, 329);
            this.buttonClientDeleteStaff.Name = "buttonClientDeleteStaff";
            this.buttonClientDeleteStaff.Size = new System.Drawing.Size(75, 23);
            this.buttonClientDeleteStaff.TabIndex = 2;
            this.buttonClientDeleteStaff.Text = "Delete";
            this.buttonClientDeleteStaff.UseVisualStyleBackColor = true;
            this.buttonClientDeleteStaff.Click += new System.EventHandler(this.buttonClientDeleteStaff_Click);
            // 
            // groupBoxSearchCustomer
            // 
            this.groupBoxSearchCustomer.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSearchCustomer.Controls.Add(this.comboBoxNetworkStaff);
            this.groupBoxSearchCustomer.Controls.Add(this.label1);
            this.groupBoxSearchCustomer.Controls.Add(this.comboBoxInitialAlphabetStaff);
            this.groupBoxSearchCustomer.Controls.Add(this.label10);
            this.groupBoxSearchCustomer.Controls.Add(this.buttonSearchCustomer);
            this.groupBoxSearchCustomer.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearchCustomer.ForeColor = System.Drawing.Color.Red;
            this.groupBoxSearchCustomer.Location = new System.Drawing.Point(27, 30);
            this.groupBoxSearchCustomer.Name = "groupBoxSearchCustomer";
            this.groupBoxSearchCustomer.Size = new System.Drawing.Size(458, 190);
            this.groupBoxSearchCustomer.TabIndex = 1;
            this.groupBoxSearchCustomer.TabStop = false;
            this.groupBoxSearchCustomer.Text = "Search";
            // 
            // comboBoxNetworkStaff
            // 
            this.comboBoxNetworkStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.comboBoxNetworkStaff.FormattingEnabled = true;
            this.comboBoxNetworkStaff.Location = new System.Drawing.Point(207, 74);
            this.comboBoxNetworkStaff.Name = "comboBoxNetworkStaff";
            this.comboBoxNetworkStaff.Size = new System.Drawing.Size(199, 26);
            this.comboBoxNetworkStaff.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Network:";
            // 
            // comboBoxInitialAlphabetStaff
            // 
            this.comboBoxInitialAlphabetStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.comboBoxInitialAlphabetStaff.FormattingEnabled = true;
            this.comboBoxInitialAlphabetStaff.Location = new System.Drawing.Point(207, 33);
            this.comboBoxInitialAlphabetStaff.Name = "comboBoxInitialAlphabetStaff";
            this.comboBoxInitialAlphabetStaff.Size = new System.Drawing.Size(199, 26);
            this.comboBoxInitialAlphabetStaff.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "Search Name by Alphabet:";
            // 
            // buttonSearchCustomer
            // 
            this.buttonSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchCustomer.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchCustomer.Location = new System.Drawing.Point(327, 125);
            this.buttonSearchCustomer.Name = "buttonSearchCustomer";
            this.buttonSearchCustomer.Size = new System.Drawing.Size(79, 23);
            this.buttonSearchCustomer.TabIndex = 6;
            this.buttonSearchCustomer.Text = "Search";
            this.buttonSearchCustomer.UseVisualStyleBackColor = true;
            this.buttonSearchCustomer.Click += new System.EventHandler(this.buttonSearchCustomer_Click);
            // 
            // buttonBackStaff
            // 
            this.buttonBackStaff.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonBackStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackStaff.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackStaff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBackStaff.Location = new System.Drawing.Point(1062, 587);
            this.buttonBackStaff.Name = "buttonBackStaff";
            this.buttonBackStaff.Size = new System.Drawing.Size(75, 23);
            this.buttonBackStaff.TabIndex = 1;
            this.buttonBackStaff.Text = "Back";
            this.buttonBackStaff.UseVisualStyleBackColor = false;
            this.buttonBackStaff.Click += new System.EventHandler(this.buttonBackStaff_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 639);
            this.Controls.Add(this.buttonBackStaff);
            this.Controls.Add(this.tabControlStaff);
            this.MaximizeBox = false;
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.tabControlStaff.ResumeLayout(false);
            this.tabPagePersonalDetails.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageCustomerDetails.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultsStaff)).EndInit();
            this.groupBoxSearchCustomer.ResumeLayout(false);
            this.groupBoxSearchCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStaff;
        private System.Windows.Forms.TabPage tabPagePersonalDetails;
        private System.Windows.Forms.TabPage tabPageCustomerDetails;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewResultsStaff;
        private System.Windows.Forms.Button buttonClientViewStaff;
        private System.Windows.Forms.Button buttonNewClientStaff;
        private System.Windows.Forms.Button buttonClientDeleteStaff;
        private System.Windows.Forms.GroupBox groupBoxSearchCustomer;
        private System.Windows.Forms.Button buttonSearchCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNameStaff;
        private System.Windows.Forms.TextBox textBoxDesignationStaff;
        private System.Windows.Forms.TextBox textBoxIDNoStaff;
        private System.Windows.Forms.TextBox textBoxStaffIDStaff;
        private System.Windows.Forms.TextBox textBoxAddressStaff;
        private System.Windows.Forms.TextBox textBoxSalaryStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonEditStaff;
        private System.Windows.Forms.TextBox textBoxAccountNoStaff;
        private System.Windows.Forms.TextBox textBoxLoginPasswordStaff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxInitialAlphabetStaff;
        private System.Windows.Forms.ComboBox comboBoxNetworkStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonBackStaff;
    }
}
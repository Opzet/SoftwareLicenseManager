namespace License
{
    partial class frmDiagnostics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiagnostics));
            this.btnCreateLicense = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMyLicense = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResponse = new System.Windows.Forms.Label();
            this.btnCheckKey = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnActivate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.TxtDomain = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTransId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExpiry = new System.Windows.Forms.TextBox();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLicenseServer = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKeyLicCreate = new System.Windows.Forms.TextBox();
            this.txtKeyQuery = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAllowedInstalls = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProductref = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.listActivations = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateLicense
            // 
            this.btnCreateLicense.BackColor = System.Drawing.Color.Gray;
            this.btnCreateLicense.Location = new System.Drawing.Point(163, 356);
            this.btnCreateLicense.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreateLicense.Name = "btnCreateLicense";
            this.btnCreateLicense.Size = new System.Drawing.Size(214, 35);
            this.btnCreateLicense.TabIndex = 0;
            this.btnCreateLicense.Text = "Debug - Create License";
            this.btnCreateLicense.UseVisualStyleBackColor = false;
            this.btnCreateLicense.Click += new System.EventHandler(this.btnCreateLicense_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 92);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter the license key for this product to activate it. \r\nYou were given a " +
    "license key when you purchased this item";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMyLicense
            // 
            this.txtMyLicense.Location = new System.Drawing.Point(176, 244);
            this.txtMyLicense.Margin = new System.Windows.Forms.Padding(5);
            this.txtMyLicense.Name = "txtMyLicense";
            this.txtMyLicense.Size = new System.Drawing.Size(159, 29);
            this.txtMyLicense.TabIndex = 2;
            this.txtMyLicense.Text = "5b3fc6fcd83d7";
            this.txtMyLicense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 601);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "The following message was returned from the server:";
            // 
            // lblResponse
            // 
            this.lblResponse.BackColor = System.Drawing.Color.White;
            this.lblResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResponse.Location = new System.Drawing.Point(11, 622);
            this.lblResponse.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(763, 58);
            this.lblResponse.TabIndex = 4;
            this.lblResponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckKey
            // 
            this.btnCheckKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCheckKey.Location = new System.Drawing.Point(176, 279);
            this.btnCheckKey.Margin = new System.Windows.Forms.Padding(5);
            this.btnCheckKey.Name = "btnCheckKey";
            this.btnCheckKey.Size = new System.Drawing.Size(159, 83);
            this.btnCheckKey.TabIndex = 5;
            this.btnCheckKey.Text = "Check \r\n(Embed in Application)";
            this.btnCheckKey.UseVisualStyleBackColor = false;
            this.btnCheckKey.Click += new System.EventHandler(this.btnCheckKey_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(131, 89);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(215, 29);
            this.txtFirstName.TabIndex = 6;
            this.txtFirstName.Text = "Bob";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(131, 127);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(215, 29);
            this.txtLastName.TabIndex = 7;
            this.txtLastName.Text = "Smith";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 165);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(215, 29);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Text = "bob.smith@bs.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // btnActivate
            // 
            this.btnActivate.BackColor = System.Drawing.Color.Blue;
            this.btnActivate.ForeColor = System.Drawing.Color.White;
            this.btnActivate.Location = new System.Drawing.Point(113, 121);
            this.btnActivate.Margin = new System.Windows.Forms.Padding(5);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(138, 35);
            this.btnActivate.TabIndex = 12;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = false;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Item";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Domain";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(75, 60);
            this.txtItem.Margin = new System.Windows.Forms.Padding(5);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(176, 29);
            this.txtItem.TabIndex = 14;
            this.txtItem.Text = "License Test";
            this.txtItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtDomain
            // 
            this.TxtDomain.Location = new System.Drawing.Point(75, 30);
            this.TxtDomain.Margin = new System.Windows.Forms.Padding(5);
            this.TxtDomain.Name = "TxtDomain";
            this.TxtDomain.Size = new System.Drawing.Size(176, 29);
            this.TxtDomain.TabIndex = 13;
            this.TxtDomain.Text = "Domain";
            this.TxtDomain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 247);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Transaction id";
            // 
            // txtTransId
            // 
            this.txtTransId.Location = new System.Drawing.Point(131, 241);
            this.txtTransId.Margin = new System.Windows.Forms.Padding(5);
            this.txtTransId.Name = "txtTransId";
            this.txtTransId.Size = new System.Drawing.Size(215, 29);
            this.txtTransId.TabIndex = 17;
            this.txtTransId.Text = "Trans ID 1";
            this.txtTransId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Expiry";
            // 
            // txtExpiry
            // 
            this.txtExpiry.Location = new System.Drawing.Point(75, 91);
            this.txtExpiry.Margin = new System.Windows.Forms.Padding(5);
            this.txtExpiry.Name = "txtExpiry";
            this.txtExpiry.Size = new System.Drawing.Size(176, 29);
            this.txtExpiry.TabIndex = 19;
            this.txtExpiry.Text = "2019/01/01";
            this.txtExpiry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.BackColor = System.Drawing.Color.Red;
            this.btnDeactivate.Location = new System.Drawing.Point(56, 577);
            this.btnDeactivate.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(138, 35);
            this.btnDeactivate.TabIndex = 21;
            this.btnDeactivate.Text = "DeActivate";
            this.btnDeactivate.UseVisualStyleBackColor = false;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 208);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 21);
            this.label10.TabIndex = 23;
            this.label10.Text = "Company";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(131, 203);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(5);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(215, 29);
            this.txtCompany.TabIndex = 22;
            this.txtCompany.Text = "XYZ";
            this.txtCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(51, 5);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(275, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "License Server Domain Settings";
            // 
            // txtLicenseServer
            // 
            this.txtLicenseServer.Location = new System.Drawing.Point(56, 35);
            this.txtLicenseServer.Margin = new System.Windows.Forms.Padding(5);
            this.txtLicenseServer.Name = "txtLicenseServer";
            this.txtLicenseServer.Size = new System.Drawing.Size(245, 29);
            this.txtLicenseServer.TabIndex = 24;
            this.txtLicenseServer.Text = "http://www.mydomain.com";
            this.txtLicenseServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(122, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(224, 21);
            this.label12.TabIndex = 29;
            this.label12.Text = "Secret Key for License Creation";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 71);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(313, 42);
            this.label13.TabIndex = 28;
            this.label13.Text = " Secret Key for License Veriication Requests \r\n(Embed in Source Code)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKeyLicCreate
            // 
            this.txtKeyLicCreate.Location = new System.Drawing.Point(131, 51);
            this.txtKeyLicCreate.Margin = new System.Windows.Forms.Padding(5);
            this.txtKeyLicCreate.Name = "txtKeyLicCreate";
            this.txtKeyLicCreate.Size = new System.Drawing.Size(215, 29);
            this.txtKeyLicCreate.TabIndex = 27;
            this.txtKeyLicCreate.Text = "5b06a6205a96f4.88239185";
            // 
            // txtKeyQuery
            // 
            this.txtKeyQuery.Location = new System.Drawing.Point(56, 113);
            this.txtKeyQuery.Margin = new System.Windows.Forms.Padding(5);
            this.txtKeyQuery.Name = "txtKeyQuery";
            this.txtKeyQuery.Size = new System.Drawing.Size(247, 29);
            this.txtKeyQuery.TabIndex = 26;
            this.txtKeyQuery.Text = "5b06a6205a97f1.60209273";
            this.txtKeyQuery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 283);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 21);
            this.label14.TabIndex = 31;
            this.label14.Text = "Allowed Installs";
            // 
            // txtAllowedInstalls
            // 
            this.txtAllowedInstalls.Location = new System.Drawing.Point(131, 279);
            this.txtAllowedInstalls.Margin = new System.Windows.Forms.Padding(5);
            this.txtAllowedInstalls.Name = "txtAllowedInstalls";
            this.txtAllowedInstalls.Size = new System.Drawing.Size(215, 29);
            this.txtAllowedInstalls.TabIndex = 30;
            this.txtAllowedInstalls.Text = "1";
            this.txtAllowedInstalls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtProductref);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtAllowedInstalls);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtKeyLicCreate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCompany);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTransId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.btnCreateLicense);
            this.groupBox1.Location = new System.Drawing.Point(361, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 581);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LICENSE CREATE DEBUG : Should be done by Woo Commerce ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(44, 363);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 21);
            this.label17.TabIndex = 35;
            this.label17.Text = "Use Web Store!";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtDomain);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtItem);
            this.groupBox2.Controls.Add(this.txtExpiry);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnActivate);
            this.groupBox2.Location = new System.Drawing.Point(126, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 162);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Activate Install - Enter Details";
            // 
            // txtProductref
            // 
            this.txtProductref.Location = new System.Drawing.Point(131, 317);
            this.txtProductref.Margin = new System.Windows.Forms.Padding(5);
            this.txtProductref.Name = "txtProductref";
            this.txtProductref.Size = new System.Drawing.Size(215, 29);
            this.txtProductref.TabIndex = 32;
            this.txtProductref.Text = "Product Desc";
            this.txtProductref.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 322);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 21);
            this.label16.TabIndex = 33;
            this.label16.Text = "Product Ref";
            // 
            // listActivations
            // 
            this.listActivations.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listActivations.FullRowSelect = true;
            this.listActivations.GridLines = true;
            this.listActivations.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listActivations.LabelWrap = false;
            this.listActivations.Location = new System.Drawing.Point(12, 456);
            this.listActivations.Name = "listActivations";
            this.listActivations.Size = new System.Drawing.Size(343, 113);
            this.listActivations.TabIndex = 32;
            this.listActivations.UseCompatibleStateImageBehavior = false;
            this.listActivations.View = System.Windows.Forms.View.Details;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(11, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 187);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 432);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(191, 21);
            this.label15.TabIndex = 34;
            this.label15.Text = "Activated Domains Report";
            // 
            // frmDiagnostics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 683);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.listActivations);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtKeyQuery);
            this.Controls.Add(this.btnDeactivate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLicenseServer);
            this.Controls.Add(this.btnCheckKey);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMyLicense);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDiagnostics";
            this.Text = "Woo Commerce - Software Manager License Diagnostics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDiagnostics_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateLicense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMyLicense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Button btnCheckKey;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox TxtDomain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTransId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtExpiry;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLicenseServer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKeyLicCreate;
        private System.Windows.Forms.TextBox txtKeyQuery;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAllowedInstalls;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listActivations;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtProductref;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
    }
}


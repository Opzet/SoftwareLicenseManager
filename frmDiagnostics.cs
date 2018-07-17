using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Diagnostics;

namespace License
{
    public partial class frmDiagnostics : Form
    {
        public frmDiagnostics()
        {
            InitializeComponent();
        }

        private void btnCreateLicense_Click(object sender, EventArgs e)
        {
            var retval =  MessageBox.Show("This is a DEBUG order creation\r\n Create order via website in Woo Commerce(use Token 'test' to pay)\r\nUse Website instead of DEBUG", "Order DeBUG or online", MessageBoxButtons.YesNo);

            if(retval == DialogResult.Yes)
            {
                string url = "http://www.mydomain.com/product/install/"; //Link to woocommerce product cart/site, for debug purposes, if you buy from here it creates license and entries.
                try
                {
                    Process.Start(url);
                }
                catch (Win32Exception)
                {
                    Process.Start("IExplore.exe", url);
                }
                return;
            }
            //HTTP POST method.
            LicenseResponse License = new LicenseResponse();
            using (WebClient client = new WebClient())
            {
                var response = client.UploadValues(txtLicenseServer.Text, new NameValueCollection()
                {
                    { "secret_key", txtKeyLicCreate.Text},
                    { "slm_action", "slm_create_new" },

                    { "first_name" , txtFirstName.Text },
                    { "last_name", txtLastName.Text },
                    { "email", txtEmail.Text },
                    { "company_name", txtCompany.Text},
                    { "txn_id", txtTransId.Text},

                    { "max_allowed_domains", "1" },
                   
                    { "date_created", DateTime.Now.ToString("yyyy/MM/dd") },
                    { "date_renewed", (DateTime.Now.AddDays(1)).ToString("yyyy/MM/dd") },  //Dont work
                    { "date_expiry", (DateTime.Now.AddYears(2)).ToString("yyyy/MM/dd") },
                    { "manual_reset_count", "0" },

                    { "registered_domain", TxtDomain.Text },
                    { "product_ref", txtItem.Text}, 

                    { "lic_status", "active" },
                });

                string result = System.Text.Encoding.UTF8.GetString(response);
                License = FromJson<LicenseResponse>(result);

            }

            if (License != null)
            {
                lblResponse.Text = $"Result: {License.result} | Message: {License.message} | Key: {License.key}";
                txtMyLicense.Text = License.key;
            }
            else
            {
                lblResponse.Text = "No Response?";
            }
        }

        private void btnCheckKey_Click(object sender, EventArgs e)
        {
            CheckKey();
        }

        void CheckKey()
        { 
            ClearInfo();

            LicenseResponse License = new LicenseResponse();

            using (WebClient client = new WebClient())
            {
                var response = client.UploadValues(txtLicenseServer.Text, new NameValueCollection()
                {
                    { "secret_key", txtKeyQuery.Text},
                    { "slm_action", "slm_check" },
                    { "license_key" , txtMyLicense.Text }
                });

                string result = System.Text.Encoding.UTF8.GetString(response);
                License = FromJson<LicenseResponse>(result);
            }

            if (License != null)
            {
                lblResponse.Text = $"Result: {License.result} | Message: {License.message} | Key: {License.key}";

                txtFirstName.Text = License.first_name;
                txtLastName.Text = License.last_name;
                txtEmail.Text = License.email;
                txtCompany.Text = License.company_name;
                txtTransId.Text = License.txn_id;
                txtAllowedInstalls.Text = License.max_allowed_domains;

                txtProductref.Text = License.product_ref;

                listActivations.Items.Clear();
                if (License.registered_domains == null)
                    return;

                foreach (RegDomains domain in License.registered_domains)
                {
                    listActivations.Items.Add(new ListViewItem(new string[] {
                        domain.id,
                        domain.registered_domain,
                        domain.item_reference,
                    }));

                    txtItem.Text = domain.item_reference;

                }

                listActivations.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listActivations.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listActivations.Refresh();
            }
            else
            {
                lblResponse.Text = "No Response?";
            }

        }


        public T FromJson<T>(string json)
        {
            if (json == "")
                return default (T); //Nothing at this domain?  Incorrect entry

            try
            {
                var serializer = new DataContractJsonSerializer(typeof(T));
                using (var tempStream = new MemoryStream(Encoding.Unicode.GetBytes(json)))
                {
                    return (T)serializer.ReadObject(tempStream);
                }
            }
            catch
            {
                return default(T); //Nothing at this domain?  Incorrect entry
            }
        }


        /*
            - Create license keys in your system (license server)
            - Check the status of a license key from from your application (remotely)
            - Activate a license key from your application (remotely)
            - Deactivate a license key (remotely)
            - Check a license key (remotely)
            - Track where the license key is being used.
        */
        //http://www.mydomain.com/?secret_key=%275b06a6205a97f1.60209273%27&slm_action=slm_check&license_key=%27123%27
        //http://www.mydomain.com/?secret_key='5b06a6205a97f1.60209273'&slm_action=slm_check&license_key='123'
        //{ "result":"error","message":"Verification API secret key is invalid","error_code":90}
        //{"result":"success","message":"License successfully created","key":"5580effe188d3"}
        public class LicenseResponse
        {
            public string result { get; set; }
            public string message { get; set; }
            public string key { get; set; }
            public string status { get; set; }
            public string max_allowed_domains { get; set; }
            public string email { get; set; }
            public RegDomains[] registered_domains { get; set; }
            public string date_created { get; set; }
            public string date_renewed { get; set; }
            public string date_expiry { get; set; }
            public string product_ref { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string company_name { get; set; }
            public string txn_id { get; set; }

        }

        public class RegDomains
        {
            public string id { get; set; }
            public string lic_key_id { get; set; }
            public string lic_key { get; set; }
            public string registered_domain { get; set; }
           // public string item_reference { get; set; }
            public string item_reference { get; set; }
            
        }


        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (TxtDomain.Text == "")
                TxtDomain.Text = "Domain";

            if(txtItem.Text =="")
            {
                txtItem.Text = "v1.0";
            }
            //Activate 
            LicenseResponse License = new LicenseResponse();
            using (WebClient client = new WebClient())
            {
                var response = client.UploadValues(txtLicenseServer.Text, new NameValueCollection()
                {
                    { "secret_key", txtKeyQuery.Text},
                    { "slm_action", "slm_activate" },

                    { "license_key" , txtMyLicense.Text },
                    { "registered_domain", TxtDomain.Text },
                    { "item_reference",  txtItem.Text}

                });

                string result = System.Text.Encoding.UTF8.GetString(response);
                License = FromJson<LicenseResponse>(result);
            }

            if (License != null)
            {
                lblResponse.Text = $"Result: {License.result} | Message: {License.message} | Key: {License.key}";
               // txtMyLicense.Text = License.key;
            }
            else
            {
                lblResponse.Text = "No Response?";
            }

            if (License.result != "error")
            {
                CheckKey();
            }
        }

        class DomainItem
        {

            public string id { get; set; }
            public string lic_key { get; set; }
            public string registered_domain { get; set; }
            public string product_ref { get; set; }

        }
            
        private void btnDeactivate_Click(object sender, EventArgs e)
        {

            DomainItem domain = new DomainItem();
            if (listActivations.SelectedItems.Count == 0 )
                return;
            domain.id = listActivations.SelectedItems[0].SubItems[0].Text; 
            domain.registered_domain = listActivations.SelectedItems[0].SubItems[1].Text;
            domain.product_ref = listActivations.SelectedItems[0].SubItems[2].Text;


            //MultiSite
            LicenseResponse License = new LicenseResponse();
            using (WebClient client = new WebClient())
            {
                var response = client.UploadValues(txtLicenseServer.Text, new NameValueCollection()
                {
                    { "secret_key", txtKeyQuery.Text},
                    { "slm_action", "slm_deactivate" },

                    { "license_key" , txtMyLicense.Text },
                    { "registered_domain", domain.registered_domain }, //TxtDomain.Text },
                    { "product_ref", domain.product_ref } //txtItem.Text} //item_reference
                });

                string result = System.Text.Encoding.UTF8.GetString(response);
                License = FromJson<LicenseResponse>(result);
            }

            if (License != null)
            {
                lblResponse.Text = $"Result: {License.result} | Message: {License.message} | Key: {License.key}";
               // txtMyLicense.Text = License.key;
            }
            else
            {
                lblResponse.Text = "No Response?";
            }

            CheckKey();
        }

        void ClearInfo()
        {
            txtFirstName.Text = txtLastName.Text = txtEmail.Text = txtCompany.Text = txtTransId.Text = TxtDomain.Text = txtItem.Text = txtExpiry.Text = txtProductref.Text = txtAllowedInstalls.Text = "";
            listActivations.Items.Clear();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtLicenseServer.Text = Properties.Settings.Default.Domain;
            txtKeyQuery.Text = Properties.Settings.Default.secretKeyVerification;
            txtKeyLicCreate.Text = Properties.Settings.Default.secretKeyCreation;

            listActivations.Items.Clear();
            listActivations.View = View.Details;
            listActivations.Columns.Add("id");
            listActivations.Columns.Add("Domain");
            listActivations.Columns.Add("Product");

            listActivations.GridLines = true;
            CheckKey();
        }

        private void frmDiagnostics_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Domain = txtLicenseServer.Text;
            Properties.Settings.Default.secretKeyVerification = txtKeyQuery.Text;
            Properties.Settings.Default.secretKeyCreation = txtKeyLicCreate.Text;

            Properties.Settings.Default.Save();

        }
    }
}

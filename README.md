Want to sell desktop software (e.g. DotNet C# winform) and activate it via a key, this is how I did it.  Port of License Keys API client used to activate, validate and deactivate your license keys from https://github.com/10quality/license-keys-php-client/blob/v1.0/src/Client.php

You can utilise the themes/pluging license architecture, labels are set as 'domain' rather than 'desktop/install' etc but thats just semantics.

There is alot on wordpress themes and plugins licensing to allow code restrictions easily, this is an example of how to do it for a desktop application.


## Infrastructure

### Wordpress

  * Wordpress Plugins
    * woocommerce
    
#### License Auto Generation (License Key)
    * WooCommerce License Keys - Enable and handle "License Keys" with WooCommerce. Version 1.0.11 | By 10 Quality

#### SML (Software licence manager) 
* Woocommerce SML (Software licence manager) Key generator - Auto generate licence keys for WooCommerce orders using the Software licence manager plugin Version 1.0 | By Aaron Bowie (We are AG) 

This is an __updated version of Woocommerce Software License Manager By Omid Shamlu__ to work with the latest WooCommerce (3.0+)
Features

    Automatically creates license keys for each sale with WC
    Licensing is optional and can be activated/deactivated individually
    Send generated license keys to your customers within your existing email notifications


### WooCommerce

 * WooCommerce License Keys
  * Enable and handle "License Keys" with WooCommerce.


 * Woocommerce SML (Software licence manager) Key generator
	 * Auto generate licence keys for WooCommerce orders using the Software licence manager plugin


## Software license Manager Plugin

https://www.tipsandtricks-hq.com/software-license-manager-plugin-for-wordpress


## WebClient to check json query to woocommerce

<pre>
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
	    </pre>
## Other Implementations

### MVC
https://github.com/10quality/wpmvc-addon-license-key


### Reference Links 
[GitHub Flavored Markdown](https://guides.github.com/features/mastering-markdown/).
[Git Hub Pages documentation](https://help.github.com/categories/github-pages-basics/)

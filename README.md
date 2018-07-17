Want to sell desktop software (e.g. DotNet C# winform) and activate it via a key, this is how I did it for free.  

Use Woocommerce to sell license and enable your WordPress setup to act as a validator API (service) with endpoints that will let you activate, validate and deactivate license keys via HTTP requests; this is a C# solutions to integrate the API within your desktop products.

## Reverse Engineer of licensing in Wordpress/WooCommerce

### Required Infrastructure

 1. Store

 2. Enable license key fields in product
 
 3. Software License Management (SLM) and Enable license key auto generation with notification on purchase
 
 4. REST API for desktop application
 
<hr>

#### 1. Store : Wordpress and WooCommerce

Install Wordpress Plugin: 'woocommerce' enables eCommerce Store
    
#### 2. Field: Enable license key fields in product

Install Wordpress Plugin: 'WooCommerce License Keys'  Version 1.0.11 By 10 Quality
Enables "License Keys" with WooCommerce field in products.

#### 3. Manage: Software licence manager dashboard

https://www.tipsandtricks-hq.com/software-license-manager-plugin-for-wordpress

Install Wordpress Plugin: Software License Manager Version 4.0 | By Tips and Tricks HQ - Dashboard

Install Wordpress Plugin: Software licence manager plugin Version 1.0 | By Aaron Bowie (We are AG) - Auto gen license

This is an __updated version of Woocommerce Software License Manager By Omid Shamlu__ to work with the latest WooCommerce (3.0+)
Features

Automatically creates license keys for each sale with WC Licensing is optional and can be activated/deactivated individually send generated license keys to your customers within your existing email notifications

<hr>

### Application code to query store: REST API / WebClient to check json query to woocommerce

Port of License Keys API client used to activate, validate and deactivate license keys from https://github.com/10quality/license-keys-php-client/blob/v1.0/src/Client.php

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
	    
#### Other Implementations

### MVC
https://github.com/10quality/wpmvc-addon-license-key

### It is confusing on how to enable software licensing, it is hidden in the free architecture, cannot work out what to buy...

* $199 - 399  https://woocommerce.com/products/woocommerce-subscriptions/  I think this is closest to the above?

*  $39 https://www.10quality.com/product/woocommerce-license-keys/
*  $129 https://woocommerce.com/products/woocommerce-api-manager/  <- What is this??  Looks promising
*  $129 https://woocommerce.com/products/software-add-on/?utm_source=product&utm_medium=upsell&utm_campaign=wcaddons
WooCommerce License Keys adds a new product type to your WordPress and WooCommerce setup, and lets you create and handle license keys that can be used to validate your licensed products.  

https://www.tipsandtricks-hq.com/ecommerce/integrate-wp-estore-with-software-license-manager-plugin-3731



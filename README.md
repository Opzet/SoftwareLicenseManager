Want to sell desktop software (e.g. DotNet C# winform) and activate it via a key, this is how I did it.

 There is alot on wordpress themes and plugins licensing to allow code restrictions easily, this is an example of how to do it for a desktop application.

## Infrastructure

### Wordpress

  * Wordpress Plugins
    * woocommerce
    * Software License Manager Plugin

### WooCommerce

 * WooCommerce License Keys
  * Enable and handle "License Keys" with WooCommerce.


 * Woocommerce SML (Software licence manager) Key generator
	 * Auto generate licence keys for WooCommerce orders using the Software licence manager plugin


## Software license Manager Plugin

https://www.tipsandtricks-hq.com/software-license-manager-plugin-for-wordpress


## WebClient to check json query to woocommerce

  LicenseResponse License = new LicenseResponse();
<pre>
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
	    </pre>
## Other Implementations

### MVC
https://github.com/10quality/wpmvc-addon-license-key


### Reference Links 
[GitHub Flavored Markdown](https://guides.github.com/features/mastering-markdown/).
[Git Hub Pages documentation](https://help.github.com/categories/github-pages-basics/)

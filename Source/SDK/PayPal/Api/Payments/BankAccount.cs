using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections;
using System.Collections.Generic;
using PayPal.Api.Validation;

namespace PayPal.Api.Payments
{
    public class BankAccount
    {
        /// <summary>
        /// ID of the bank account being saved for later use.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string id { get; set; }

        /// <summary>
        /// Account number in either IBAN (max length 34) or BBAN (max length 17) format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string account_number { get; set; }

        /// <summary>
        /// Type of the bank account number (International or Basic Bank Account Number). For more information refer to http://en.wikipedia.org/wiki/International_Bank_Account_Number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string account_number_type { get; set; }

        /// <summary>
        /// Routing transit number (aka Bank Code) of the bank (typically for domestic use only - for international use, IBAN includes bank code). For more information refer to http://en.wikipedia.org/wiki/Bank_code.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string routing_number { get; set; }

        /// <summary>
        /// Type of the bank account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string account_type { get; set; }

        /// <summary>
        /// A customer designated name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string account_name { get; set; }

        /// <summary>
        /// Type of the check when this information was obtained through a check by the facilitator or merchant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string check_type { get; set; }

        /// <summary>
        /// How the check was obtained from the customer, if check was the source of the information provided.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string auth_type { get; set; }

        /// <summary>
        /// Time at which the authorization (or check) was captured. Use this field if the user authorization needs to be captured due to any privacy requirements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string auth_capture_timestamp { get; set; }

        /// <summary>
        /// Name of the bank.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string bank_name { get; set; }

        /// <summary>
        /// 2 letter country code of the Bank.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string country_code { get; set; }

        /// <summary>
        /// Account holder's first name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string first_name { get; set; }

        /// <summary>
        /// Account holder's last name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string last_name { get; set; }

        /// <summary>
        /// Birth date of the bank account holder.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string birth_date { get; set; }

        /// <summary>
        /// Billing address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Address billing_address { get; set; }

        /// <summary>
        /// State of this funding instrument.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string state { get; set; }

        /// <summary>
        /// Confirmation status of a bank account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string confirmation_status { get; set; }

        /// <summary>
        /// Deprecated - Use external_customer_id instead.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string payer_id { get; set; }

        /// <summary>
        /// A unique identifier of the customer to whom this bank account belongs to. Generated and provided by the facilitator. This is required when creating or using a stored funding instrument in vault.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string external_customer_id { get; set; }

        /// <summary>
        /// A unique identifier of the merchant for which this bank account has been stored for. Generated and provided by the facilitator so it can be used to restrict the usage of the bank account to the specific merchnt.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string merchant_id { get; set; }

        /// <summary>
        /// Time the resource was created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string create_time { get; set; }

        /// <summary>
        /// Time the resource was last updated.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string update_time { get; set; }

        /// <summary>
        /// Date/Time until this resource can be used to fund a payment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string valid_until { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Links> links { get; set; }

        /// <summary>
        /// Converts the object to JSON string
        /// </summary>
        public virtual string ConvertToJson()
        {
            return JsonFormatter.ConvertToJson(this);
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security.Models
{
    using System.Linq;

    /// <summary>
    /// Describes security contact properties
    /// </summary>
    public partial class SecurityContactProperties
    {
        /// <summary>
        /// Initializes a new instance of the SecurityContactProperties class.
        /// </summary>
        public SecurityContactProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecurityContactProperties class.
        /// </summary>

        /// <param name="emails">List of email addresses which will get notifications from Microsoft
        /// Defender for Cloud by the configurations defined in this security contact.
        /// </param>

        /// <param name="phone">The security contact&#39;s phone number
        /// </param>

        /// <param name="alertNotifications">Defines whether to send email notifications about new security alerts
        /// </param>

        /// <param name="notificationsByRole">Defines whether to send email notifications from Microsoft Defender for
        /// Cloud to persons with specific RBAC roles on the subscription.
        /// </param>
        public SecurityContactProperties(string emails = default(string), string phone = default(string), SecurityContactPropertiesAlertNotifications alertNotifications = default(SecurityContactPropertiesAlertNotifications), SecurityContactPropertiesNotificationsByRole notificationsByRole = default(SecurityContactPropertiesNotificationsByRole))

        {
            this.Emails = emails;
            this.Phone = phone;
            this.AlertNotifications = alertNotifications;
            this.NotificationsByRole = notificationsByRole;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets list of email addresses which will get notifications from
        /// Microsoft Defender for Cloud by the configurations defined in this security
        /// contact.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "emails")]
        public string Emails {get; set; }

        /// <summary>
        /// Gets or sets the security contact&#39;s phone number
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "phone")]
        public string Phone {get; set; }

        /// <summary>
        /// Gets or sets defines whether to send email notifications about new security
        /// alerts
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "alertNotifications")]
        public SecurityContactPropertiesAlertNotifications AlertNotifications {get; set; }

        /// <summary>
        /// Gets or sets defines whether to send email notifications from Microsoft
        /// Defender for Cloud to persons with specific RBAC roles on the subscription.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "notificationsByRole")]
        public SecurityContactPropertiesNotificationsByRole NotificationsByRole {get; set; }
    }
}
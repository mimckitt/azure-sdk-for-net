// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Oracle Service Cloud linked service. </summary>
    public partial class OracleServiceCloudLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of OracleServiceCloudLinkedService. </summary>
        /// <param name="host"> The URL of the Oracle Service Cloud instance. </param>
        /// <param name="username"> The user name that you use to access Oracle Service Cloud server. </param>
        /// <param name="password"> The password corresponding to the user name that you provided in the username key. </param>
        public OracleServiceCloudLinkedService(object host, object username, SecretBase password)
        {
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }
            if (username == null)
            {
                throw new ArgumentNullException(nameof(username));
            }
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            Host = host;
            Username = username;
            Password = password;
            Type = "OracleServiceCloud";
        }

        /// <summary> Initializes a new instance of OracleServiceCloudLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="host"> The URL of the Oracle Service Cloud instance. </param>
        /// <param name="username"> The user name that you use to access Oracle Service Cloud server. </param>
        /// <param name="password"> The password corresponding to the user name that you provided in the username key. </param>
        /// <param name="useEncryptedEndpoints"> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="useHostVerification"> Specifies whether to require the host name in the server&apos;s certificate to match the host name of the server when connecting over SSL. The default value is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="usePeerVerification"> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal OracleServiceCloudLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object host, object username, SecretBase password, object useEncryptedEndpoints, object useHostVerification, object usePeerVerification, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            Host = host;
            Username = username;
            Password = password;
            UseEncryptedEndpoints = useEncryptedEndpoints;
            UseHostVerification = useHostVerification;
            UsePeerVerification = usePeerVerification;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "OracleServiceCloud";
        }

        /// <summary> The URL of the Oracle Service Cloud instance. </summary>
        public object Host { get; set; }
        /// <summary> The user name that you use to access Oracle Service Cloud server. </summary>
        public object Username { get; set; }
        /// <summary> The password corresponding to the user name that you provided in the username key. </summary>
        public SecretBase Password { get; set; }
        /// <summary> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public object UseEncryptedEndpoints { get; set; }
        /// <summary> Specifies whether to require the host name in the server&apos;s certificate to match the host name of the server when connecting over SSL. The default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public object UseHostVerification { get; set; }
        /// <summary> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public object UsePeerVerification { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}

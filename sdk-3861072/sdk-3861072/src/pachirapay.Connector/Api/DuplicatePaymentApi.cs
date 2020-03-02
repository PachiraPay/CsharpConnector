/* 
 * Payment Gateway
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using pachirapay.Connector.Client;
using pachirapay.Connector.Model;

namespace pachirapay.Connector.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDuplicatePaymentApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Duplicate payment batch
        /// </summary>
        /// <remarks>
        /// Achieve a batch of payments by copy of previously processed payments, with the same payment method.
        /// </remarks>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="duplicatePaymentBatchRequest">All data needed to make process the payment, with the reference to the previously payment. (optional)</param>
        /// <returns>CardPaymentResponse</returns>
        CardPaymentResponse V1PaymentsDuplicatePaymentBatchPost (string authToken, DuplicatePaymentBatchRequest duplicatePaymentBatchRequest = null);

        /// <summary>
        /// Duplicate payment batch
        /// </summary>
        /// <remarks>
        /// Achieve a batch of payments by copy of previously processed payments, with the same payment method.
        /// </remarks>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="duplicatePaymentBatchRequest">All data needed to make process the payment, with the reference to the previously payment. (optional)</param>
        /// <returns>ApiResponse of CardPaymentResponse</returns>
        ApiResponse<CardPaymentResponse> V1PaymentsDuplicatePaymentBatchPostWithHttpInfo (string authToken, DuplicatePaymentBatchRequest duplicatePaymentBatchRequest = null);
        /// <summary>
        /// Duplicate payment
        /// </summary>
        /// <remarks>
        /// Achieve a payment by copy of a previously processed payment, with the same payment method.
        /// </remarks>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="duplicatePaymentRequest">All data needed to make process the payment, with the reference to the previously payment. (optional)</param>
        /// <returns>CardPaymentResponse</returns>
        CardPaymentResponse V1PaymentsDuplicatePaymentPost (string authToken, DuplicatePaymentRequest duplicatePaymentRequest = null);

        /// <summary>
        /// Duplicate payment
        /// </summary>
        /// <remarks>
        /// Achieve a payment by copy of a previously processed payment, with the same payment method.
        /// </remarks>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="duplicatePaymentRequest">All data needed to make process the payment, with the reference to the previously payment. (optional)</param>
        /// <returns>ApiResponse of CardPaymentResponse</returns>
        ApiResponse<CardPaymentResponse> V1PaymentsDuplicatePaymentPostWithHttpInfo (string authToken, DuplicatePaymentRequest duplicatePaymentRequest = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Duplicate payment batch
        /// </summary>
        /// <remarks>
        /// Achieve a batch of payments by copy of previously processed payments, with the same payment method.
        /// </remarks>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="duplicatePaymentBatchRequest">All data needed to make process the payment, with the reference to the previously payment. (optional)</param>
        /// <returns>Task of CardPaymentResponse</returns>
        System.Threading.Tasks.Task<CardPaymentResponse> V1PaymentsDuplicatePaymentBatchPostAsync (string authToken, DuplicatePaymentBatchRequest duplicatePaymentBatchRequest = null);

        /// <summary>
        /// Duplicate payment batch
        /// </summary>
        /// <remarks>
        /// Achieve a batch of payments by copy of previously processed payments, with the same payment method.
        /// </remarks>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="duplicatePaymentBatchRequest">All data needed to make process the payment, with the reference to the previously payment. (optional)</param>
        /// <returns>Task of ApiResponse (CardPaymentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CardPaymentResponse>> V1PaymentsDuplicatePaymentBatchPostAsyncWithHttpInfo (string authToken, DuplicatePaymentBatchRequest duplicatePaymentBatchRequest = null);
        /// <summary>
        /// Duplicate payment
        /// </summary>
        /// <remarks>
        /// Achieve a payment by copy of a previously processed payment, with the same payment method.
        /// </remarks>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="duplicatePaymentRequest">All data needed to make process the payment, with the reference to the previously payment. (optional)</param>
        /// <returns>Task of CardPaymentResponse</returns>
        System.Threading.Tasks.Task<CardPaymentResponse> V1PaymentsDuplicatePaymentPostAsync (string authToken, DuplicatePaymentRequest duplicatePaymentRequest = null);

        /// <summary>
        /// Duplicate payment
        /// </summary>
        /// <remarks>
        /// Achieve a payment by copy of a previously processed payment, with the same payment method.
        /// </remarks>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="duplicatePaymentRequest">All data needed to make process the payment, with the reference to the previously payment. (optional)</param>
        /// <returns>Task of ApiResponse (CardPaymentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CardPaymentResponse>> V1PaymentsDuplicatePaymentPostAsyncWithHttpInfo (string authToken, DuplicatePaymentRequest duplicatePaymentRequest = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DuplicatePaymentApi : IDuplicatePaymentApi
    {
        private pachirapay.Connector.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicatePaymentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DuplicatePaymentApi(String basePath)
        {
            this.Configuration = new pachirapay.Connector.Client.Configuration { BasePath = basePath };

            ExceptionFactory = pachirapay.Connector.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicatePaymentApi"/> class
        /// </summary>
        /// <returns></returns>
        public DuplicatePaymentApi()
        {
            this.Configuration = pachirapay.Connector.Client.Configuration.Default;

            ExceptionFactory = pachirapay.Connector.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicatePaymentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DuplicatePaymentApi(pachirapay.Connector.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = pachirapay.Connector.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = pachirapay.Connector.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public pachirapay.Connector.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public pachirapay.Connector.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Duplicate payment batch Achieve a batch of payments by copy of previously processed payments, with the same payment method.
        /// </summary>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="duplicatePaymentBatchRequest">All data needed to make process the payment, with the reference to the previously payment. (optional)</param>
        /// <returns>CardPaymentResponse</returns>
        public CardPaymentResponse V1PaymentsDuplicatePaymentBatchPost (string authToken, DuplicatePaymentBatchRequest duplicatePaymentBatchRequest = null)
        {
             ApiResponse<CardPaymentResponse> localVarResponse = V1PaymentsDuplicatePaymentBatchPostWithHttpInfo(authToken, duplicatePaymentBatchRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Duplicate payment batch Achieve a batch of payments by copy of previously processed payments, with the same payment method.
        /// </summary>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="duplicatePaymentBatchRequest">All data needed to make process the payment, with the reference to the previously payment. (optional)</param>
        /// <returns>ApiResponse of CardPaymentResponse</returns>
        public ApiResponse< CardPaymentResponse > V1PaymentsDuplicatePaymentBatchPostWithHttpInfo (string authToken, DuplicatePaymentBatchRequest duplicatePaymentBatchRequest = null)
        {
            // verify the required parameter 'authToken' is set
            if (authToken == null)
                throw new ApiException(400, "Missing required parameter 'authToken' when calling DuplicatePaymentApi->V1PaymentsDuplicatePaymentBatchPost");

            var localVarPath = "./v1/payments/duplicate-payment/batch";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authToken != null) localVarHeaderParams.Add("authToken", this.Configuration.ApiClient.ParameterToString(authToken)); // header parameter
            if (duplicatePaymentBatchRequest != null && duplicatePaymentBatchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(duplicatePaymentBatchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = duplicatePaymentBatchRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1PaymentsDuplicatePaymentBatchPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CardPaymentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (CardPaymentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CardPaymentResponse)));
        }

        /// <summary>
        /// Duplicate payment batch Achieve a batch of payments by copy of previously processed payments, with the same payment method.
        /// </summary>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="duplicatePaymentBatchRequest">All data needed to make process the payment, with the reference to the previously payment. (optional)</param>
        /// <returns>Task of CardPaymentResponse</returns>
        public async System.Threading.Tasks.Task<CardPaymentResponse> V1PaymentsDuplicatePaymentBatchPostAsync (string authToken, DuplicatePaymentBatchRequest duplicatePaymentBatchRequest = null)
        {
             ApiResponse<CardPaymentResponse> localVarResponse = await V1PaymentsDuplicatePaymentBatchPostAsyncWithHttpInfo(authToken, duplicatePaymentBatchRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Duplicate payment batch Achieve a batch of payments by copy of previously processed payments, with the same payment method.
        /// </summary>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="duplicatePaymentBatchRequest">All data needed to make process the payment, with the reference to the previously payment. (optional)</param>
        /// <returns>Task of ApiResponse (CardPaymentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CardPaymentResponse>> V1PaymentsDuplicatePaymentBatchPostAsyncWithHttpInfo (string authToken, DuplicatePaymentBatchRequest duplicatePaymentBatchRequest = null)
        {
            // verify the required parameter 'authToken' is set
            if (authToken == null)
                throw new ApiException(400, "Missing required parameter 'authToken' when calling DuplicatePaymentApi->V1PaymentsDuplicatePaymentBatchPost");

            var localVarPath = "./v1/payments/duplicate-payment/batch";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authToken != null) localVarHeaderParams.Add("authToken", this.Configuration.ApiClient.ParameterToString(authToken)); // header parameter
            if (duplicatePaymentBatchRequest != null && duplicatePaymentBatchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(duplicatePaymentBatchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = duplicatePaymentBatchRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1PaymentsDuplicatePaymentBatchPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CardPaymentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (CardPaymentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CardPaymentResponse)));
        }

        /// <summary>
        /// Duplicate payment Achieve a payment by copy of a previously processed payment, with the same payment method.
        /// </summary>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="duplicatePaymentRequest">All data needed to make process the payment, with the reference to the previously payment. (optional)</param>
        /// <returns>CardPaymentResponse</returns>
        public CardPaymentResponse V1PaymentsDuplicatePaymentPost (string authToken, DuplicatePaymentRequest duplicatePaymentRequest = null)
        {
             ApiResponse<CardPaymentResponse> localVarResponse = V1PaymentsDuplicatePaymentPostWithHttpInfo(authToken, duplicatePaymentRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Duplicate payment Achieve a payment by copy of a previously processed payment, with the same payment method.
        /// </summary>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="duplicatePaymentRequest">All data needed to make process the payment, with the reference to the previously payment. (optional)</param>
        /// <returns>ApiResponse of CardPaymentResponse</returns>
        public ApiResponse< CardPaymentResponse > V1PaymentsDuplicatePaymentPostWithHttpInfo (string authToken, DuplicatePaymentRequest duplicatePaymentRequest = null)
        {
            // verify the required parameter 'authToken' is set
            if (authToken == null)
                throw new ApiException(400, "Missing required parameter 'authToken' when calling DuplicatePaymentApi->V1PaymentsDuplicatePaymentPost");

            var localVarPath = "./v1/payments/duplicate-payment";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authToken != null) localVarHeaderParams.Add("authToken", this.Configuration.ApiClient.ParameterToString(authToken)); // header parameter
            if (duplicatePaymentRequest != null && duplicatePaymentRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(duplicatePaymentRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = duplicatePaymentRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1PaymentsDuplicatePaymentPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CardPaymentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (CardPaymentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CardPaymentResponse)));
        }

        /// <summary>
        /// Duplicate payment Achieve a payment by copy of a previously processed payment, with the same payment method.
        /// </summary>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="duplicatePaymentRequest">All data needed to make process the payment, with the reference to the previously payment. (optional)</param>
        /// <returns>Task of CardPaymentResponse</returns>
        public async System.Threading.Tasks.Task<CardPaymentResponse> V1PaymentsDuplicatePaymentPostAsync (string authToken, DuplicatePaymentRequest duplicatePaymentRequest = null)
        {
             ApiResponse<CardPaymentResponse> localVarResponse = await V1PaymentsDuplicatePaymentPostAsyncWithHttpInfo(authToken, duplicatePaymentRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Duplicate payment Achieve a payment by copy of a previously processed payment, with the same payment method.
        /// </summary>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="duplicatePaymentRequest">All data needed to make process the payment, with the reference to the previously payment. (optional)</param>
        /// <returns>Task of ApiResponse (CardPaymentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CardPaymentResponse>> V1PaymentsDuplicatePaymentPostAsyncWithHttpInfo (string authToken, DuplicatePaymentRequest duplicatePaymentRequest = null)
        {
            // verify the required parameter 'authToken' is set
            if (authToken == null)
                throw new ApiException(400, "Missing required parameter 'authToken' when calling DuplicatePaymentApi->V1PaymentsDuplicatePaymentPost");

            var localVarPath = "./v1/payments/duplicate-payment";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authToken != null) localVarHeaderParams.Add("authToken", this.Configuration.ApiClient.ParameterToString(authToken)); // header parameter
            if (duplicatePaymentRequest != null && duplicatePaymentRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(duplicatePaymentRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = duplicatePaymentRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1PaymentsDuplicatePaymentPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CardPaymentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (CardPaymentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CardPaymentResponse)));
        }

    }
}

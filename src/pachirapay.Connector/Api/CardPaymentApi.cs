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
    public interface ICardPaymentApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Authorization / payment
        /// </summary>
        /// <remarks>
        /// Achieve a payment with a card without 3DSecure.  To achieve a 3DS payment (CheckEnrollment), see the /payment/card3ds-payment resource.
        /// </remarks>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="cardPaymentRequest">All data needed to make card payment (optional)</param>
        /// <returns>CardPaymentResponse</returns>
        CardPaymentResponse V1PaymentsCardPaymentPost (string authToken, CardPaymentRequest cardPaymentRequest = null);

        /// <summary>
        /// Authorization / payment
        /// </summary>
        /// <remarks>
        /// Achieve a payment with a card without 3DSecure.  To achieve a 3DS payment (CheckEnrollment), see the /payment/card3ds-payment resource.
        /// </remarks>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="cardPaymentRequest">All data needed to make card payment (optional)</param>
        /// <returns>ApiResponse of CardPaymentResponse</returns>
        ApiResponse<CardPaymentResponse> V1PaymentsCardPaymentPostWithHttpInfo (string authToken, CardPaymentRequest cardPaymentRequest = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Authorization / payment
        /// </summary>
        /// <remarks>
        /// Achieve a payment with a card without 3DSecure.  To achieve a 3DS payment (CheckEnrollment), see the /payment/card3ds-payment resource.
        /// </remarks>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="cardPaymentRequest">All data needed to make card payment (optional)</param>
        /// <returns>Task of CardPaymentResponse</returns>
        System.Threading.Tasks.Task<CardPaymentResponse> V1PaymentsCardPaymentPostAsync (string authToken, CardPaymentRequest cardPaymentRequest = null);

        /// <summary>
        /// Authorization / payment
        /// </summary>
        /// <remarks>
        /// Achieve a payment with a card without 3DSecure.  To achieve a 3DS payment (CheckEnrollment), see the /payment/card3ds-payment resource.
        /// </remarks>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="cardPaymentRequest">All data needed to make card payment (optional)</param>
        /// <returns>Task of ApiResponse (CardPaymentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CardPaymentResponse>> V1PaymentsCardPaymentPostAsyncWithHttpInfo (string authToken, CardPaymentRequest cardPaymentRequest = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CardPaymentApi : ICardPaymentApi
    {
        private pachirapay.Connector.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CardPaymentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CardPaymentApi(String basePath)
        {
            this.Configuration = new pachirapay.Connector.Client.Configuration { BasePath = basePath };

            ExceptionFactory = pachirapay.Connector.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardPaymentApi"/> class
        /// </summary>
        /// <returns></returns>
        public CardPaymentApi()
        {
            this.Configuration = pachirapay.Connector.Client.Configuration.Default;

            ExceptionFactory = pachirapay.Connector.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardPaymentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CardPaymentApi(pachirapay.Connector.Client.Configuration configuration = null)
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
        /// Authorization / payment Achieve a payment with a card without 3DSecure.  To achieve a 3DS payment (CheckEnrollment), see the /payment/card3ds-payment resource.
        /// </summary>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="cardPaymentRequest">All data needed to make card payment (optional)</param>
        /// <returns>CardPaymentResponse</returns>
        public CardPaymentResponse V1PaymentsCardPaymentPost (string authToken, CardPaymentRequest cardPaymentRequest = null)
        {
             ApiResponse<CardPaymentResponse> localVarResponse = V1PaymentsCardPaymentPostWithHttpInfo(authToken, cardPaymentRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Authorization / payment Achieve a payment with a card without 3DSecure.  To achieve a 3DS payment (CheckEnrollment), see the /payment/card3ds-payment resource.
        /// </summary>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="cardPaymentRequest">All data needed to make card payment (optional)</param>
        /// <returns>ApiResponse of CardPaymentResponse</returns>
        public ApiResponse< CardPaymentResponse > V1PaymentsCardPaymentPostWithHttpInfo (string authToken, CardPaymentRequest cardPaymentRequest = null)
        {
            // verify the required parameter 'authToken' is set
            if (authToken == null)
                throw new ApiException(400, "Missing required parameter 'authToken' when calling CardPaymentApi->V1PaymentsCardPaymentPost");

            var localVarPath = "./v1/payments/card-payment";
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
            if (cardPaymentRequest != null && cardPaymentRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(cardPaymentRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cardPaymentRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1PaymentsCardPaymentPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CardPaymentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (CardPaymentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CardPaymentResponse)));
        }

        /// <summary>
        /// Authorization / payment Achieve a payment with a card without 3DSecure.  To achieve a 3DS payment (CheckEnrollment), see the /payment/card3ds-payment resource.
        /// </summary>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="cardPaymentRequest">All data needed to make card payment (optional)</param>
        /// <returns>Task of CardPaymentResponse</returns>
        public async System.Threading.Tasks.Task<CardPaymentResponse> V1PaymentsCardPaymentPostAsync (string authToken, CardPaymentRequest cardPaymentRequest = null)
        {
             ApiResponse<CardPaymentResponse> localVarResponse = await V1PaymentsCardPaymentPostAsyncWithHttpInfo(authToken, cardPaymentRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Authorization / payment Achieve a payment with a card without 3DSecure.  To achieve a 3DS payment (CheckEnrollment), see the /payment/card3ds-payment resource.
        /// </summary>
        /// <exception cref="pachirapay.Connector.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">Gets or sets the authentication token.</param>
        /// <param name="cardPaymentRequest">All data needed to make card payment (optional)</param>
        /// <returns>Task of ApiResponse (CardPaymentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CardPaymentResponse>> V1PaymentsCardPaymentPostAsyncWithHttpInfo (string authToken, CardPaymentRequest cardPaymentRequest = null)
        {
            // verify the required parameter 'authToken' is set
            if (authToken == null)
                throw new ApiException(400, "Missing required parameter 'authToken' when calling CardPaymentApi->V1PaymentsCardPaymentPost");

            var localVarPath = "./v1/payments/card-payment";
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
            if (cardPaymentRequest != null && cardPaymentRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(cardPaymentRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cardPaymentRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1PaymentsCardPaymentPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CardPaymentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (CardPaymentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CardPaymentResponse)));
        }

    }
}

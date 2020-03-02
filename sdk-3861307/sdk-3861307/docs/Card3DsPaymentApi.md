# pachirapay.Connector.Api.Card3DsPaymentApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1PaymentsCard3dsPaymentAuthenticationPost**](Card3DsPaymentApi.md#v1paymentscard3dspaymentauthenticationpost) | **POST** /v1/payments/card3ds-payment/authentication | Validate authentication.
[**V1PaymentsCard3dsPaymentPost**](Card3DsPaymentApi.md#v1paymentscard3dspaymentpost) | **POST** /v1/payments/card3ds-payment | Check enrollment
[**V1PaymentsCard3dsPaymentPut**](Card3DsPaymentApi.md#v1paymentscard3dspaymentput) | **PUT** /v1/payments/card3ds-payment | Validate authentication AND authorize / payment
[**V1PaymentsCard3dsPaymentWithAuthenticationDataPost**](Card3DsPaymentApi.md#v1paymentscard3dspaymentwithauthenticationdatapost) | **POST** /v1/payments/card3ds-payment/with-authentication-data | Authorization / payment -with- authentication data



## V1PaymentsCard3dsPaymentAuthenticationPost

> Card3DsValidateAuthenticationResponse V1PaymentsCard3dsPaymentAuthenticationPost (string authToken, Card3DsValidateAuthenticationRequest card3DsValidateAuthenticationRequest = null)

Validate authentication.

To process a payment authorization linked to this authentication, you should pass all authentication data.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pachirapay.Connector.Api;
using pachirapay.Connector.Client;
using pachirapay.Connector.Model;

namespace Example
{
    public class V1PaymentsCard3dsPaymentAuthenticationPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new Card3DsPaymentApi(Configuration.Default);
            var authToken = authToken_example;  // string | Gets or sets the authentication token.
            var card3DsValidateAuthenticationRequest = new Card3DsValidateAuthenticationRequest(); // Card3DsValidateAuthenticationRequest | The validate authentication request. (optional) 

            try
            {
                // Validate authentication.
                Card3DsValidateAuthenticationResponse result = apiInstance.V1PaymentsCard3dsPaymentAuthenticationPost(authToken, card3DsValidateAuthenticationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling Card3DsPaymentApi.V1PaymentsCard3dsPaymentAuthenticationPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authToken** | **string**| Gets or sets the authentication token. | 
 **card3DsValidateAuthenticationRequest** | [**Card3DsValidateAuthenticationRequest**](Card3DsValidateAuthenticationRequest.md)| The validate authentication request. | [optional] 

### Return type

[**Card3DsValidateAuthenticationResponse**](Card3DsValidateAuthenticationResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## V1PaymentsCard3dsPaymentPost

> Card3DsCheckEnrollmentResponse V1PaymentsCard3dsPaymentPost (string authToken, Card3DsCheckEnrollmentRequest card3DsCheckEnrollmentRequest = null)

Check enrollment

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pachirapay.Connector.Api;
using pachirapay.Connector.Client;
using pachirapay.Connector.Model;

namespace Example
{
    public class V1PaymentsCard3dsPaymentPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new Card3DsPaymentApi(Configuration.Default);
            var authToken = authToken_example;  // string | Gets or sets the authentication token.
            var card3DsCheckEnrollmentRequest = new Card3DsCheckEnrollmentRequest(); // Card3DsCheckEnrollmentRequest | All data needed to make a 3DS card payment (optional) 

            try
            {
                // Check enrollment
                Card3DsCheckEnrollmentResponse result = apiInstance.V1PaymentsCard3dsPaymentPost(authToken, card3DsCheckEnrollmentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling Card3DsPaymentApi.V1PaymentsCard3dsPaymentPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authToken** | **string**| Gets or sets the authentication token. | 
 **card3DsCheckEnrollmentRequest** | [**Card3DsCheckEnrollmentRequest**](Card3DsCheckEnrollmentRequest.md)| All data needed to make a 3DS card payment | [optional] 

### Return type

[**Card3DsCheckEnrollmentResponse**](Card3DsCheckEnrollmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## V1PaymentsCard3dsPaymentPut

> CardPaymentResponse V1PaymentsCard3dsPaymentPut (string authToken, Card3DsValidateAuthenticationAndAuthorizeRequest card3DsValidateAndAuthorizeRequest = null)

Validate authentication AND authorize / payment

The payment3DSecure is done in three steps.    <para>  **Step 1**  Using the POST Method available, you can check the enrollment of the card that will be used.  Remember to take note of the merchantId, merchantSiteId and orderRef you are sending, as well as the paymentRequestId you receive. You will need them again in step 3.  Also please take note of the parameter values you receive in the response, as you will need them in step 2.  </para><para>  **Step 2**  Then, you need to create and send a form for the user to validate the 3DS part of the card validation. We have provided you an example for the form (see below).  Simply replace the placeholder values for the parameters you received.    <pre> &lt;html lang=\"en\"&gt; &lt;body&gt; &lt;form id = \"formulaire\" method=\"post\" action=\"https://fakeRoute.payment3DS.com\"&gt; &lt;input type = \"hidden\" id=\"param1\" name=\"param1\" value=\"value1\"/&gt; &lt;input type = \"hidden\" id=\"param2\" name=\"param2\" value=\"value2\"/&gt; &lt;input type = \"hidden\" id=\"param3\" name=\"param3\" value=\"value3\"/&gt; &lt;input type = \"hidden\" id=\"param4\" name=\"param4\" value=\"value4\"/&gt; &lt;/form&gt; &lt;script&gt; &lt;document.forms[0].submit(); &lt;/script&gt; &lt;/body&gt; &lt;/html&gt; </pre></para><para>  **Step 3**  Finally, you can proceed with this PUT method to finish the payment.  Replace the placeholder values of the merchantId, merchantSiteId and orderRef with the values you sent in the POST method, and the paymentRequestId with the value you received from said POST method.  </para>

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pachirapay.Connector.Api;
using pachirapay.Connector.Client;
using pachirapay.Connector.Model;

namespace Example
{
    public class V1PaymentsCard3dsPaymentPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new Card3DsPaymentApi(Configuration.Default);
            var authToken = authToken_example;  // string | Gets or sets the authentication token.
            var card3DsValidateAndAuthorizeRequest = new Card3DsValidateAuthenticationAndAuthorizeRequest(); // Card3DsValidateAuthenticationAndAuthorizeRequest | The card payment put request. (optional) 

            try
            {
                // Validate authentication AND authorize / payment
                CardPaymentResponse result = apiInstance.V1PaymentsCard3dsPaymentPut(authToken, card3DsValidateAndAuthorizeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling Card3DsPaymentApi.V1PaymentsCard3dsPaymentPut: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authToken** | **string**| Gets or sets the authentication token. | 
 **card3DsValidateAndAuthorizeRequest** | [**Card3DsValidateAuthenticationAndAuthorizeRequest**](Card3DsValidateAuthenticationAndAuthorizeRequest.md)| The card payment put request. | [optional] 

### Return type

[**CardPaymentResponse**](CardPaymentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## V1PaymentsCard3dsPaymentWithAuthenticationDataPost

> CardPaymentResponse V1PaymentsCard3dsPaymentWithAuthenticationDataPost (string authToken, Card3DsAuthorizeWithAuthDataRequest card3DsAuthorizeWithAuthDataRequest = null)

Authorization / payment -with- authentication data

To reuse the previously stored authenticationData in order to trigger a 3DS authorization, you must call the dedicated Authorize with authentication-data API, and pass all authentication data.    For this first version of the API, you must pass the same orderRef and orderTag as the authentication. In future versions, the authorization will be completely decorrelated of the authentication.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pachirapay.Connector.Api;
using pachirapay.Connector.Client;
using pachirapay.Connector.Model;

namespace Example
{
    public class V1PaymentsCard3dsPaymentWithAuthenticationDataPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new Card3DsPaymentApi(Configuration.Default);
            var authToken = authToken_example;  // string | Gets or sets the authentication token.
            var card3DsAuthorizeWithAuthDataRequest = new Card3DsAuthorizeWithAuthDataRequest(); // Card3DsAuthorizeWithAuthDataRequest | The authorize with authentication data request. (optional) 

            try
            {
                // Authorization / payment -with- authentication data
                CardPaymentResponse result = apiInstance.V1PaymentsCard3dsPaymentWithAuthenticationDataPost(authToken, card3DsAuthorizeWithAuthDataRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling Card3DsPaymentApi.V1PaymentsCard3dsPaymentWithAuthenticationDataPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authToken** | **string**| Gets or sets the authentication token. | 
 **card3DsAuthorizeWithAuthDataRequest** | [**Card3DsAuthorizeWithAuthDataRequest**](Card3DsAuthorizeWithAuthDataRequest.md)| The authorize with authentication data request. | [optional] 

### Return type

[**CardPaymentResponse**](CardPaymentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


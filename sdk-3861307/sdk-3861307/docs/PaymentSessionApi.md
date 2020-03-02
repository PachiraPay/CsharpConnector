# pachirapay.Connector.Api.PaymentSessionApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1PaymentSessionsByPaymentSessionIdPaymentResultGet**](PaymentSessionApi.md#v1paymentsessionsbypaymentsessionidpaymentresultget) | **GET** /v1/payment-sessions/{paymentSessionId}/paymentResult | Gets the payment result from its session id.
[**V1PaymentSessionsPost**](PaymentSessionApi.md#v1paymentsessionspost) | **POST** /v1/payment-sessions | Creates a payment session.



## V1PaymentSessionsByPaymentSessionIdPaymentResultGet

> GetPaymentSessionResult V1PaymentSessionsByPaymentSessionIdPaymentResultGet (Guid? paymentSessionId, string authToken)

Gets the payment result from its session id.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pachirapay.Connector.Api;
using pachirapay.Connector.Client;
using pachirapay.Connector.Model;

namespace Example
{
    public class V1PaymentSessionsByPaymentSessionIdPaymentResultGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new PaymentSessionApi(Configuration.Default);
            var paymentSessionId = new Guid?(); // Guid? | The payment session id.
            var authToken = authToken_example;  // string | Gets or sets the authentication token.

            try
            {
                // Gets the payment result from its session id.
                GetPaymentSessionResult result = apiInstance.V1PaymentSessionsByPaymentSessionIdPaymentResultGet(paymentSessionId, authToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentSessionApi.V1PaymentSessionsByPaymentSessionIdPaymentResultGet: " + e.Message );
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
 **paymentSessionId** | [**Guid?**](Guid?.md)| The payment session id. | 
 **authToken** | **string**| Gets or sets the authentication token. | 

### Return type

[**GetPaymentSessionResult**](GetPaymentSessionResult.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
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


## V1PaymentSessionsPost

> PaymentSessionResponse V1PaymentSessionsPost (string authToken, PaymentSessionRequest paymentSessionRequest = null)

Creates a payment session.

Initializes a hosted form payment session with all the necessary data (order information, customer information, payment method...).  This API route can be used for classic hosted form. In that case, this operation is an alternative to the \"client redirection POST\" method (with HMAC).  It's also the standard way for initializing a payment session for \"iframe integration\".            You will get an URL pointing to a paymentform, so that the customer is able to complete the payment form with his card details.  You will also get a PaymentSessionId, useful for calling the GetPaymentResult API when the payment is completed.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pachirapay.Connector.Api;
using pachirapay.Connector.Client;
using pachirapay.Connector.Model;

namespace Example
{
    public class V1PaymentSessionsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new PaymentSessionApi(Configuration.Default);
            var authToken = authToken_example;  // string | Gets or sets the authentication token.
            var paymentSessionRequest = new PaymentSessionRequest(); // PaymentSessionRequest | The payment session request. (optional) 

            try
            {
                // Creates a payment session.
                PaymentSessionResponse result = apiInstance.V1PaymentSessionsPost(authToken, paymentSessionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentSessionApi.V1PaymentSessionsPost: " + e.Message );
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
 **paymentSessionRequest** | [**PaymentSessionRequest**](PaymentSessionRequest.md)| The payment session request. | [optional] 

### Return type

[**PaymentSessionResponse**](PaymentSessionResponse.md)

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


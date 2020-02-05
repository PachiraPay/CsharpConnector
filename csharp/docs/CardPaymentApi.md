# pachirapay.Connector.Api.CardPaymentApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1PaymentsCardPaymentPost**](CardPaymentApi.md#v1paymentscardpaymentpost) | **POST** /v1/payments/card-payment | Authorization / payment



## V1PaymentsCardPaymentPost

> CardPaymentResponse V1PaymentsCardPaymentPost (string authToken, CardPaymentRequest cardPaymentRequest = null)

Authorization / payment

Achieve a payment with a card without 3DSecure.  To achieve a 3DS payment (CheckEnrollment), see the /payment/card3ds-payment resource.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pachirapay.Connector.Api;
using pachirapay.Connector.Client;
using pachirapay.Connector.Model;

namespace Example
{
    public class V1PaymentsCardPaymentPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new CardPaymentApi(Configuration.Default);
            var authToken = authToken_example;  // string | Gets or sets the authentication token.
            var cardPaymentRequest = new CardPaymentRequest(); // CardPaymentRequest | All data needed to make card payment (optional) 

            try
            {
                // Authorization / payment
                CardPaymentResponse result = apiInstance.V1PaymentsCardPaymentPost(authToken, cardPaymentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CardPaymentApi.V1PaymentsCardPaymentPost: " + e.Message );
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
 **cardPaymentRequest** | [**CardPaymentRequest**](CardPaymentRequest.md)| All data needed to make card payment | [optional] 

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


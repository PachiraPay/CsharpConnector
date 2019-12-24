# Cpayment.Connector.Api.DuplicatePaymentApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1PaymentsDuplicatePaymentBatchPost**](DuplicatePaymentApi.md#v1paymentsduplicatepaymentbatchpost) | **POST** /v1/payments/duplicate-payment/batch | Duplicate payment batch
[**V1PaymentsDuplicatePaymentPost**](DuplicatePaymentApi.md#v1paymentsduplicatepaymentpost) | **POST** /v1/payments/duplicate-payment | Duplicate payment



## V1PaymentsDuplicatePaymentBatchPost

> CardPaymentResponse V1PaymentsDuplicatePaymentBatchPost (string authToken, DuplicatePaymentBatchRequest duplicatePaymentBatchRequest = null)

Duplicate payment batch

Achieve a batch of payments by copy of previously processed payments, with the same payment method.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cpayment.Connector.Api;
using Cpayment.Connector.Client;
using Cpayment.Connector.Model;

namespace Example
{
    public class V1PaymentsDuplicatePaymentBatchPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DuplicatePaymentApi(Configuration.Default);
            var authToken = authToken_example;  // string | Gets or sets the authentication token.
            var duplicatePaymentBatchRequest = new DuplicatePaymentBatchRequest(); // DuplicatePaymentBatchRequest | All data needed to make process the payment, with the reference to the previously payment. (optional) 

            try
            {
                // Duplicate payment batch
                CardPaymentResponse result = apiInstance.V1PaymentsDuplicatePaymentBatchPost(authToken, duplicatePaymentBatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DuplicatePaymentApi.V1PaymentsDuplicatePaymentBatchPost: " + e.Message );
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
 **duplicatePaymentBatchRequest** | [**DuplicatePaymentBatchRequest**](DuplicatePaymentBatchRequest.md)| All data needed to make process the payment, with the reference to the previously payment. | [optional] 

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


## V1PaymentsDuplicatePaymentPost

> CardPaymentResponse V1PaymentsDuplicatePaymentPost (string authToken, DuplicatePaymentRequest duplicatePaymentRequest = null)

Duplicate payment

Achieve a payment by copy of a previously processed payment, with the same payment method.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cpayment.Connector.Api;
using Cpayment.Connector.Client;
using Cpayment.Connector.Model;

namespace Example
{
    public class V1PaymentsDuplicatePaymentPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DuplicatePaymentApi(Configuration.Default);
            var authToken = authToken_example;  // string | Gets or sets the authentication token.
            var duplicatePaymentRequest = new DuplicatePaymentRequest(); // DuplicatePaymentRequest | All data needed to make process the payment, with the reference to the previously payment. (optional) 

            try
            {
                // Duplicate payment
                CardPaymentResponse result = apiInstance.V1PaymentsDuplicatePaymentPost(authToken, duplicatePaymentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DuplicatePaymentApi.V1PaymentsDuplicatePaymentPost: " + e.Message );
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
 **duplicatePaymentRequest** | [**DuplicatePaymentRequest**](DuplicatePaymentRequest.md)| All data needed to make process the payment, with the reference to the previously payment. | [optional] 

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


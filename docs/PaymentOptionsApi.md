# Cpayment.Connector.Api.PaymentOptionsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1PaymentOptionsMerchantsByMerchantIdSitesByMerchantSiteIdGet**](PaymentOptionsApi.md#v1paymentoptionsmerchantsbymerchantidsitesbymerchantsiteidget) | **GET** /v1/payment-options/merchants/{merchantId}/sites/{merchantSiteId} | Gets payment options
[**V1PaymentOptionsPost**](PaymentOptionsApi.md#v1paymentoptionspost) | **POST** /v1/payment-options | Gets payment options for a context
[**V1PaymentOptionsValidateEligibilityPost**](PaymentOptionsApi.md#v1paymentoptionsvalidateeligibilitypost) | **POST** /v1/payment-options/validateEligibility | Validates eligibility



## V1PaymentOptionsMerchantsByMerchantIdSitesByMerchantSiteIdGet

> PaymentOptionsResponse V1PaymentOptionsMerchantsByMerchantIdSitesByMerchantSiteIdGet (int? merchantId, string merchantSiteId, string authToken)

Gets payment options

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cpayment.Connector.Api;
using Cpayment.Connector.Client;
using Cpayment.Connector.Model;

namespace Example
{
    public class V1PaymentOptionsMerchantsByMerchantIdSitesByMerchantSiteIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new PaymentOptionsApi(Configuration.Default);
            var merchantId = 56;  // int? | The merchant identifier.
            var merchantSiteId = merchantSiteId_example;  // string | The merchant site identifier.
            var authToken = authToken_example;  // string | Gets or sets the authentication token.

            try
            {
                // Gets payment options
                PaymentOptionsResponse result = apiInstance.V1PaymentOptionsMerchantsByMerchantIdSitesByMerchantSiteIdGet(merchantId, merchantSiteId, authToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentOptionsApi.V1PaymentOptionsMerchantsByMerchantIdSitesByMerchantSiteIdGet: " + e.Message );
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
 **merchantId** | **int?**| The merchant identifier. | 
 **merchantSiteId** | **string**| The merchant site identifier. | 
 **authToken** | **string**| Gets or sets the authentication token. | 

### Return type

[**PaymentOptionsResponse**](PaymentOptionsResponse.md)

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


## V1PaymentOptionsPost

> PaymentOptionsResponse V1PaymentOptionsPost (string authToken, PaymentOptionsRequest paymentOptionsRequest = null)

Gets payment options for a context

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cpayment.Connector.Api;
using Cpayment.Connector.Client;
using Cpayment.Connector.Model;

namespace Example
{
    public class V1PaymentOptionsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new PaymentOptionsApi(Configuration.Default);
            var authToken = authToken_example;  // string | Gets or sets the authentication token.
            var paymentOptionsRequest = new PaymentOptionsRequest(); // PaymentOptionsRequest | The payment options request. (optional) 

            try
            {
                // Gets payment options for a context
                PaymentOptionsResponse result = apiInstance.V1PaymentOptionsPost(authToken, paymentOptionsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentOptionsApi.V1PaymentOptionsPost: " + e.Message );
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
 **paymentOptionsRequest** | [**PaymentOptionsRequest**](PaymentOptionsRequest.md)| The payment options request. | [optional] 

### Return type

[**PaymentOptionsResponse**](PaymentOptionsResponse.md)

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


## V1PaymentOptionsValidateEligibilityPost

> void V1PaymentOptionsValidateEligibilityPost (string authToken, Object paymentOptionEligibilityRequest = null)

Validates eligibility

WARNING : NOT IMPLEMENTED YET.     Validates the eligibility of the given payment option, according to context.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cpayment.Connector.Api;
using Cpayment.Connector.Client;
using Cpayment.Connector.Model;

namespace Example
{
    public class V1PaymentOptionsValidateEligibilityPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new PaymentOptionsApi(Configuration.Default);
            var authToken = authToken_example;  // string | Gets or sets the authentication token.
            var paymentOptionEligibilityRequest = ;  // Object | The payment option eligibility request. (optional) 

            try
            {
                // Validates eligibility
                apiInstance.V1PaymentOptionsValidateEligibilityPost(authToken, paymentOptionEligibilityRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentOptionsApi.V1PaymentOptionsValidateEligibilityPost: " + e.Message );
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
 **paymentOptionEligibilityRequest** | **Object**| The payment option eligibility request. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


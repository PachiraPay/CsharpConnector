# Cpayment.Connector.Api.StoredPaymentMethodsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1StoredPaymentMethodsMerchantsByMerchantIdSitesByMerchantSiteIdCustomerRefByCustomerRefGet**](StoredPaymentMethodsApi.md#v1storedpaymentmethodsmerchantsbymerchantidsitesbymerchantsiteidcustomerrefbycustomerrefget) | **GET** /v1/stored-payment-methods/merchants/{merchantId}/sites/{merchantSiteId}/customerRef/{customerRef} | Gets stored payment methods by CustomerRef
[**V1StoredPaymentMethodsMerchantsByMerchantIdSitesByMerchantSiteIdStoredPaymentMethodIdByStoredPaymentMethodIdDelete**](StoredPaymentMethodsApi.md#v1storedpaymentmethodsmerchantsbymerchantidsitesbymerchantsiteidstoredpaymentmethodidbystoredpaymentmethodiddelete) | **DELETE** /v1/stored-payment-methods/merchants/{merchantId}/sites/{merchantSiteId}/storedPaymentMethodId/{storedPaymentMethodId} | Deletes a stored payment method
[**V1StoredPaymentMethodsMerchantsByMerchantIdSitesByMerchantSiteIdStoredPaymentMethodIdByStoredPaymentMethodIdGet**](StoredPaymentMethodsApi.md#v1storedpaymentmethodsmerchantsbymerchantidsitesbymerchantsiteidstoredpaymentmethodidbystoredpaymentmethodidget) | **GET** /v1/stored-payment-methods/merchants/{merchantId}/sites/{merchantSiteId}/storedPaymentMethodId/{storedPaymentMethodId} | Gets a stored payment method
[**V1StoredPaymentMethodsPost**](StoredPaymentMethodsApi.md#v1storedpaymentmethodspost) | **POST** /v1/stored-payment-methods | Stores a new payment method.



## V1StoredPaymentMethodsMerchantsByMerchantIdSitesByMerchantSiteIdCustomerRefByCustomerRefGet

> StoredPaymentMethodResponse V1StoredPaymentMethodsMerchantsByMerchantIdSitesByMerchantSiteIdCustomerRefByCustomerRefGet (int? merchantId, string merchantSiteId, string customerRef, string authToken)

Gets stored payment methods by CustomerRef

Gets the stored payment methods by customer reference.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cpayment.Connector.Api;
using Cpayment.Connector.Client;
using Cpayment.Connector.Model;

namespace Example
{
    public class V1StoredPaymentMethodsMerchantsByMerchantIdSitesByMerchantSiteIdCustomerRefByCustomerRefGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new StoredPaymentMethodsApi(Configuration.Default);
            var merchantId = 56;  // int? | The merchant identifier.
            var merchantSiteId = merchantSiteId_example;  // string | The merchant site identifier.
            var customerRef = customerRef_example;  // string | The customer reference.
            var authToken = authToken_example;  // string | Gets or sets the authentication token.

            try
            {
                // Gets stored payment methods by CustomerRef
                StoredPaymentMethodResponse result = apiInstance.V1StoredPaymentMethodsMerchantsByMerchantIdSitesByMerchantSiteIdCustomerRefByCustomerRefGet(merchantId, merchantSiteId, customerRef, authToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StoredPaymentMethodsApi.V1StoredPaymentMethodsMerchantsByMerchantIdSitesByMerchantSiteIdCustomerRefByCustomerRefGet: " + e.Message );
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
 **customerRef** | **string**| The customer reference. | 
 **authToken** | **string**| Gets or sets the authentication token. | 

### Return type

[**StoredPaymentMethodResponse**](StoredPaymentMethodResponse.md)

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


## V1StoredPaymentMethodsMerchantsByMerchantIdSitesByMerchantSiteIdStoredPaymentMethodIdByStoredPaymentMethodIdDelete

> string V1StoredPaymentMethodsMerchantsByMerchantIdSitesByMerchantSiteIdStoredPaymentMethodIdByStoredPaymentMethodIdDelete (int? merchantId, string merchantSiteId, string storedPaymentMethodId, string authToken)

Deletes a stored payment method

Deletes the specified stored payment method.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cpayment.Connector.Api;
using Cpayment.Connector.Client;
using Cpayment.Connector.Model;

namespace Example
{
    public class V1StoredPaymentMethodsMerchantsByMerchantIdSitesByMerchantSiteIdStoredPaymentMethodIdByStoredPaymentMethodIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new StoredPaymentMethodsApi(Configuration.Default);
            var merchantId = 56;  // int? | The merchant identifier
            var merchantSiteId = merchantSiteId_example;  // string | The merchant site identifier
            var storedPaymentMethodId = storedPaymentMethodId_example;  // string | The stored payment method identifier
            var authToken = authToken_example;  // string | Gets or sets the authentication token.

            try
            {
                // Deletes a stored payment method
                string result = apiInstance.V1StoredPaymentMethodsMerchantsByMerchantIdSitesByMerchantSiteIdStoredPaymentMethodIdByStoredPaymentMethodIdDelete(merchantId, merchantSiteId, storedPaymentMethodId, authToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StoredPaymentMethodsApi.V1StoredPaymentMethodsMerchantsByMerchantIdSitesByMerchantSiteIdStoredPaymentMethodIdByStoredPaymentMethodIdDelete: " + e.Message );
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
 **merchantId** | **int?**| The merchant identifier | 
 **merchantSiteId** | **string**| The merchant site identifier | 
 **storedPaymentMethodId** | **string**| The stored payment method identifier | 
 **authToken** | **string**| Gets or sets the authentication token. | 

### Return type

**string**

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


## V1StoredPaymentMethodsMerchantsByMerchantIdSitesByMerchantSiteIdStoredPaymentMethodIdByStoredPaymentMethodIdGet

> StoredPaymentMethodResponse V1StoredPaymentMethodsMerchantsByMerchantIdSitesByMerchantSiteIdStoredPaymentMethodIdByStoredPaymentMethodIdGet (int? merchantId, string merchantSiteId, string storedPaymentMethodId, string authToken)

Gets a stored payment method

Gets the stored payment method by its unique identifier.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cpayment.Connector.Api;
using Cpayment.Connector.Client;
using Cpayment.Connector.Model;

namespace Example
{
    public class V1StoredPaymentMethodsMerchantsByMerchantIdSitesByMerchantSiteIdStoredPaymentMethodIdByStoredPaymentMethodIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new StoredPaymentMethodsApi(Configuration.Default);
            var merchantId = 56;  // int? | 
            var merchantSiteId = merchantSiteId_example;  // string | 
            var storedPaymentMethodId = storedPaymentMethodId_example;  // string | The stored payment method identifier.
            var authToken = authToken_example;  // string | Gets or sets the authentication token.

            try
            {
                // Gets a stored payment method
                StoredPaymentMethodResponse result = apiInstance.V1StoredPaymentMethodsMerchantsByMerchantIdSitesByMerchantSiteIdStoredPaymentMethodIdByStoredPaymentMethodIdGet(merchantId, merchantSiteId, storedPaymentMethodId, authToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StoredPaymentMethodsApi.V1StoredPaymentMethodsMerchantsByMerchantIdSitesByMerchantSiteIdStoredPaymentMethodIdByStoredPaymentMethodIdGet: " + e.Message );
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
 **merchantId** | **int?**|  | 
 **merchantSiteId** | **string**|  | 
 **storedPaymentMethodId** | **string**| The stored payment method identifier. | 
 **authToken** | **string**| Gets or sets the authentication token. | 

### Return type

[**StoredPaymentMethodResponse**](StoredPaymentMethodResponse.md)

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


## V1StoredPaymentMethodsPost

> string V1StoredPaymentMethodsPost (string authToken, StoredPaymentMethodRequest storedPaymentMethodRequest = null)

Stores a new payment method.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cpayment.Connector.Api;
using Cpayment.Connector.Client;
using Cpayment.Connector.Model;

namespace Example
{
    public class V1StoredPaymentMethodsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new StoredPaymentMethodsApi(Configuration.Default);
            var authToken = authToken_example;  // string | Gets or sets the authentication token.
            var storedPaymentMethodRequest = new StoredPaymentMethodRequest(); // StoredPaymentMethodRequest | The payment method to store. (optional) 

            try
            {
                // Stores a new payment method.
                string result = apiInstance.V1StoredPaymentMethodsPost(authToken, storedPaymentMethodRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StoredPaymentMethodsApi.V1StoredPaymentMethodsPost: " + e.Message );
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
 **storedPaymentMethodRequest** | [**StoredPaymentMethodRequest**](StoredPaymentMethodRequest.md)| The payment method to store. | [optional] 

### Return type

**string**

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


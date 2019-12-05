# Cpayment.Connector.Api.PaymentsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1PaymentsAllByOrderRefMerchantsByMerchantIdSitesByMerchantSiteIdGet**](PaymentsApi.md#v1paymentsallbyorderrefmerchantsbymerchantidsitesbymerchantsiteidget) | **GET** /v1/payments/all/{orderRef}/merchants/{merchantId}/sites/{merchantSiteId} | Gets all payment schedules
[**V1PaymentsByOrderRefMerchantsByMerchantIdSitesByMerchantSiteIdByOrderTagGet**](PaymentsApi.md#v1paymentsbyorderrefmerchantsbymerchantidsitesbymerchantsiteidbyordertagget) | **GET** /v1/payments/{orderRef}/merchants/{merchantId}/sites/{merchantSiteId}/{orderTag} | Gets payment schedule by tag.
[**V1PaymentsByOrderRefMerchantsByMerchantIdSitesByMerchantSiteIdGet**](PaymentsApi.md#v1paymentsbyorderrefmerchantsbymerchantidsitesbymerchantsiteidget) | **GET** /v1/payments/{orderRef}/merchants/{merchantId}/sites/{merchantSiteId} | Gets payment schedule
[**V1PaymentsByOrderRefOperationsCancelOrRefundPut**](PaymentsApi.md#v1paymentsbyorderrefoperationscancelorrefundput) | **PUT** /v1/payments/{orderRef}/operations/cancelOrRefund | Cancel or refund
[**V1PaymentsByOrderRefOperationsCapturePut**](PaymentsApi.md#v1paymentsbyorderrefoperationscaptureput) | **PUT** /v1/payments/{orderRef}/operations/capture | Capture
[**V1PaymentsByOrderRefOperationsRecomputePut**](PaymentsApi.md#v1paymentsbyorderrefoperationsrecomputeput) | **PUT** /v1/payments/{orderRef}/operations/recompute | Recompute schedule



## V1PaymentsAllByOrderRefMerchantsByMerchantIdSitesByMerchantSiteIdGet

> PaymentOperationsResponse V1PaymentsAllByOrderRefMerchantsByMerchantIdSitesByMerchantSiteIdGet (string orderRef, int? merchantId, string merchantSiteId, string authToken)

Gets all payment schedules

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cpayment.Connector.Api;
using Cpayment.Connector.Client;
using Cpayment.Connector.Model;

namespace Example
{
    public class V1PaymentsAllByOrderRefMerchantsByMerchantIdSitesByMerchantSiteIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new PaymentsApi(Configuration.Default);
            var orderRef = orderRef_example;  // string | The order reference.
            var merchantId = 56;  // int? | The merchant identifier.
            var merchantSiteId = merchantSiteId_example;  // string | The merchant site identifier.
            var authToken = authToken_example;  // string | Gets or sets the authentication token.

            try
            {
                // Gets all payment schedules
                PaymentOperationsResponse result = apiInstance.V1PaymentsAllByOrderRefMerchantsByMerchantIdSitesByMerchantSiteIdGet(orderRef, merchantId, merchantSiteId, authToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentsApi.V1PaymentsAllByOrderRefMerchantsByMerchantIdSitesByMerchantSiteIdGet: " + e.Message );
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
 **orderRef** | **string**| The order reference. | 
 **merchantId** | **int?**| The merchant identifier. | 
 **merchantSiteId** | **string**| The merchant site identifier. | 
 **authToken** | **string**| Gets or sets the authentication token. | 

### Return type

[**PaymentOperationsResponse**](PaymentOperationsResponse.md)

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


## V1PaymentsByOrderRefMerchantsByMerchantIdSitesByMerchantSiteIdByOrderTagGet

> PaymentOperationsResponse V1PaymentsByOrderRefMerchantsByMerchantIdSitesByMerchantSiteIdByOrderTagGet (string orderRef, int? merchantId, string merchantSiteId, string orderTag, string authToken)

Gets payment schedule by tag.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cpayment.Connector.Api;
using Cpayment.Connector.Client;
using Cpayment.Connector.Model;

namespace Example
{
    public class V1PaymentsByOrderRefMerchantsByMerchantIdSitesByMerchantSiteIdByOrderTagGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new PaymentsApi(Configuration.Default);
            var orderRef = orderRef_example;  // string | The order reference.
            var merchantId = 56;  // int? | The merchant identifier.
            var merchantSiteId = merchantSiteId_example;  // string | The merchant site identifier.
            var orderTag = orderTag_example;  // string | The order Tag
            var authToken = authToken_example;  // string | Gets or sets the authentication token.

            try
            {
                // Gets payment schedule by tag.
                PaymentOperationsResponse result = apiInstance.V1PaymentsByOrderRefMerchantsByMerchantIdSitesByMerchantSiteIdByOrderTagGet(orderRef, merchantId, merchantSiteId, orderTag, authToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentsApi.V1PaymentsByOrderRefMerchantsByMerchantIdSitesByMerchantSiteIdByOrderTagGet: " + e.Message );
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
 **orderRef** | **string**| The order reference. | 
 **merchantId** | **int?**| The merchant identifier. | 
 **merchantSiteId** | **string**| The merchant site identifier. | 
 **orderTag** | **string**| The order Tag | 
 **authToken** | **string**| Gets or sets the authentication token. | 

### Return type

[**PaymentOperationsResponse**](PaymentOperationsResponse.md)

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


## V1PaymentsByOrderRefMerchantsByMerchantIdSitesByMerchantSiteIdGet

> PaymentOperationsResponse V1PaymentsByOrderRefMerchantsByMerchantIdSitesByMerchantSiteIdGet (string orderRef, int? merchantId, string merchantSiteId, string authToken)

Gets payment schedule

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cpayment.Connector.Api;
using Cpayment.Connector.Client;
using Cpayment.Connector.Model;

namespace Example
{
    public class V1PaymentsByOrderRefMerchantsByMerchantIdSitesByMerchantSiteIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new PaymentsApi(Configuration.Default);
            var orderRef = orderRef_example;  // string | The order reference.
            var merchantId = 56;  // int? | The merchant identifier.
            var merchantSiteId = merchantSiteId_example;  // string | The merchant site identifier.
            var authToken = authToken_example;  // string | Gets or sets the authentication token.

            try
            {
                // Gets payment schedule
                PaymentOperationsResponse result = apiInstance.V1PaymentsByOrderRefMerchantsByMerchantIdSitesByMerchantSiteIdGet(orderRef, merchantId, merchantSiteId, authToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentsApi.V1PaymentsByOrderRefMerchantsByMerchantIdSitesByMerchantSiteIdGet: " + e.Message );
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
 **orderRef** | **string**| The order reference. | 
 **merchantId** | **int?**| The merchant identifier. | 
 **merchantSiteId** | **string**| The merchant site identifier. | 
 **authToken** | **string**| Gets or sets the authentication token. | 

### Return type

[**PaymentOperationsResponse**](PaymentOperationsResponse.md)

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


## V1PaymentsByOrderRefOperationsCancelOrRefundPut

> PaymentOperationsResponse V1PaymentsByOrderRefOperationsCancelOrRefundPut (string orderRef, string authToken, PaymentOperationsRequest paymentOperationRequest = null)

Cancel or refund

This operation allows the merchant to cancel (also referred to as \"void\") or refund a transaction, according to its current state.    You can find below the exhaustive list of cases which may happen.      With a Cancel operation, the customer will not see movement on his bank account, contrary to Refund which gives back the charged amount.    Cancel is only performed when:    1. The transaction is not yet captured (in which case, the fund reservation on the customer payment method is cleared)    2. The operation occurs on the same day as the capture operation.        If you want to cancel or refund less than the original transaction amount, you can specify the amount in the request body.   Alternatively you can specify an amount of 0 (or not specify the amount in the request) if you want to refund the total amount.    * Partial operation: 0 &lt; amount &lt; transaction amount    * Full operation: amount == transaction amount OR amount == 0      - --      ## Cancel Or Refund cases ##     **After the authorization, and before the capture**     Because the refund operation cannot be executed on a non-captured transaction, only the cancel operation is supported    | Partial Operation                                                               | Full Operation                                                                                                                                      |  | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- |  | No interaction with partners because partial cancel/void is **not supported**. <br /> The only impact is an update of the remaining amount to capture in payment hub. | **Cancel** operation will be executed on the entire transaction. <br /> The fund reservation on the customer payment method will be cleared, and capture will no longer be possible.<br /> Cancelling a non captured transaction is **not worldwide supported**, and depends on the payment partner (PSP), the acquiring bank, and the issuing bank. |    **After the capture**     Because the balance is made at midnight, either the cancel operation or the refund operation will be selected depending on the date.       |                                          | Partial Operation                                                                                                             | Full Operation                                            |  | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- |  | On the same day as the capture operation | The **cancel** operation will be executed. <br /> Partial cancelling of a captured transaction is supported, but doesn't behave the same depending on the payment partner used. <br /> In some cases, a **refund** will be executed instead. | The **cancel** operation will be executed. <br /> Full cancel of a captured transaction is **fully supported**. |  | D+1 and later                            | The **refund** operation will be executed. <br /> Partial refund is **fully supported**. | The **refund** operation will be executed. <br /> Full refund is **fully supported**. |

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cpayment.Connector.Api;
using Cpayment.Connector.Client;
using Cpayment.Connector.Model;

namespace Example
{
    public class V1PaymentsByOrderRefOperationsCancelOrRefundPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new PaymentsApi(Configuration.Default);
            var orderRef = orderRef_example;  // string | The OrderRef.
            var authToken = authToken_example;  // string | Gets or sets the authentication token.
            var paymentOperationRequest = new PaymentOperationsRequest(); // PaymentOperationsRequest | The payment operation request. Materialized by the Body of the PUT request (optional) 

            try
            {
                // Cancel or refund
                PaymentOperationsResponse result = apiInstance.V1PaymentsByOrderRefOperationsCancelOrRefundPut(orderRef, authToken, paymentOperationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentsApi.V1PaymentsByOrderRefOperationsCancelOrRefundPut: " + e.Message );
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
 **orderRef** | **string**| The OrderRef. | 
 **authToken** | **string**| Gets or sets the authentication token. | 
 **paymentOperationRequest** | [**PaymentOperationsRequest**](PaymentOperationsRequest.md)| The payment operation request. Materialized by the Body of the PUT request | [optional] 

### Return type

[**PaymentOperationsResponse**](PaymentOperationsResponse.md)

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


## V1PaymentsByOrderRefOperationsCapturePut

> PaymentOperationsResponse V1PaymentsByOrderRefOperationsCapturePut (string orderRef, string authToken, PaymentOperationsRequest paymentOperationRequest = null)

Capture

This operation charges the bank account of the customer, following a valid authorization done before. You need to provide a succeeded authorized OrderRef, and the amount you want to charge.  This is well suited for a \"charge at shipping\" scenario: the merchant makes an authorization when the customer place the order, and the bank account is charged when the merchant actually does the shipping.    - If you want to capture the total amount of the authorization, you can either set the amount to 0 in the request, or simply not specify it.    ### Useful reminders:    * You can capture the authorization multiple times, as long as there is some amount remaining. For instance, with an authorization of 100€, you can capture 20€ and then capture 80€ later, within the limited time.    * Please note that the authorization is only valid for a limited amount of time, and that you cannot capture a greater amount than the authorized one.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cpayment.Connector.Api;
using Cpayment.Connector.Client;
using Cpayment.Connector.Model;

namespace Example
{
    public class V1PaymentsByOrderRefOperationsCapturePutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new PaymentsApi(Configuration.Default);
            var orderRef = orderRef_example;  // string | The OrderRef.
            var authToken = authToken_example;  // string | Gets or sets the authentication token.
            var paymentOperationRequest = new PaymentOperationsRequest(); // PaymentOperationsRequest | The payment operation request. Materialized by the Body of the PUT request (optional) 

            try
            {
                // Capture
                PaymentOperationsResponse result = apiInstance.V1PaymentsByOrderRefOperationsCapturePut(orderRef, authToken, paymentOperationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentsApi.V1PaymentsByOrderRefOperationsCapturePut: " + e.Message );
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
 **orderRef** | **string**| The OrderRef. | 
 **authToken** | **string**| Gets or sets the authentication token. | 
 **paymentOperationRequest** | [**PaymentOperationsRequest**](PaymentOperationsRequest.md)| The payment operation request. Materialized by the Body of the PUT request | [optional] 

### Return type

[**PaymentOperationsResponse**](PaymentOperationsResponse.md)

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


## V1PaymentsByOrderRefOperationsRecomputePut

> PaymentOperationsResponse V1PaymentsByOrderRefOperationsRecomputePut (string orderRef, string authToken, PaymentOperationsRequest paymentOperationRequest = null)

Recompute schedule

This operation forces the recomputation of the payment schedule, using the default payment schedule rules.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cpayment.Connector.Api;
using Cpayment.Connector.Client;
using Cpayment.Connector.Model;

namespace Example
{
    public class V1PaymentsByOrderRefOperationsRecomputePutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new PaymentsApi(Configuration.Default);
            var orderRef = orderRef_example;  // string | The OrderRef.
            var authToken = authToken_example;  // string | Gets or sets the authentication token.
            var paymentOperationRequest = new PaymentOperationsRequest(); // PaymentOperationsRequest | The payment operation request. Materialized by the Body of the PUT request (optional) 

            try
            {
                // Recompute schedule
                PaymentOperationsResponse result = apiInstance.V1PaymentsByOrderRefOperationsRecomputePut(orderRef, authToken, paymentOperationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentsApi.V1PaymentsByOrderRefOperationsRecomputePut: " + e.Message );
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
 **orderRef** | **string**| The OrderRef. | 
 **authToken** | **string**| Gets or sets the authentication token. | 
 **paymentOperationRequest** | [**PaymentOperationsRequest**](PaymentOperationsRequest.md)| The payment operation request. Materialized by the Body of the PUT request | [optional] 

### Return type

[**PaymentOperationsResponse**](PaymentOperationsResponse.md)

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


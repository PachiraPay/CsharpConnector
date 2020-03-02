# pachirapay.Connector.Api.PaymentsApi

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

This operation allows the merchant to retrieve some details about a payment giving an order reference.  When calling this operation, Payment SAAS returns all the schedules associated with the order reference (whatever the order tag) (and so does the amount, the state, the date...), and useful informations for making other operations, such as the captured, remaining, cancelled and refunded amount.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pachirapay.Connector.Api;
using pachirapay.Connector.Client;
using pachirapay.Connector.Model;

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

This operation allows the merchant to retrieve some details about a payment giving an order reference and an order tag.  When calling this operation, Payment SAAS returns the schedule associated with the order referenceand the specified the order tag (and so does the amount, the state, the date...), and useful informations for making other operations, such as the captured, remaining, cancelled and refunded amount.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pachirapay.Connector.Api;
using pachirapay.Connector.Client;
using pachirapay.Connector.Model;

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

This operation allows the merchant to retrieve some details about a payment giving an order reference.  When calling this operation, Payment SAAS returns the schedule associated with the order reference(and so does the amount, the state, the date...), and useful informations for making other operations, such as the captured, remaining, cancelled and refunded amount.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pachirapay.Connector.Api;
using pachirapay.Connector.Client;
using pachirapay.Connector.Model;

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

<div id=\"doc\">  <link href=\"/redoc/font-awesome-4.7.0/css/font-awesome.min.css\" rel=\"stylesheet\" />  <link href=\"/redoc/style.css\" rel=\"stylesheet\" />  <p>This operation allows the merchant to cancel (also refered to as \"void\") or refund a transaction, according to its current state.</p>  <p>You can find below the exhaustive list of cases which may happen.</p>  <div class=\"quote info\">  With a <strong>Cancel</strong> operation, the customer will not see movement on his bank account, contrary to <strong>Refund</strong> which gives back the <span>charged </span>amount.<br /><br />  Cancel is <span>only </span>performed when :  <ul><li>the transaction is not yet captured (in which case, the fund reservation on the customer payment method is cleared)</li><li>the operation occurs the same day as the capture operation.</li></ul></div>  <div class=\"quote success\">  If you want to cancel or refund less than the original transaction amount, you can specify the amount in the request body. Alternatively you can specify an amount of 0 if you want to refund the total amount.  <p><strong><u>Partial operation</u></strong> :  <em>  0 <strong>&lt;</strong><span style=\"color: rgb(0, 0, 128);\">amount </span><strong>&lt;</strong> transaction's amount<br /></em><u><strong>Full operation</strong></u> :  <em><em><span style=\"color: rgb(0, 0, 128);\">  amount  <strong><span style=\"color: rgb(0, 0, 0);\">==</span></strong></span> transaction's amount <strong>OR</strong><span style=\"color: rgb(0, 0, 128);\">amount</span><strong>==</strong> 0                      </em></em></p></div>  <h3>Cancel Or Refund cases</h3>  <h4>              After the authorization, and before the capture          </h4>  <p class=\"quote info\">  <em>  <em>Because the refund operation cannot be executed on a non-captured transaction</em>, only the cancel operation is supported              </em>    </p>  <table class=\"relative-table wrapped\" style=\"width: 91.7576%;\">  <colgroup>  <col style=\"width: 51.1326%;\" />  <col style=\"width: 48.7893%;\" />      </colgroup>  <tbody>  <tr>  <th>  <strong> Partial operation</strong>          </th>  <th>  <em>  <strong>Full operation</strong>            </em>          </th>        </tr>  <tr>  <td>  <p>No interaction with partners because partial cancel/void is not supported.</p>  <p>The only impact is an update of the remaining amount to capture in payment hub.</p>          </td>  <td>  <p>  <strong>Cancel</strong> operation will be executed on the entire transaction.                          </p>  <p>The fund reservation on the customer payment method will be cleared, and capture will no longer be possible.</p>  <p class=\"quote warning\">                              Cancelling a non captured transaction is not worldwide supported. Depending on the payment partner (PSP), the acquiring bank, and the issuing bank.                          </p>          </td>        </tr>      </tbody>    </table>  <h4>After the capture</h4>  <p class=\"quote info\">              Because the balance is made at midnight, either the cancel operation or the refund operation will be selected depending on the date.          </p>  <table class=\"wrapped\">  <colgroup>  <col />  <col />  <col />      </colgroup>  <tbody>  <tr>  <th>  <br />          </th>  <th>  <em>  <strong>Partial operation</strong>            </em>          </th>  <th>  <em>  <em>  <strong>Full operation</strong>              </em>            </em>          </th>        </tr>  <tr>  <td class=\"highlight-grey\" data-highlight-colour=\"grey\">  <strong>On the same day as the capture operation</strong>          </td>  <td>  <div class=\"content-wrapper\">  <p>The <strong>cancel</strong> operation will be executed.</p>  <p class=\"quote warning\">  <span>Partial cancelling of a captured transaction is supported, but doesn't behave the same depending on the payment partner used.</span>              </p>            </div>          </td>  <td>  <p>The <strong>cancel</strong> operation will be executed.</p>  <p>Full cancel of a captured transaction is fully supported.</p>          </td>        </tr>  <tr>  <td class=\"highlight-grey\" data-highlight-colour=\"grey\">  <strong>D+1 and later</strong>          </td>  <td>The <strong>refund</strong> operation will be executed.<br /><br />Partial refund is fully supported.</td>  <td>The <strong>refund</strong> operation will be executed.<br /><br />Full refund is fully supported.</td>        </tr>      </tbody>    </table>  </div>

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pachirapay.Connector.Api;
using pachirapay.Connector.Client;
using pachirapay.Connector.Model;

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
using pachirapay.Connector.Api;
using pachirapay.Connector.Client;
using pachirapay.Connector.Model;

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
using pachirapay.Connector.Api;
using pachirapay.Connector.Client;
using pachirapay.Connector.Model;

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


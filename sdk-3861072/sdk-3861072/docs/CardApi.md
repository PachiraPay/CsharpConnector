# pachirapay.Connector.Api.CardApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1CardCreditHolderPost**](CardApi.md#v1cardcreditholderpost) | **POST** /v1/card/creditHolder | Credit a card.



## V1CardCreditHolderPost

> CardPaymentCreditHolderResponse V1CardCreditHolderPost (string authToken, CardPaymentCreditHolderRequest request = null)

Credit a card.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pachirapay.Connector.Api;
using pachirapay.Connector.Client;
using pachirapay.Connector.Model;

namespace Example
{
    public class V1CardCreditHolderPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new CardApi(Configuration.Default);
            var authToken = authToken_example;  // string | Gets or sets the authentication token.
            var request = new CardPaymentCreditHolderRequest(); // CardPaymentCreditHolderRequest |  (optional) 

            try
            {
                // Credit a card.
                CardPaymentCreditHolderResponse result = apiInstance.V1CardCreditHolderPost(authToken, request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CardApi.V1CardCreditHolderPost: " + e.Message );
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
 **request** | [**CardPaymentCreditHolderRequest**](CardPaymentCreditHolderRequest.md)|  | [optional] 

### Return type

[**CardPaymentCreditHolderResponse**](CardPaymentCreditHolderResponse.md)

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


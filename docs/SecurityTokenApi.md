# Cpayment.Connector.Api.SecurityTokenApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1AuthTokenGet**](SecurityTokenApi.md#v1authtokenget) | **GET** /v1/auth/token | Authenticate



## V1AuthTokenGet

> string V1AuthTokenGet (string authorization = null)

Authenticate

Get the token provided by the Security Token Service (STS).  The authentication token is mandatory for the others api calls.  It's expire after 48h by default.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cpayment.Connector.Api;
using Cpayment.Connector.Client;
using Cpayment.Connector.Model;

namespace Example
{
    public class V1AuthTokenGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new SecurityTokenApi(Configuration.Default);
            var authorization = authorization_example;  // string | The credentials (login:password in base64) (optional) 

            try
            {
                // Authenticate
                string result = apiInstance.V1AuthTokenGet(authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SecurityTokenApi.V1AuthTokenGet: " + e.Message );
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
 **authorization** | **string**| The credentials (login:password in base64) | [optional] 

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
| **403** | Forbidden |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


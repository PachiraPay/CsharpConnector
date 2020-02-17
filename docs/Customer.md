
# pachirapay.Connector.Model.Customer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillingAddress** | [**ShippingAddress**](ShippingAddress.md) |  | [optional] 
**BirthDate** | **DateTime?** | The customer birth date. | [optional] 
**Civility** | **string** | The customer civility. | [optional] 
**Country** | **string** | The customer country code. | [optional] 
**CustomerIp** | **string** | The customer IP.   Optional, if not set it will be retrieved during the first load of the payment session into the customer browser. | [optional] 
**CustomerRef** | **string** | The merchant&#39;s customer reference (external identifier).  This field is mandatory, especially if you want store payment method. If so, stored payment methods will be linked to this customer reference. | 
**DeliveryAddress** | [**ShippingAddress**](ShippingAddress.md) |  | [optional] 
**Email** | **string** | The customer email.  Useful for specifics payment methods like PayPal. | [optional] 
**FirstName** | **string** | The customer first name. | [optional] 
**LastName** | **string** | The customer last name. | [optional] 
**MobilePhone** | **string** | The customer mobile phone number. | [optional] 
**Phone** | **string** | The customer phone number. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)


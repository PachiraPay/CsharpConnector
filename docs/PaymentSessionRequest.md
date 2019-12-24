
# Cpayment.Connector.Model.PaymentSessionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MerchantId** | **int?** | MerchantId | [optional] 
**MerchantSiteId** | **string** | MerchantSiteId | [optional] 
**Customer** | [**Customer**](Customer.md) |  | [optional] 
**OrderData** | [**OrderData**](OrderData.md) |  | [optional] 
**StoredCardData** | [**List&lt;StoredCard&gt;**](StoredCard.md) | StoredCardData | [optional] 
**AllowCardStorage** | **bool?** | Gets or sets a value indicating whether [allow card storage]. | [optional] 
**ForcedCardOptionRef** | **string** | Gets or sets a value indicating whether [forced card option reference]. | [optional] 
**ForceCardStorage** | **bool?** | Gets or sets a value indicating whether [forced card storage]. | [optional] 
**ForceImmediateStoredCardPayment** | **bool?** | Gets or sets a value indicating whether [forced immediate stored card]. | [optional] 
**Configuration** | [**Configuration**](Configuration.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)


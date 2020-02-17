
# pachirapay.Connector.Model.OrderData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderDiscountAmount** | **long?** | The order discount amount.  Optional, useful in case of hosted pages, to show an order summary. Useless for iframe integration. | [optional] 
**OrderFeesAmount** | **long?** | The order fees amount.  Optional, useful in case of hosted pages, to show an order summary. Useless for iframe integration. | [optional] 
**OrderRowsAmount** | **long?** | The order rows amount.  Optional, useful in case of hosted pages, to show an order summary. Useless for iframe integration. | [optional] 
**OrderShippingAmount** | **long?** | The order shipping amount.  Optional, useful in case of hosted pages, to show an order summary. Useless for iframe integration. | [optional] 
**TaxAmount** | **long?** | The tax amount.  Optional, useful in case payment without VAT (PRO...) | [optional] 
**FreeText** | **string** | The free text.  Optional, it&#39;s a merchant dedicated field, if needed to passes some correlation data. This data will be returned without any transformation at the end of the payment process. | [optional] 
**Orders** | [**List&lt;SubOrder&gt;**](SubOrder.md) | The orders.  This order list can be used in case of multiple transaction at the same time (example: for multiple marketplace&#39;s sellers).  If so, a different authorization will be done for each of the orders. | [optional] 
**OrderSummaryRef** | **string** | The order summary reference.  For multiple orders, this field is a top level \&quot;orderRef\&quot;, in order to identify a package of orders.  For simple order, this field can be used as \&quot;orderRef\&quot;. | 
**ShippingAddress** | [**ShippingAddress**](ShippingAddress.md) |  | [optional] 
**OrderRef** | **string** | The order reference.  You should set the same value as the *orderSummaryRef*. | 
**InvoiceId** | **long?** | The invoice identifier. | [optional] 
**OrderTag** | **string** | The order tag is a label.  Having a different order tag allow to passes a new authorization for a same *orderSummaryRef* | [optional] 
**OrderDate** | **DateTime?** | The order&#39;s date.  Optional, if not set it will defaults to the current date and time. | [optional] 
**Amount** | **long?** | The *total amount* of the payment (in case of multiple orders, this field should be equals to the sum of all order&#39;s amount) | 
**ScoringToken** | **string** | In case of 3X or 4X payment (CB4X for example), this value should be filled with a valid scoring token. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)


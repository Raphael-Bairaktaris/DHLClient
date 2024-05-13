// See https://aka.ms/new-console-template for more information
using DHLClient;
using Newtonsoft.Json;
using System.Globalization;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, World!");

var pairs = DHLClientConstants.LanguageCodeToStringMapper;

//var countryCode = CountryCode.AD;

//var client = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DHLClientCredentials.txt");



var image = File.ReadAllBytes(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "logo.png"));
var base64 = Convert.ToBase64String(image);
var shipment2 =
   $$$""" 
    {
       "plannedShippingDateAndTime":"2019-08-04T14:00:31GMT+01:00",
       "pickup":{
          "isRequested":false,
          "closeTime":"18:00",
          "location":"reception",
          "specialInstructions":[
             {
                "value":"please ring door bell",
                "typeCode":"TBD"
             }
          ],
          "pickupDetails":{
             "postalAddress":{
                "postalCode":"14800",
                "cityName":"Prague",
                "countryCode":"CZ",
                "provinceCode":"CZ",
                "addressLine1":"V Parku 2308/10",
                "addressLine2":"addres2",
                "addressLine3":"addres3",
                "countyName":"Central Bohemia",
                "provinceName":"Central Bohemia",
                "countryName":"Czech Republic"
             },
             "contactInformation":{
                "email":"that@before.de",
                "phone":"+1123456789",
                "mobilePhone":"+60112345678",
                "companyName":"Company Name",
                "fullName":"John Brew"
             },
             "registrationNumbers":[
                {
                   "typeCode":"VAT",
                   "number":"CZ123456789",
                   "issuerCountryCode":"CZ"
                }
             ],
             "bankDetails":[
                {
                   "name":"Russian Bank Name",
                   "settlementLocalCurrency":"RUB",
                   "settlementForeignCurrency":"USD"
                }
             ],
             "typeCode":"business"
          },
          "pickupRequestorDetails":{
             "postalAddress":{
                "postalCode":"14800",
                "cityName":"Prague",
                "countryCode":"CZ",
                "provinceCode":"CZ",
                "addressLine1":"V Parku 2308/10",
                "addressLine2":"addres2",
                "addressLine3":"addres3",
                "countyName":"Central Bohemia",
                "provinceName":"Central Bohemia",
                "countryName":"Czech Republic"
             },
             "contactInformation":{
                "email":"that@before.de",
                "phone":"+1123456789",
                "mobilePhone":"+60112345678",
                "companyName":"Company Name",
                "fullName":"John Brew"
             },
             "registrationNumbers":[
                {
                   "typeCode":"VAT",
                   "number":"CZ123456789",
                   "issuerCountryCode":"CZ"
                }
             ],
             "bankDetails":[
                {
                   "name":"Russian Bank Name",
                   "settlementLocalCurrency":"RUB",
                   "settlementForeignCurrency":"USD"
                }
             ],
             "typeCode":"business"
          }
       },
       "productCode":"D",
       "localProductCode":"D",
       "getRateEstimates":false,
       "accounts":[
          {
             "typeCode":"shipper",
             "number":"123456789"
          }
       ],
       "valueAddedServices":[
          {
             "serviceCode":"II",
             "value":100,
             "currency":"GBP",
             "method":"cash",
             "dangerousGoods":[
                {
                   "contentId":"908",
                   "dryIceTotalNetWeight":12,
                   "customDescription":"1 package Lithium ion batteries in compliance with Section II of P.I. 9661",
                   "unCodes":[
                      1234
                   ]
                }
             ]
          }
       ],
       "outputImageProperties":{
          "printerDPI":300,
          "customerBarcodes":[
             {
                "content":"barcode content",
                "textBelowBarcode":"text below barcode",
                "symbologyCode":"93"
             }
          ],
          "customerLogos":[
             {
                "fileFormat":"PNG",
                "content":"{{{base64}}}"
             }
          ],
          "encodingFormat":"pdf",
          "imageOptions":[
             {
                "typeCode":"label",
                "templateName":"ECOM26_84_001",
                "isRequested":true,
                "hideAccountNumber":false,
                "numberOfCopies":1,
                "invoiceType":"commercial",
                "languageCode":"eng",
                "languageCountryCode":"br",
                "languageScriptCode":"Latn",
                "encodingFormat":"png",
                "renderDHLLogo":false,
                "fitLabelsToA4":false,
                "labelFreeText":"string",
                "labelCustomerDataText":"string",
                "shipmentReceiptCustomerDataText":"string"
             }
          ],
          "splitTransportAndWaybillDocLabels":true,
          "allDocumentsInOneImage":true,
          "splitDocumentsByPages":true,
          "splitInvoiceAndReceipt":true,
          "receiptAndLabelsInOneImage":true
       },
       "customerReferences":[
          {
             "value":"Customer reference",
             "typeCode":"CU"
          }
       ],
       "identifiers":[
          {
             "typeCode":"shipmentId",
             "value":"1234567890",
             "dataIdentifier":"00"
          }
       ],
       "customerDetails":{
          "shipperDetails":{
             "postalAddress":{
                "postalCode":"14800",
                "cityName":"Prague",
                "countryCode":"CZ",
                "provinceCode":"CZ",
                "addressLine1":"V Parku 2308/10",
                "addressLine2":"addres2",
                "addressLine3":"addres3",
                "countyName":"Central Bohemia",
                "provinceName":"Central Bohemia",
                "countryName":"Czech Republic"
             },
             "contactInformation":{
                "email":"that@before.de",
                "phone":"+1123456789",
                "mobilePhone":"+60112345678",
                "companyName":"Company Name",
                "fullName":"John Brew"
             },
             "registrationNumbers":[
                {
                   "typeCode":"VAT",
                   "number":"CZ123456789",
                   "issuerCountryCode":"CZ"
                }
             ],
             "bankDetails":[
                {
                   "name":"Russian Bank Name",
                   "settlementLocalCurrency":"RUB",
                   "settlementForeignCurrency":"USD"
                }
             ],
             "typeCode":"business"
          },
          "receiverDetails":{
             "postalAddress":{
                "postalCode":"14800",
                "cityName":"Prague",
                "countryCode":"CZ",
                "provinceCode":"CZ",
                "addressLine1":"V Parku 2308/10",
                "addressLine2":"addres2",
                "addressLine3":"addres3",
                "countyName":"Central Bohemia",
                "provinceName":"Central Bohemia",
                "countryName":"Czech Republic"
             },
             "contactInformation":{
                "email":"that@before.de",
                "phone":"+1123456789",
                "mobilePhone":"+60112345678",
                "companyName":"Company Name",
                "fullName":"John Brew"
             },
             "registrationNumbers":[
                {
                   "typeCode":"VAT",
                   "number":"CZ123456789",
                   "issuerCountryCode":"CZ"
                }
             ],
             "bankDetails":[
                {
                   "name":"Russian Bank Name",
                   "settlementLocalCurrency":"RUB",
                   "settlementForeignCurrency":"USD"
                }
             ],
             "typeCode":"business"
          },
          "buyerDetails":{
             "postalAddress":{
                "postalCode":"14800",
                "cityName":"Prague",
                "countryCode":"CZ",
                "provinceCode":"CZ",
                "addressLine1":"V Parku 2308/10",
                "addressLine2":"addres2",
                "addressLine3":"addres3",
                "countyName":"Central Bohemia",
                "provinceName":"Central Bohemia",
                "countryName":"Czech Republic"
             },
             "contactInformation":{
                "email":"buyer@domain.com",
                "phone":"+44123456789",
                "mobilePhone":"+42123456789",
                "companyName":"Customer Company Name",
                "fullName":"Mark Companer"
             },
             "registrationNumbers":[
                {
                   "typeCode":"VAT",
                   "number":"CZ123456789",
                   "issuerCountryCode":"CZ"
                }
             ],
             "bankDetails":[
                {
                   "name":"Russian Bank Name",
                   "settlementLocalCurrency":"RUB",
                   "settlementForeignCurrency":"USD"
                }
             ],
             "typeCode":"business"
          },
          "importerDetails":{
             "postalAddress":{
                "postalCode":"14800",
                "cityName":"Prague",
                "countryCode":"CZ",
                "provinceCode":"CZ",
                "addressLine1":"V Parku 2308/10",
                "addressLine2":"addres2",
                "addressLine3":"addres3",
                "countyName":"Central Bohemia",
                "provinceName":"Central Bohemia",
                "countryName":"Czech Republic"
             },
             "contactInformation":{
                "email":"that@before.de",
                "phone":"+1123456789",
                "mobilePhone":"+60112345678",
                "companyName":"Company Name",
                "fullName":"John Brew"
             },
             "registrationNumbers":[
                {
                   "typeCode":"VAT",
                   "number":"CZ123456789",
                   "issuerCountryCode":"CZ"
                }
             ],
             "bankDetails":[
                {
                   "name":"Russian Bank Name",
                   "settlementLocalCurrency":"RUB",
                   "settlementForeignCurrency":"USD"
                }
             ],
             "typeCode":"business"
          },
          "exporterDetails":{
             "postalAddress":{
                "postalCode":"14800",
                "cityName":"Prague",
                "countryCode":"CZ",
                "provinceCode":"CZ",
                "addressLine1":"V Parku 2308/10",
                "addressLine2":"addres2",
                "addressLine3":"addres3",
                "countyName":"Central Bohemia",
                "provinceName":"Central Bohemia",
                "countryName":"Czech Republic"
             },
             "contactInformation":{
                "email":"that@before.de",
                "phone":"+1123456789",
                "mobilePhone":"+60112345678",
                "companyName":"Company Name",
                "fullName":"John Brew"
             },
             "registrationNumbers":[
                {
                   "typeCode":"VAT",
                   "number":"CZ123456789",
                   "issuerCountryCode":"CZ"
                }
             ],
             "bankDetails":[
                {
                   "name":"Russian Bank Name",
                   "settlementLocalCurrency":"RUB",
                   "settlementForeignCurrency":"USD"
                }
             ],
             "typeCode":"business"
          },
          "sellerDetails":{
             "postalAddress":{
                "postalCode":"14800",
                "cityName":"Prague",
                "countryCode":"CZ",
                "provinceCode":"CZ",
                "addressLine1":"V Parku 2308/10",
                "addressLine2":"addres2",
                "addressLine3":"addres3",
                "countyName":"Central Bohemia",
                "provinceName":"Central Bohemia",
                "countryName":"Czech Republic"
             },
             "contactInformation":{
                "email":"that@before.de",
                "phone":"+1123456789",
                "mobilePhone":"+60112345678",
                "companyName":"Company Name",
                "fullName":"John Brew"
             },
             "registrationNumbers":[
                {
                   "typeCode":"VAT",
                   "number":"CZ123456789",
                   "issuerCountryCode":"CZ"
                }
             ],
             "bankDetails":[
                {
                   "name":"Russian Bank Name",
                   "settlementLocalCurrency":"RUB",
                   "settlementForeignCurrency":"USD"
                }
             ],
             "typeCode":"business"
          },
          "payerDetails":{
             "postalAddress":{
                "postalCode":"14800",
                "cityName":"Prague",
                "countryCode":"CZ",
                "provinceCode":"CZ",
                "addressLine1":"V Parku 2308/10",
                "addressLine2":"addres2",
                "addressLine3":"addres3",
                "countyName":"Central Bohemia",
                "provinceName":"Central Bohemia",
                "countryName":"Czech Republic"
             },
             "contactInformation":{
                "email":"that@before.de",
                "phone":"+1123456789",
                "mobilePhone":"+60112345678",
                "companyName":"Company Name",
                "fullName":"John Brew"
             },
             "registrationNumbers":[
                {
                   "typeCode":"VAT",
                   "number":"CZ123456789",
                   "issuerCountryCode":"CZ"
                }
             ],
             "bankDetails":[
                {
                   "name":"Russian Bank Name",
                   "settlementLocalCurrency":"RUB",
                   "settlementForeignCurrency":"USD"
                }
             ],
             "typeCode":"business"
          },
          "ultimateConsigneeDetails":{
             "postalAddress":{
                "postalCode":"14800",
                "cityName":"Prague",
                "countryCode":"CZ",
                "provinceCode":"CZ",
                "addressLine1":"V Parku 2308/10",
                "addressLine2":"addres2",
                "addressLine3":"addres3",
                "countyName":"Central Bohemia",
                "provinceName":"Central Bohemia",
                "countryName":"Czech Republic"
             },
             "contactInformation":{
                "email":"that@before.de",
                "phone":"+1123456789",
                "mobilePhone":"+60112345678",
                "companyName":"Company Name",
                "fullName":"John Brew"
             },
             "registrationNumbers":[
                {
                   "typeCode":"VAT",
                   "number":"CZ123456789",
                   "issuerCountryCode":"CZ"
                }
             ],
             "bankDetails":{
                "typeCode":"VAT",
                "number":"CZ123456789",
                "issuerCountryCode":"CZ"
             },
             "typeCode":"business"
          },
          "brokerDetails":{
             "postalAddress":{
                "postalCode":"14800",
                "cityName":"Prague",
                "countryCode":"CZ",
                "provinceCode":"CZ",
                "addressLine1":"V Parku 2308/10",
                "addressLine2":"addres2",
                "addressLine3":"addres3",
                "countyName":"Central Bohemia",
                "provinceName":"Central Bohemia",
                "countryName":"Czech Republic"
             },
             "contactInformation":{
                "email":"that@before.de",
                "phone":"+1123456789",
                "mobilePhone":"+60112345678",
                "companyName":"Company Name",
                "fullName":"John Brew"
             },
             "registrationNumbers":[
                {
                   "typeCode":"VAT",
                   "number":"CZ123456789",
                   "issuerCountryCode":"CZ"
                }
             ],
             "bankDetails":{
                "typeCode":"VAT",
                "number":"CZ123456789",
                "issuerCountryCode":"CZ"
             },
             "typeCode":"business"
          }
       },
       "content":{
          "packages":[
             {
                "typeCode":"2BP",
                "weight":22.501,
                "dimensions":{
                   "length":15.001,
                   "width":15.001,
                   "height":40.001
                },
                "customerReferences":[
                   {
                      "value":"Customer reference",
                      "typeCode":"CU"
                   }
                ],
                "identifiers":[
                   {
                      "typeCode":"shipmentId",
                      "value":"1234567890",
                      "dataIdentifier":"00"
                   }
                ],
                "description":"Piece content description",
                "labelBarcodes":[
                   {
                      "position":"left",
                      "symbologyCode":"93",
                      "content": "test",
                      "textBelowBarcode":"text below left barcode"
                   }
                ],
                "labelText":[
                   {
                      "position":"left",
                      "caption":"text caption",
                      "value":"text value"
                   }
                ],
                "labelDescription":"bespoke label description",
                "referenceNumber":1
             }
          ],
          "isCustomsDeclarable":true,
          "declaredValue":150,
          "declaredValueCurrency":"CZK",
          "exportDeclaration":{
             "lineItems":[
                {
                   "number":1,
                   "description":"line item description",
                   "price":150,
                   "quantity":{
                      "value":1,
                      "unitOfMeasurement":"BOX"
                   },
                   "commodityCodes":[
                      {
                         "typeCode":"outbound",
                         "value":851713
                      }
                   ],
                   "exportReasonType":"permanent",
                   "manufacturerCountry":"CZ",
                   "weight":{
                      "netValue":10,
                      "grossValue":10
                   },
                   "isTaxesPaid":true,
                   "additionalInformation":null,
                   "customerReferences":[
                      {
                         "typeCode":"AFE",
                         "value":"custref123"
                      }
                   ],
                   "customsDocuments":[
                      {
                         "typeCode":"972",
                         "value":"custdoc456"
                      }
                   ],
                   "preCalculatedLineItemTotalValue":150
                }
             ],
             "invoice":{
                "number":"12345-ABC",
                "date":"2020-03-18",
                "signatureName":"Brewer",
                "signatureTitle":"Mr.",
                "signatureImage":"Base64 encoded image",
                "instructions":[
                   "string"
                ],
                "customerDataTextEntries":[
                   "string"
                ],
                "totalNetWeight":999999999999,
                "totalGrossWeight":999999999999,
                "customerReferences":[
                   {
                      "typeCode":"CU",
                      "value":"custref112"
                   }
                ],
                "termsOfPayment":"100 days",
                "indicativeCustomsValues":{
                   "importCustomsDutyValue":150.57,
                   "importTaxesValue":49.43,
                   "totalWithImportDutiesAndTaxes":[
                      350.57
                   ]
                },
                "preCalculatedTotalValues":{
                   "preCalculatedTotalGoodsValue":49.43,
                   "preCalculatedTotalInvoiceValue":150.57
                }
             },
             "remarks":[
                {
                   "value":"declaration remark"
                }
             ],
             "additionalCharges":[
                {
                   "value":10,
                   "caption":"fee",
                   "typeCode":"freight"
                }
             ],
             "destinationPortName":"port details",
             "placeOfIncoterm":"port of departure or destination details",
             "payerVATNumber":"12345ED",
             "recipientReference":"recipient reference",
             "exporter":{
                "id":"123",
                "code":"EXPCZ"
             },
             "packageMarks":"marks",
             "declarationNotes":[
                {
                   "value":"up to three declaration notes"
                }
             ],
             "exportReference":"export reference",
             "exportReason":"export reason",
             "exportReasonType":"permanent",
             "licenses":[
                {
                   "typeCode":"export",
                   "value":"license"
                }
             ],
             "shipmentType":"personal",
             "customsDocuments":[
                {
                   "typeCode":"972",
                   "value":"custdoc445"
                }
             ]
          },
          "description":"shipment description",
          "USFilingTypeValue":"12345",
          "incoterm":"DAP",
          "unitOfMeasurement":"metric"
       },
       "documentImages":[
          {
             "typeCode":"INV",
             "imageFormat":"PDF",
             "content":"{{{base64}}}"
          }
       ],
       "onDemandDelivery":{
          "deliveryOption":"servicepoint",
          "location":"front door",
          "specialInstructions":"ringe twice",
          "gateCode":"1234",
          "whereToLeave":"concierge",
          "neighbourName":"Mr.Dan",
          "neighbourHouseNumber":"777",
          "authorizerName":"Newman",
          "servicePointId":"SPL123",
          "requestedDeliveryDate":"2020-04-20"
       },
       "requestOndemandDeliveryURL":false,
       "shipmentNotification":[
          {
             "typeCode":"email",
             "receiverId":"receiver@email.com",
             "languageCode":"eng",
             "languageCountryCode":"UK",
             "bespokeMessage":"message to be included in the notification"
          }
       ],
       "prepaidCharges":[
          {
             "typeCode":"freight",
             "currency":"CZK",
             "value":200,
             "method":"cash"
          }
       ],
       "getTransliteratedResponse":false,
       "estimatedDeliveryDate":{
          "isRequested":false,
          "typeCode":"QDDC"
       },
       "getAdditionalInformation":[
          {
             "typeCode":"pickupDetails",
             "isRequested":true
          }
       ],
       "parentShipment":{
          "productCode":"s",
          "packagesCount":1
       }
    }
    """;

var request = JsonConvert.DeserializeObject<CreateShipmentRequestModel>(shipment2)!;

//Test(shipment2);

var client = new MyDHLExpressClient(new DHLClientCredentials("dmD3ZkqFTbXx2kgCnma63PABaiJWBAdt", "MxZWCZrWHaEc6I1H"), false);

var voucherResponse = await client.CreateDHLShipmentAsync(request);

var trackResponse = await client.GetSingleDHLShipmentAsync(voucherResponse.Result.ShipmentTrackingNumber, new TrackSingleShipmentAPIArgs());

var json = $$$"""
{
  "locations": [
    {
      "url": "/locations/8003-4103535",
      "location": {
        "ids": [
          {
            "locationId": "8003-4103535",
            "provider": "parcel"
          }
        ],
        "keyword": "Postfiliale",
        "keywordId": "443",
        "type": "servicepoint",
        "leanLocker": false
      },
      "name": "B+B Tabakwaren",
      "distance": 255,
      "place": {
        "address": {
          "countryCode": "DE",
          "postalCode": "53113",
          "addressLocality": "Bonn",
          "streetAddress": "Charles-de-Gaulle-Str. 20"
        },
        "geo": {
          "latitude": 53.5512589,
          "longitude": 10.0023976
        },
        "containedInPlace": {
          "name": "Lidl Markt"
        }
      },
      "openingHours": [
        {
          "opens": "09:00:00",
          "closes": "19:00:00",
          "dayOfWeek": "https://schema.org/Monday"
        },
        {
          "opens": "09:00:00",
          "closes": "19:00:00",
          "dayOfWeek": "https://schema.org/Tuesday"
        },
        {
          "opens": "09:00:00",
          "closes": "19:00:00",
          "dayOfWeek": "https://schema.org/Wednesday"
        },
        {
          "opens": "09:00:00",
          "closes": "19:00:00",
          "dayOfWeek": "https://schema.org/Thursday"
        },
        {
          "opens": "09:00:00",
          "closes": "19:00:00",
          "dayOfWeek": "https://schema.org/Friday"
        },
        {
          "opens": "09:00:00",
          "closes": "19:00:00",
          "dayOfWeek": "https://schema.org/Saturday"
        },
        {
          "opens": "09:00:00",
          "closes": "19:00:00",
          "dayOfWeek": "https://schema.org/Sunday"
        }
      ],
      "closurePeriods": [],
      "serviceTypes": [
        "parcel:drop-off",
        "parcel:pick-up"
      ],
      "averageCapacityDayOfWeek": []
    },
    {
      "url": "/locations/8007-420095227",
      "location": {
        "ids": [
          {
            "locationId": "8007-420095227",
            "provider": "parcel"
          }
        ],
        "keyword": "DHL Packstation",
        "keywordId": "227",
        "type": "locker"
      },
      "name": "DHL Packstation 227",
      "distance": 473,
      "place": {
        "address": {
          "countryCode": "DE",
          "postalCode": "20095",
          "addressLocality": "Hamburg",
          "streetAddress": "Ballindamm 40"
        },
        "geo": {
          "latitude": 53.5516856,
          "longitude": 9.9952905
        }
      },
      "openingHours": [
        {
          "opens": "09:00:00",
          "closes": "19:00:00",
          "dayOfWeek": "https://schema.org/Monday"
        },
        {
          "opens": "09:00:00",
          "closes": "19:00:00",
          "dayOfWeek": "https://schema.org/Tuesday"
        },
        {
          "opens": "09:00:00",
          "closes": "19:00:00",
          "dayOfWeek": "https://schema.org/Wednesday"
        },
        {
          "opens": "09:00:00",
          "closes": "19:00:00",
          "dayOfWeek": "https://schema.org/Thursday"
        },
        {
          "opens": "09:00:00",
          "closes": "19:00:00",
          "dayOfWeek": "https://schema.org/Friday"
        },
        {
          "opens": "09:00:00",
          "closes": "19:00:00",
          "dayOfWeek": "https://schema.org/Saturday"
        },
        {
          "opens": "09:00:00",
          "closes": "19:00:00",
          "dayOfWeek": "https://schema.org/Sunday"
        }
      ],
      "closurePeriods": [],
      "serviceTypes": [
        "parcel:drop-off-unregistered",
        "parcel:pick-up-registered"
      ],
      "averageCapacityDayOfWeek": [
        {
          "dayOfWeek": "Monday",
          "capacity": "very-low"
        },
        {
          "dayOfWeek": "Tuesday",
          "capacity": "low"
        },
        {
          "dayOfWeek": "Wednesday",
          "capacity": "high"
        },
        {
          "dayOfWeek": "Thursday",
          "capacity": "high"
        },
        {
          "dayOfWeek": "Friday",
          "capacity": "low"
        },
        {
          "dayOfWeek": "Saturday",
          "capacity": "very-low"
        },
        {
          "dayOfWeek": "Sunday",
          "capacity": "very-low"
        }
      ]
    }
  ]
}
""";

//GetMissingJsonProperties<CreateShipmentRequestModel>(json);

//static IEnumerable<string> GetMissingJsonProperties<T>(string json)
//{
//    var propertiesOfType = typeof(T).GetProperties()
//        .Select(x => x.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName)
//        .Distinct()
//        .Where(x => x is not null)
//        .ToList();

//    var missingProperties = new List<string>();

//    foreach (var child in (JObject)JsonConvert.DeserializeObject(json)!)
//    {
//        if (!propertiesOfType.Contains(child.Key))
//        {
//            missingProperties.Add(child.Key);
//        }
//    }

//    return missingProperties;
//}

var shipment = JsonConvert.DeserializeObject<ServicePointLocationByAddressResponseModel>(json);

var t = typeof(CreateShipmentRequestModel);

var dictionary = new Dictionary<Type, IEnumerable<string>>();

foreach (var type in AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes().Where(x => x.Name.EndsWith("RequestModel") || x.Name.EndsWith("ResponseModel"))))
{
    var missing = GetMissingJsonConverters(type);

    if (missing.IsNullOrEmpty())
        continue;

    dictionary.Add(type, missing);
}

var sbBuilder = new StringBuilder();

foreach (var map in dictionary)
{
    sbBuilder.AppendLine(map.Key + ":" + map.Value.AggregateString());
}

var s = sbBuilder.ToString();

Console.ReadLine();

async void Test(string b)
{
    var client = new HttpClient();
    var request = new HttpRequestMessage
    {
        Method = HttpMethod.Post,
        RequestUri = new Uri("https://api-mock.dhl.com/mydhlapi/shipments"),
        Headers =
        {
            { "Message-Reference", Guid.NewGuid().ToString() },
            { "Message-Reference-Date", DateTimeOffset.UtcNow.ToString("ddd, dd MMM yyyy hh:mm:ss", CultureInfo.InvariantCulture) + " GMT" },
            { "Authorization", "Basic ZG1EM1prcUZUYlh4MmtnQ25tYTYzUEFCYWlKV0JBZHQ6TXhaV0NacldIYUVjNkkxSA==" },
        },
        Content = new StringContent(b)
        {
            Headers =
            {
                ContentType = new MediaTypeHeaderValue("application/json")
            }
        }
    };
    using (var response = await client.SendAsync(request))
    {
        response.EnsureSuccessStatusCode();
        var body = await response.Content.ReadAsStringAsync();
        Console.WriteLine(body);
    }
}

IEnumerable<string> GetMissingJsonConverters(Type type)
{
    return type.GetProperties()
        .Where(x => x.PropertyType.IsEnum || (x.PropertyType.IsGenericType && x.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) && x.PropertyType.GetGenericArguments()[0].IsEnum))
        .Where(x => x.GetCustomAttribute<JsonConverterAttribute>() is null)
        .Select(x => x.Name)
        .ToList();
}

//var name = countryCode.ToLocalizedString();

//var sb = new StringBuilder();

//foreach (var enumValue in Enum.GetValues<CountryCode>())
//{
//    sb.AppendLine($"{{ {nameof(CountryCode)}.{enumValue}, \"{enumValue.ToLocalizedString()}\" }},");
//}

//foreach (var enumValue in Enum.GetValues<LanguageCode>())
//{
//    sb.AppendLine($"{{ {nameof(LanguageCode)}.{enumValue}, \" {enumValue.ToString().ToLower()} \" }},");
//}

//var r = sb.ToString();

Console.ReadLine();
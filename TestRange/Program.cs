// See https://aka.ms/new-console-template for more information
using DHLClient;
using Newtonsoft.Json;
using System.Reflection;
using System.Text;

Console.WriteLine("Hello, World!");

var pairs = DHLClientConstants.LanguageCodeToStringMapper;

var countryCode = CountryCode.AD;

//var client = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DHLClientCredentials.txt");

var client = new MyDHLExpressClient(new DHLClientCredentials("dmD3ZkqFTbXx2kgCnma63PABaiJWBAdt", "MxZWCZrWHaEc6I1H"), true);

//var shipment = new CreateShipmentRequestModel()
//{
//    Pickup = new ShipmentPickupRequestModel()
//    {
//        IsRequested = true,
//        CloseTime = 18:00,
//        Location = "Reception",
//        SpecialInstructions = new List<ShipmentSpecialInstructionRequestModel>()
//        {
//           new ShipmentSpecialInstructionRequestModel()
//           {
//               Value = "Παρακαλώ χτυπήστε κουδούνι"
//           }
//        },

//        PickupDetails = new ShipmentPickupDetailRequestModel()
//        {
//            PostalCode = "59032",
//            CityName = "Platy",
//            CountryCode = CountryCode.GR,
//            ProvinceCode = "GR",
//            AddressLine1 = "Anoikseos 20",
//            CountyName = "Hmathia",
//            ProvinceName = "Hmathia",
//            CountryName = "Greece"
//        },

//        ProductCode = "D",
//        LocalProductCode = "D",
//        GetRateEstimates = false,
//    }
//};

var json = $$"""
{
  "plannedShipDate": "2020-04-20",
  "accounts": [
    {
      "typeCode": "shipper",
      "number": "123456789"
    }
  ],
  "content": {
    "exportDeclaration": [
      {
        "lineItems": [
          {
            "number": 1,
            "description": "line item description",
            "price": 150,
            "quantity": {
              "value": 1,
              "unitOfMeasurement": "BOX"
            },
            "commodityCodes": [
              {
                "typeCode": "outbound",
                "value": "851713"
              }
            ],
            "exportReasonType": "permanent",
            "manufacturerCountry": "CZ",
            "weight": {
              "netValue": 10,
              "grossValue": 10
            },
            "isTaxesPaid": true,
            "customerReferences": [
              {
                "typeCode": "AFE",
                "value": "customerref1"
              }
            ],
            "customsDocuments": [
              {
                "typeCode": "972",
                "value": "custdoc456"
              }
            ],
            "preCalculatedLineItemTotalValue": 150
          }
        ],
        "invoice": {
          "number": "12345-ABC",
          "date": "2021-03-18",
          "function": "import",
          "customerReferences": [
            {
              "typeCode": "CU",
              "value": "custref112"
            }
          ],
          "indicativeCustomsValues": {
            "importCustomsDutyValue": 150.57,
            "importTaxesValue": 49.43,
            "totalWithImportDutiesAndTaxes": 350.57
          },
          "preCalculatedTotalValues": {
            "preCalculatedTotalGoodsValue": 49.43,
            "preCalculatedTotalInvoiceValue": 150.57
          }
        },
        "remarks": [
          {
            "value": "declaration remark"
          }
        ],
        "additionalCharges": [
          {
            "value": 10,
            "typeCode": "admin"
          }
        ],
        "placeOfIncoterm": "port of departure or destination details",
        "recipientReference": "recipient reference",
        "exporter": {
          "id": "123",
          "code": "EXPCZ"
        },
        "exportReasonType": "permanent",
        "shipmentType": "personal",
        "customsDocuments": [
          {
            "typeCode": "972",
            "value": "custdoc445"
          }
        ],
        "incoterm": "DAP"
      }
    ],
    "currency": "EUR",
    "unitOfMeasurement": "metric"
  },
  "outputImageProperties": {
    "imageOptions": [
      {
        "typeCode": "invoice",
        "templateName": "COMMERCIAL_INVOICE_P_10",
        "isRequested": true
      }
    ]
  },
  "customerDetails": {
    "sellerDetails": {
      "postalAddress": {
        "postalCode": "14800",
        "cityName": "Prague",
        "countryCode": "CZ",
        "provinceCode": "CZ",
        "addressLine1": "V Parku 2308/10",
        "addressLine2": "addres2",
        "addressLine3": "addres3",
        "countyName": "Central Bohemia"
      },
      "contactInformation": {
        "email": "that@before.de",
        "phone": "+1123456789",
        "mobilePhone": "+60112345678",
        "companyName": "Company Name",
        "fullName": "John Brew"
      },
      "typeCode": "business",
      "registrationNumbers": [
        {
          "typeCode": "VAT",
          "number": "CZ123456789",
          "issuerCountryCode": "CZ"
        }
      ]
    },
    "buyerDetails": {
      "postalAddress": {
        "postalCode": "14800",
        "cityName": "Prague",
        "countryCode": "CZ",
        "provinceCode": "CZ",
        "addressLine1": "V Parku 2308/10",
        "addressLine2": "addres2",
        "addressLine3": "addres3",
        "countyName": "Central Bohemia"
      },
      "contactInformation": {
        "email": "that@before.de",
        "phone": "+1123456789",
        "mobilePhone": "+60112345678",
        "companyName": "Company Name",
        "fullName": "John Brew"
      },
      "registrationNumbers": [
        {
          "typeCode": "VAT",
          "number": "CZ123456789",
          "issuerCountryCode": "CZ"
        }
      ],
      "typeCode": "business"
    },
    "importerDetails": {
      "postalAddress": {
        "postalCode": "14800",
        "cityName": "Prague",
        "countryCode": "CZ",
        "provinceCode": "CZ",
        "addressLine1": "V Parku 2308/10",
        "addressLine2": "addres2",
        "addressLine3": "addres3",
        "countyName": "Central Bohemia"
      },
      "contactInformation": {
        "email": "that@before.de",
        "phone": "+1123456789",
        "mobilePhone": "+60112345678",
        "companyName": "Company Name",
        "fullName": "John Brew"
      },
      "registrationNumbers": [
        {
          "typeCode": "VAT",
          "number": "CZ123456789",
          "issuerCountryCode": "CZ"
        }
      ],
      "typeCode": "business"
    },
    "exporterDetails": {
      "postalAddress": {
        "postalCode": "14800",
        "cityName": "Prague",
        "countryCode": "CZ",
        "provinceCode": "CZ",
        "addressLine1": "V Parku 2308/10",
        "addressLine2": "addres2",
        "addressLine3": "addres3",
        "countyName": "Central Bohemia"
      },
      "contactInformation": {
        "email": "that@before.de",
        "phone": "+1123456789",
        "mobilePhone": "+60112345678",
        "companyName": "Company Name",
        "fullName": "John Brew"
      },
      "registrationNumbers": [
        {
          "typeCode": "VAT",
          "number": "CZ123456789",
          "issuerCountryCode": "CZ"
        }
      ],
      "typeCode": "business"
    },
    "ultimateConsigneeDetails": {
      "postalAddress": {
        "postalCode": "14800",
        "cityName": "Prague",
        "countryCode": "CZ",
        "provinceCode": "CZ",
        "addressLine1": "V Parku 2308/10",
        "addressLine2": "addres2",
        "addressLine3": "addres3",
        "countyName": "Central Bohemia"
      },
      "contactInformation": {
        "email": "that@before.de",
        "phone": "+1123456789",
        "mobilePhone": "+60112345678",
        "companyName": "Company Name",
        "fullName": "John Brew"
      },
      "typeCode": "business",
      "registrationNumbers": [
        {
          "typeCode": "VAT",
          "number": "CZ123456789",
          "issuerCountryCode": "CZ"
        }
      ]
    },
    "brokerDetails": {
      "postalAddress": {
        "postalCode": "14800",
        "cityName": "Prague",
        "countryCode": "CZ",
        "provinceCode": "CZ",
        "addressLine1": "V Parku 2308/10",
        "addressLine2": "addres2",
        "addressLine3": "addres3",
        "countyName": "Central Bohemia"
      },
      "contactInformation": {
        "email": "that@before.de",
        "phone": "+1123456789",
        "mobilePhone": "+60112345678",
        "companyName": "Company Name",
        "fullName": "John Brew"
      },
      "typeCode": "business",
      "registrationNumbers": [
        {
          "typeCode": "VAT",
          "number": "CZ123456789",
          "issuerCountryCode": "CZ"
        }
      ]
    }
  }
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

var shipment = JsonConvert.DeserializeObject<UploadInvoiceRequestModel>(json);

var t = typeof(RatingRequestModel);

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
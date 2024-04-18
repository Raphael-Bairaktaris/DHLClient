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

var json = $$"""
{
  "url": "/track/shipments?trackingNumber=GMDBD8E9CCE94842E495B7&limit=10",
  "firstUrl": "/track/shipments?trackingNumber=GMDBD8E9CCE94842E495B7&limit=10",
  "prevUrl": "/track/shipments?trackingNumber=GMDBD8E9CCE94842E495B7&limit=10",
  "nextUrl": "/track/shipments?trackingNumber=GMDBD8E9CCE94842E495B7&limit=10",
  "lastUrl": "/track/shipments?trackingNumber=GMDBD8E9CCE94842E495B7&limit=10",
  "shipments": [
    {
      "id": "GMDBD8E9CCE94842E495B7",
      "service": "ecommerce",
      "origin": {
        "address": {
          "countryCode": "US",
          "postalCode": "84003",
          "addressLocality": "AMERICAN FORK"
        }
      },
      "destination": {
        "address": {
          "countryCode": "GB",
          "postalCode": "S87FA",
          "addressLocality": "SHEFFIELD"
        }
      },
      "status": {
        "timestamp": "2023-01-29T16:02:00",
        "location": {
          "address": {
            "countryCode": "GB",
            "postalCode": "HEATHROW",
            "addressLocality": "HEATHROW, GB"
          }
        },
        "statusCode": "transit",
        "status": "ARRIVED AT CUSTOMS"
      },
      "details": {
        "product": {
          "productName": "DHL Parcel Intl Standard"
        },
        "weight": {
          "value": 0.831,
          "unitText": "LB"
        },
        "references": [
          {
            "number": "GMDBD8E9CCE94842E495B7",
            "type": "customer-confirmation-number"
          },
          {
            "number": "2042200157621303",
            "type": "ecommerce-number"
          },
          {
            "number": "H01PQA0010751022",
            "type": "local-tracking-number"
          }
        ]
      },
      "events": [
        {
          "timestamp": "2023-01-29T16:02:00",
          "location": {
            "address": {
              "countryCode": "GB",
              "postalCode": "HEATHROW",
              "addressLocality": "HEATHROW, GB"
            }
          },
          "statusCode": "transit",
          "status": "ARRIVED AT CUSTOMS"
        },
        {
          "timestamp": "2023-01-23T08:52:15",
          "location": {
            "address": {
              "countryCode": "US",
              "postalCode": "90601",
              "addressLocality": "Whittier, CA, US"
            }
          },
          "statusCode": "unknown",
          "status": "SCANNED INTO SACK/CONTAINER"
        },
        {
          "timestamp": "2023-01-23T08:52:14",
          "location": {
            "address": {
              "countryCode": "US",
              "postalCode": "90601",
              "addressLocality": "Whittier, CA, US"
            }
          },
          "statusCode": "transit",
          "status": "PROCESSING COMPLETED AT ORIGIN"
        },
        {
          "timestamp": "2023-01-23T08:50:36",
          "location": {
            "address": {
              "countryCode": "US",
              "postalCode": "90601",
              "addressLocality": "Whittier, CA, US"
            }
          },
          "statusCode": "unknown",
          "status": "CLOSE BAG"
        },
        {
          "timestamp": "2023-01-20T14:04:18",
          "location": {
            "address": {
              "countryCode": "US",
              "postalCode": "90601",
              "addressLocality": "Whittier, CA, US"
            }
          },
          "statusCode": "transit",
          "status": "PROCESSED"
        },
        {
          "timestamp": "2023-01-20T10:21:25",
          "statusCode": "pre-transit",
          "status": "DHL ECOMMERCE CURRENTLY AWAITING SHIPMENT AND TRACKING WILL BE UPDATED WHEN RECEIVED"
        },
        {
          "timestamp": "2023-01-18T09:39:28",
          "location": {
            "address": {
              "countryCode": "US",
              "postalCode": "90601",
              "addressLocality": "Whittier, CA, US"
            }
          },
          "statusCode": "transit",
          "status": "PACKAGE RECEIVED AT DHL ECOMMERCE DISTRIBUTION CENTER"
        },
        {
          "timestamp": "2023-01-11T11:58:34",
          "statusCode": "unknown",
          "status": "LABEL CREATED"
        }
      ]
    }
  ],
  "possibleAdditionalShipmentsUrl": [
    "/track/shipments?trackingNumber=GMDBD8E9CCE94842E495B7&service=freight",
    "/track/shipments?trackingNumber=GMDBD8E9CCE94842E495B7&service=dgf",
    "/track/shipments?trackingNumber=GMDBD8E9CCE94842E495B7&service=parcel-de",
    "/track/shipments?trackingNumber=GMDBD8E9CCE94842E495B7&service=parcel-nl",
    "/track/shipments?trackingNumber=GMDBD8E9CCE94842E495B7&service=parcel-pl",
    "/track/shipments?trackingNumber=GMDBD8E9CCE94842E495B7&service=express",
    "/track/shipments?trackingNumber=GMDBD8E9CCE94842E495B7&service=post-de",
    "/track/shipments?trackingNumber=GMDBD8E9CCE94842E495B7&service=sameday",
    "/track/shipments?trackingNumber=GMDBD8E9CCE94842E495B7&service=parcel-uk",
    "/track/shipments?trackingNumber=GMDBD8E9CCE94842E495B7&service=ecommerce-apac",
    "/track/shipments?trackingNumber=GMDBD8E9CCE94842E495B7&service=ecommerce-europe",
    "/track/shipments?trackingNumber=GMDBD8E9CCE94842E495B7&service=post-international"
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

var shipment = JsonConvert.DeserializeObject<ShipmentResponseModel>(json);

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
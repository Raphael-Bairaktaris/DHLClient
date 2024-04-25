// See https://aka.ms/new-console-template for more information
using DHLClient;
using Newtonsoft.Json;
using System.Reflection;
using System.Text;

Console.WriteLine("Hello, World!");

var pairs = DHLClientConstants.LanguageCodeToStringMapper;

//var countryCode = CountryCode.AD;

//var client = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DHLClientCredentials.txt");

var client = new MyDHLExpressClient(new DHLClientCredentials("dmD3ZkqFTbXx2kgCnma63PABaiJWBAdt", "MxZWCZrWHaEc6I1H"), true);

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
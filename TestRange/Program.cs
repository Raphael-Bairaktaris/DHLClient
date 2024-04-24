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
  "referenceData": [
    {
      "datasetName": "country",
      "data": [
        [
          {
            "attribute": "countryCode",
            "value": "GD"
          },
          {
            "attribute": "countryName",
            "value": "GRENADA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "AD"
          },
          {
            "attribute": "countryName",
            "value": "ANDORRA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "BG"
          },
          {
            "attribute": "countryName",
            "value": "BULGARIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "CK"
          },
          {
            "attribute": "countryName",
            "value": "COOK ISLANDS"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "AG"
          },
          {
            "attribute": "countryName",
            "value": "ANTIGUA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "AL"
          },
          {
            "attribute": "countryName",
            "value": "ALBANIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "AU"
          },
          {
            "attribute": "countryName",
            "value": "AUSTRALIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "S"
          },
          {
            "attribute": "divisionTypeName",
            "value": "STATE"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "AR"
          },
          {
            "attribute": "countryName",
            "value": "ARGENTINA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "BD"
          },
          {
            "attribute": "countryName",
            "value": "BANGLADESH"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "C"
          },
          {
            "attribute": "divisionTypeName",
            "value": "County"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "AT"
          },
          {
            "attribute": "countryName",
            "value": "AUSTRIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "90"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "BT"
          },
          {
            "attribute": "countryName",
            "value": "BHUTAN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "30"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "DZ"
          },
          {
            "attribute": "countryName",
            "value": "ALGERIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "ME"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "GP"
          },
          {
            "attribute": "countryName",
            "value": "GUADELOUPE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "IR"
          },
          {
            "attribute": "countryName",
            "value": "IRAN (ISLAMIC REPUBLIC OF)"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "ME"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "JP"
          },
          {
            "attribute": "countryName",
            "value": "JAPAN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "S"
          },
          {
            "attribute": "divisionTypeName",
            "value": "STATE"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "30"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "LR"
          },
          {
            "attribute": "countryName",
            "value": "LIBERIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "MA"
          },
          {
            "attribute": "countryName",
            "value": "MOROCCO"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "ME"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "NG"
          },
          {
            "attribute": "countryName",
            "value": "NIGERIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "PF"
          },
          {
            "attribute": "countryName",
            "value": "TAHITI"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "PT"
          },
          {
            "attribute": "countryName",
            "value": "PORTUGAL"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "0"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "RU"
          },
          {
            "attribute": "countryName",
            "value": "RUSSIAN FEDERATION, THE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "210"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "SV"
          },
          {
            "attribute": "countryName",
            "value": "EL SALVADOR"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "30"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "TD"
          },
          {
            "attribute": "countryName",
            "value": "CHAD"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "TH"
          },
          {
            "attribute": "countryName",
            "value": "THAILAND"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "VE"
          },
          {
            "attribute": "countryName",
            "value": "VENEZUELA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "90"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "VI"
          },
          {
            "attribute": "countryName",
            "value": "VIRGIN ISLANDS (US)"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "WS"
          },
          {
            "attribute": "countryName",
            "value": "SAMOA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "XC"
          },
          {
            "attribute": "countryName",
            "value": "CURACAO"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "IL"
          },
          {
            "attribute": "countryName",
            "value": "ISRAEL"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "180"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "UZ"
          },
          {
            "attribute": "countryName",
            "value": "UZBEKISTAN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "C"
          },
          {
            "attribute": "divisionTypeName",
            "value": "County"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "AS"
          },
          {
            "attribute": "countryName",
            "value": "AMERICAN SAMOA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "AE"
          },
          {
            "attribute": "countryName",
            "value": "UNITED ARAB EMIRATES"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "C"
          },
          {
            "attribute": "divisionTypeName",
            "value": "County"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "ME"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "BJ"
          },
          {
            "attribute": "countryName",
            "value": "BENIN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "AI"
          },
          {
            "attribute": "countryName",
            "value": "ANGUILLA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "BF"
          },
          {
            "attribute": "countryName",
            "value": "BURKINA FASO"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "DO"
          },
          {
            "attribute": "countryName",
            "value": "DOMINICAN REPUBLIC"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "JE"
          },
          {
            "attribute": "countryName",
            "value": "JERSEY"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "LV"
          },
          {
            "attribute": "countryName",
            "value": "LATVIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "MP"
          },
          {
            "attribute": "countryName",
            "value": "COMMONWEALTH NO. MARIANA ISLANDS"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "NA"
          },
          {
            "attribute": "countryName",
            "value": "NAMIBIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "SO"
          },
          {
            "attribute": "countryName",
            "value": "SOMALIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "XS"
          },
          {
            "attribute": "countryName",
            "value": "SOMALILAND, REP OF (NORTH SOMALIA)"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "TL"
          },
          {
            "attribute": "countryName",
            "value": "TIMOR LESTE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "ME"
          },
          {
            "attribute": "countryName",
            "value": "MONTENEGRO, REPUBLIC OF"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "GH"
          },
          {
            "attribute": "countryName",
            "value": "GHANA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "GM"
          },
          {
            "attribute": "countryName",
            "value": "GAMBIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "JO"
          },
          {
            "attribute": "countryName",
            "value": "JORDAN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "ME"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "PH"
          },
          {
            "attribute": "countryName",
            "value": "PHILIPPINES, THE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "C"
          },
          {
            "attribute": "divisionTypeName",
            "value": "County"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "PK"
          },
          {
            "attribute": "countryName",
            "value": "PAKISTAN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "TR"
          },
          {
            "attribute": "countryName",
            "value": "TURKEY"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "US"
          },
          {
            "attribute": "countryName",
            "value": "UNITED STATES OF AMERICA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "S"
          },
          {
            "attribute": "divisionTypeName",
            "value": "STATE"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "ZM"
          },
          {
            "attribute": "countryName",
            "value": "ZAMBIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "ZW"
          },
          {
            "attribute": "countryName",
            "value": "ZIMBABWE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "AZ"
          },
          {
            "attribute": "countryName",
            "value": "AZERBAIJAN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "C"
          },
          {
            "attribute": "divisionTypeName",
            "value": "County"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "210"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "UA"
          },
          {
            "attribute": "countryName",
            "value": "UKRAINE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "S"
          },
          {
            "attribute": "divisionTypeName",
            "value": "STATE"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "ET"
          },
          {
            "attribute": "countryName",
            "value": "ETHIOPIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "HU"
          },
          {
            "attribute": "countryName",
            "value": "HUNGARY"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "IS"
          },
          {
            "attribute": "countryName",
            "value": "ICELAND"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "KM"
          },
          {
            "attribute": "countryName",
            "value": "COMOROS"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "LU"
          },
          {
            "attribute": "countryName",
            "value": "LUXEMBOURG"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "LY"
          },
          {
            "attribute": "countryName",
            "value": "LIBYA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "ME"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "NI"
          },
          {
            "attribute": "countryName",
            "value": "NICARAGUA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "NP"
          },
          {
            "attribute": "countryName",
            "value": "NEPAL"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "SL"
          },
          {
            "attribute": "countryName",
            "value": "SIERRA LEONE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "AM"
          },
          {
            "attribute": "countryName",
            "value": "ARMENIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "C"
          },
          {
            "attribute": "divisionTypeName",
            "value": "County"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "BN"
          },
          {
            "attribute": "countryName",
            "value": "BRUNEI"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "C"
          },
          {
            "attribute": "divisionTypeName",
            "value": "County"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "30"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "BZ"
          },
          {
            "attribute": "countryName",
            "value": "BELIZE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "CM"
          },
          {
            "attribute": "countryName",
            "value": "CAMEROON"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "DE"
          },
          {
            "attribute": "countryName",
            "value": "GERMANY"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "90"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "FI"
          },
          {
            "attribute": "countryName",
            "value": "FINLAND"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "GA"
          },
          {
            "attribute": "countryName",
            "value": "GABON"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "GL"
          },
          {
            "attribute": "countryName",
            "value": "GREENLAND"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "KN"
          },
          {
            "attribute": "countryName",
            "value": "ST. KITTS"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "PL"
          },
          {
            "attribute": "countryName",
            "value": "POLAND"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "SZ"
          },
          {
            "attribute": "countryName",
            "value": "SWAZILAND"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "TO"
          },
          {
            "attribute": "countryName",
            "value": "TONGA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "TV"
          },
          {
            "attribute": "countryName",
            "value": "TUVALU"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "XB"
          },
          {
            "attribute": "countryName",
            "value": "BONAIRE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "XN"
          },
          {
            "attribute": "countryName",
            "value": "NEVIS"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "XY"
          },
          {
            "attribute": "countryName",
            "value": "ST. BARTHELEMY"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "ZA"
          },
          {
            "attribute": "countryName",
            "value": "SOUTH AFRICA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "90"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "CZ"
          },
          {
            "attribute": "countryName",
            "value": "CZECH REPUBLIC, THE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "BR"
          },
          {
            "attribute": "countryName",
            "value": "BRAZIL"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "VA"
          },
          {
            "attribute": "countryName",
            "value": "VATICAN CITY STATE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "MR"
          },
          {
            "attribute": "countryName",
            "value": "MAURITANIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "ME"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "MZ"
          },
          {
            "attribute": "countryName",
            "value": "MOZAMBIQUE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "SK"
          },
          {
            "attribute": "countryName",
            "value": "SLOVAKIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "VC"
          },
          {
            "attribute": "countryName",
            "value": "ST. VINCENT"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "KZ"
          },
          {
            "attribute": "countryName",
            "value": "KAZAKHSTAN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "C"
          },
          {
            "attribute": "divisionTypeName",
            "value": "County"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "NU"
          },
          {
            "attribute": "countryName",
            "value": "NIUE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "BE"
          },
          {
            "attribute": "countryName",
            "value": "BELGIUM"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "90"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "BS"
          },
          {
            "attribute": "countryName",
            "value": "BAHAMAS"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "CF"
          },
          {
            "attribute": "countryName",
            "value": "CENTRAL AFRICAN REPUBLIC"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "CG"
          },
          {
            "attribute": "countryName",
            "value": "CONGO"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "FK"
          },
          {
            "attribute": "countryName",
            "value": "FALKLAND ISLANDS"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "JM"
          },
          {
            "attribute": "countryName",
            "value": "JAMAICA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "MM"
          },
          {
            "attribute": "countryName",
            "value": "MYANMAR"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "MS"
          },
          {
            "attribute": "countryName",
            "value": "MONTSERRAT"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "MV"
          },
          {
            "attribute": "countryName",
            "value": "MALDIVES"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "30"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "MY"
          },
          {
            "attribute": "countryName",
            "value": "MALAYSIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "30"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "NO"
          },
          {
            "attribute": "countryName",
            "value": "NORWAY"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "PA"
          },
          {
            "attribute": "countryName",
            "value": "PANAMA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "90"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "UY"
          },
          {
            "attribute": "countryName",
            "value": "URUGUAY"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "VG"
          },
          {
            "attribute": "countryName",
            "value": "VIRGIN ISLANDS (BRITISH)"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "XM"
          },
          {
            "attribute": "countryName",
            "value": "ST. MAARTEN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "YE"
          },
          {
            "attribute": "countryName",
            "value": "YEMEN, REPUBLIC OF"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "ME"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "MK"
          },
          {
            "attribute": "countryName",
            "value": "NORTH MACEDONIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "FM"
          },
          {
            "attribute": "countryName",
            "value": "MICRONESIA, FEDERATED STATES OF"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "BM"
          },
          {
            "attribute": "countryName",
            "value": "BERMUDA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "CA"
          },
          {
            "attribute": "countryName",
            "value": "CANADA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "P"
          },
          {
            "attribute": "divisionTypeName",
            "value": "PROVINCE"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "CV"
          },
          {
            "attribute": "countryName",
            "value": "CAPE VERDE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "DJ"
          },
          {
            "attribute": "countryName",
            "value": "DJIBOUTI"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "DK"
          },
          {
            "attribute": "countryName",
            "value": "DENMARK"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "EE"
          },
          {
            "attribute": "countryName",
            "value": "ESTONIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "EG"
          },
          {
            "attribute": "countryName",
            "value": "EGYPT"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "ME"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "GG"
          },
          {
            "attribute": "countryName",
            "value": "GUERNSEY"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "GI"
          },
          {
            "attribute": "countryName",
            "value": "GIBRALTAR"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "GT"
          },
          {
            "attribute": "countryName",
            "value": "GUATEMALA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "IT"
          },
          {
            "attribute": "countryName",
            "value": "ITALY"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "C"
          },
          {
            "attribute": "divisionTypeName",
            "value": "County"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "MO"
          },
          {
            "attribute": "countryName",
            "value": "MACAO SAR, CHINA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "NL"
          },
          {
            "attribute": "countryName",
            "value": "NETHERLANDS, THE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "PY"
          },
          {
            "attribute": "countryName",
            "value": "PARAGUAY"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "SB"
          },
          {
            "attribute": "countryName",
            "value": "SOLOMON ISLANDS"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "SE"
          },
          {
            "attribute": "countryName",
            "value": "SWEDEN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "C"
          },
          {
            "attribute": "divisionTypeName",
            "value": "County"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "SI"
          },
          {
            "attribute": "countryName",
            "value": "SLOVENIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "SR"
          },
          {
            "attribute": "countryName",
            "value": "SURINAME"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "SY"
          },
          {
            "attribute": "countryName",
            "value": "SYRIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "P"
          },
          {
            "attribute": "divisionTypeName",
            "value": "PROVINCE"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "ME"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "TC"
          },
          {
            "attribute": "countryName",
            "value": "TURKS AND CAICOS ISLANDS"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "TG"
          },
          {
            "attribute": "countryName",
            "value": "TOGO"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "VU"
          },
          {
            "attribute": "countryName",
            "value": "VANUATU"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "RS"
          },
          {
            "attribute": "countryName",
            "value": "SERBIA, REPUBLIC OF"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "KE"
          },
          {
            "attribute": "countryName",
            "value": "KENYA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "NE"
          },
          {
            "attribute": "countryName",
            "value": "NIGER"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "NZ"
          },
          {
            "attribute": "countryName",
            "value": "NEW ZEALAND"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "R"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country region"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "OM"
          },
          {
            "attribute": "countryName",
            "value": "OMAN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "ME"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "MD"
          },
          {
            "attribute": "countryName",
            "value": "MOLDOVA, REPUBLIC OF"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "C"
          },
          {
            "attribute": "divisionTypeName",
            "value": "County"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "210"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "PW"
          },
          {
            "attribute": "countryName",
            "value": "PALAU"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "FR"
          },
          {
            "attribute": "countryName",
            "value": "FRANCE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "GN"
          },
          {
            "attribute": "countryName",
            "value": "GUINEA REPUBLIC"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "GY"
          },
          {
            "attribute": "countryName",
            "value": "GUYANA (BRITISH)"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "IC"
          },
          {
            "attribute": "countryName",
            "value": "CANARY ISLANDS, THE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "A"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Autonomous community"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "IN"
          },
          {
            "attribute": "countryName",
            "value": "INDIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "C"
          },
          {
            "attribute": "divisionTypeName",
            "value": "County"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "SH"
          },
          {
            "attribute": "countryName",
            "value": "SAINT HELENA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "D"
          },
          {
            "attribute": "divisionTypeName",
            "value": "District"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "LT"
          },
          {
            "attribute": "countryName",
            "value": "LITHUANIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "PG"
          },
          {
            "attribute": "countryName",
            "value": "PAPUA NEW GUINEA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "P"
          },
          {
            "attribute": "divisionTypeName",
            "value": "PROVINCE"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "SG"
          },
          {
            "attribute": "countryName",
            "value": "SINGAPORE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "S"
          },
          {
            "attribute": "divisionTypeName",
            "value": "STATE"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "KP"
          },
          {
            "attribute": "countryName",
            "value": "KOREA, THE D.P.R OF (NORTH K.)"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "CN"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "IQ"
          },
          {
            "attribute": "countryName",
            "value": "IRAQ"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "ME"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "BA"
          },
          {
            "attribute": "countryName",
            "value": "BOSNIA AND HERZEGOVINA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "C"
          },
          {
            "attribute": "divisionTypeName",
            "value": "County"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "90"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "BO"
          },
          {
            "attribute": "countryName",
            "value": "BOLIVIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "CH"
          },
          {
            "attribute": "countryName",
            "value": "SWITZERLAND"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "CY"
          },
          {
            "attribute": "countryName",
            "value": "CYPRUS"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "FO"
          },
          {
            "attribute": "countryName",
            "value": "FAROE ISLANDS"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "SS"
          },
          {
            "attribute": "countryName",
            "value": "SOUTH SUDAN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "KY"
          },
          {
            "attribute": "countryName",
            "value": "CAYMAN ISLANDS"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "MC"
          },
          {
            "attribute": "countryName",
            "value": "MONACO"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "MG"
          },
          {
            "attribute": "countryName",
            "value": "MADAGASCAR"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "MQ"
          },
          {
            "attribute": "countryName",
            "value": "MARTINIQUE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "MU"
          },
          {
            "attribute": "countryName",
            "value": "MAURITIUS"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "MW"
          },
          {
            "attribute": "countryName",
            "value": "MALAWI"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "RE"
          },
          {
            "attribute": "countryName",
            "value": "REUNION, ISLAND OF"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "UG"
          },
          {
            "attribute": "countryName",
            "value": "UGANDA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "KG"
          },
          {
            "attribute": "countryName",
            "value": "KYRGYZSTAN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "C"
          },
          {
            "attribute": "divisionTypeName",
            "value": "County"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "210"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "BH"
          },
          {
            "attribute": "countryName",
            "value": "BAHRAIN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "ME"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "CL"
          },
          {
            "attribute": "countryName",
            "value": "CHILE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "CU"
          },
          {
            "attribute": "countryName",
            "value": "CUBA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "GB"
          },
          {
            "attribute": "countryName",
            "value": "UNITED KINGDOM"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "C"
          },
          {
            "attribute": "divisionTypeName",
            "value": "County"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "GQ"
          },
          {
            "attribute": "countryName",
            "value": "GUINEA-EQUATORIAL"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "LS"
          },
          {
            "attribute": "countryName",
            "value": "LESOTHO"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "MT"
          },
          {
            "attribute": "countryName",
            "value": "MALTA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "NR"
          },
          {
            "attribute": "countryName",
            "value": "NAURU, REPUBLIC OF"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "RW"
          },
          {
            "attribute": "countryName",
            "value": "RWANDA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "SA"
          },
          {
            "attribute": "countryName",
            "value": "SAUDI ARABIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "ME"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "VN"
          },
          {
            "attribute": "countryName",
            "value": "VIETNAM"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "XE"
          },
          {
            "attribute": "countryName",
            "value": "ST. EUSTATIUS"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "YT"
          },
          {
            "attribute": "countryName",
            "value": "MAYOTTE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "SM"
          },
          {
            "attribute": "countryName",
            "value": "SAN MARINO"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "BW"
          },
          {
            "attribute": "countryName",
            "value": "BOTSWANA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "DM"
          },
          {
            "attribute": "countryName",
            "value": "DOMINICA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "HT"
          },
          {
            "attribute": "countryName",
            "value": "HAITI"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "ID"
          },
          {
            "attribute": "countryName",
            "value": "INDONESIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "IE"
          },
          {
            "attribute": "countryName",
            "value": "IRELAND, REPUBLIC OF"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "C"
          },
          {
            "attribute": "divisionTypeName",
            "value": "County"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "KI"
          },
          {
            "attribute": "countryName",
            "value": "KIRIBATI"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "LA"
          },
          {
            "attribute": "countryName",
            "value": "LAO PEOPLES DEMOCRATIC REPUBLIC"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "PE"
          },
          {
            "attribute": "countryName",
            "value": "PERU"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "180"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "PR"
          },
          {
            "attribute": "countryName",
            "value": "PUERTO RICO"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "TW"
          },
          {
            "attribute": "countryName",
            "value": "TAIWAN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "AF"
          },
          {
            "attribute": "countryName",
            "value": "AFGHANISTAN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "ME"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "TM"
          },
          {
            "attribute": "countryName",
            "value": "TURKMENISTAN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "C"
          },
          {
            "attribute": "divisionTypeName",
            "value": "County"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "BI"
          },
          {
            "attribute": "countryName",
            "value": "BURUNDI"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "CN"
          },
          {
            "attribute": "countryName",
            "value": "CHINA, PEOPLES REPUBLIC"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "CN"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "ES"
          },
          {
            "attribute": "countryName",
            "value": "SPAIN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "0"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "FJ"
          },
          {
            "attribute": "countryName",
            "value": "FIJI"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "GF"
          },
          {
            "attribute": "countryName",
            "value": "FRENCH GUYANA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "GR"
          },
          {
            "attribute": "countryName",
            "value": "GREECE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "GU"
          },
          {
            "attribute": "countryName",
            "value": "GUAM"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "GW"
          },
          {
            "attribute": "countryName",
            "value": "GUINEA-BISSAU"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "KW"
          },
          {
            "attribute": "countryName",
            "value": "KUWAIT"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "ME"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "LC"
          },
          {
            "attribute": "countryName",
            "value": "ST. LUCIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "LI"
          },
          {
            "attribute": "countryName",
            "value": "LIECHTENSTEIN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "LK"
          },
          {
            "attribute": "countryName",
            "value": "SRI LANKA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "MH"
          },
          {
            "attribute": "countryName",
            "value": "MARSHALL ISLANDS"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "RO"
          },
          {
            "attribute": "countryName",
            "value": "ROMANIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "SC"
          },
          {
            "attribute": "countryName",
            "value": "SEYCHELLES"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "TZ"
          },
          {
            "attribute": "countryName",
            "value": "TANZANIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "CD"
          },
          {
            "attribute": "countryName",
            "value": "CONGO, THE DEMOCRATIC REPUBLIC OF"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "GE"
          },
          {
            "attribute": "countryName",
            "value": "GEORGIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "C"
          },
          {
            "attribute": "divisionTypeName",
            "value": "County"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "AW"
          },
          {
            "attribute": "countryName",
            "value": "ARUBA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "BB"
          },
          {
            "attribute": "countryName",
            "value": "BARBADOS"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "CI"
          },
          {
            "attribute": "countryName",
            "value": "COTE D IVOIRE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "ER"
          },
          {
            "attribute": "countryName",
            "value": "ERITREA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "HK"
          },
          {
            "attribute": "countryName",
            "value": "HONG KONG SAR, CHINA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "HN"
          },
          {
            "attribute": "countryName",
            "value": "HONDURAS"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "HR"
          },
          {
            "attribute": "countryName",
            "value": "CROATIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "KH"
          },
          {
            "attribute": "countryName",
            "value": "CAMBODIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "LB"
          },
          {
            "attribute": "countryName",
            "value": "LEBANON"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "ME"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "MX"
          },
          {
            "attribute": "countryName",
            "value": "MEXICO"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "180"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "NC"
          },
          {
            "attribute": "countryName",
            "value": "NEW CALEDONIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "QA"
          },
          {
            "attribute": "countryName",
            "value": "QATAR"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "ME"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "SN"
          },
          {
            "attribute": "countryName",
            "value": "SENEGAL"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "ST"
          },
          {
            "attribute": "countryName",
            "value": "SAO TOME AND PRINCIPE"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "BY"
          },
          {
            "attribute": "countryName",
            "value": "BELARUS"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "C"
          },
          {
            "attribute": "divisionTypeName",
            "value": "County"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "210"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "TJ"
          },
          {
            "attribute": "countryName",
            "value": "TAJIKISTAN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "C"
          },
          {
            "attribute": "divisionTypeName",
            "value": "County"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "KV"
          },
          {
            "attribute": "countryName",
            "value": "KOSOVO"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "EU"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "AO"
          },
          {
            "attribute": "countryName",
            "value": "ANGOLA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "CO"
          },
          {
            "attribute": "countryName",
            "value": "COLOMBIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "60"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "CR"
          },
          {
            "attribute": "countryName",
            "value": "COSTA RICA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "EC"
          },
          {
            "attribute": "countryName",
            "value": "ECUADOR"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "KR"
          },
          {
            "attribute": "countryName",
            "value": "KOREA, REPUBLIC OF (SOUTH K.)"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "AP"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          },
          {
            "attribute": "pickupWindowLeadTime",
            "value": "120"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "ML"
          },
          {
            "attribute": "countryName",
            "value": "MALI"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "MN"
          },
          {
            "attribute": "countryName",
            "value": "MONGOLIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "CN"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "SD"
          },
          {
            "attribute": "countryName",
            "value": "SUDAN"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "O"
          },
          {
            "attribute": "divisionTypeName",
            "value": "Country-use when no divtype identif"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "C"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City"
          },
          {
            "attribute": "regionCode",
            "value": "SB"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "TT"
          },
          {
            "attribute": "countryName",
            "value": "TRINIDAD AND TOBAGO"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "S"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "Suburb"
          },
          {
            "attribute": "regionCode",
            "value": "AM"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "LB"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "IN"
          }
        ],
        [
          {
            "attribute": "countryCode",
            "value": "TN"
          },
          {
            "attribute": "countryName",
            "value": "TUNISIA"
          },
          {
            "attribute": "divisionTypeCode",
            "value": "X"
          },
          {
            "attribute": "divisionTypeName",
            "value": "MIGRATION"
          },
          {
            "attribute": "postalLocationTypeCode",
            "value": "CP"
          },
          {
            "attribute": "postalLocationDescription",
            "value": "City Postcode"
          },
          {
            "attribute": "regionCode",
            "value": "ME"
          },
          {
            "attribute": "unitOfMeasureWeight",
            "value": "KG"
          },
          {
            "attribute": "unitOfMeasureDimension",
            "value": "CM"
          }
        ]
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

var shipment = JsonConvert.DeserializeObject<ReferenceDataResponseModel>(json);

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
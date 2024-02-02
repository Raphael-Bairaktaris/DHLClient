// See https://aka.ms/new-console-template for more information
using DHLClient;
using System.Text;

Console.WriteLine("Hello, World!");

var pairs = DHLClientConstants.LanguageCodeToStringMapper;

var countryCode = CountryCode.AD;

var name = countryCode.ToLocalizedString();

var sb = new StringBuilder();

foreach (var enumValue in Enum.GetValues<CountryCode>())
{
    sb.AppendLine($"{{ {nameof(CountryCode)}.{enumValue}, \"{enumValue.ToLocalizedString()}\" }},");
}

foreach (var enumValue in Enum.GetValues<LanguageCode>())
{
    sb.AppendLine($"{{ {nameof(LanguageCode)}.{enumValue}, \" {enumValue.ToString().ToLower()} \" }},");
}

var r = sb.ToString();

Console.ReadLine();
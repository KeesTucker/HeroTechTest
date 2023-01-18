using HeroTechTest.Enums;

namespace HeroTechTest;

public static class Parsers
{
    // Should grab this dynamically through terminal or somthing
    private const string  _MOE_ETHNIC_CODES_PATH = @"D:\_projects\C#\HeroTechTestData\moe-ethnic-codes.csv";

    private static readonly Dictionary<string, string> _moeCodeMap = new();

    public static void Init()
    {
        var csv = File.ReadAllLines(_MOE_ETHNIC_CODES_PATH);

        // should really make a generic csv deserializer and reuse it. dont have time
        foreach (var row in csv)
        {
            var cells = row.Split(",");

            _moeCodeMap.Add(cells[1], cells[0]);
        }
    }
    
    public static DateTime ParseDate(string date)
    {
        // stub
        // DateTime.Parse(date);
        return new DateTime();
    }
    
    public static Gender ParseGender(string gender)
    {
        // stub
        return Gender.F;
    }
    
    public static bool ParseCurrentStudent(string formerStudent)
    {
        // stub
        return true;
    }

    public static string ParsePostCode(string postcode)
    {
        // stub
        return "";
    }
    
    // o boi, these are seperated with commas as well
    // next time i would use a CSV parser library
    // i didn't this time because I am unfamilar with CsvHelper and didn't want it to slow me down.
    public static string[] ParseMoeCodes(string ethnicities)
    {
        // this is where i was at at the one hour mark.
        var 
        
        var ethnicityList = ethnicities.Split(",");
        
        foreach (var ethnicity in ethnicityList)
        {
            _moeCodeMap[ethnicity]
        }
        
        // stub
        return Array.Empty<string>();
    }
}
using HeroTechTest.Enums;
using HeroTechTest.Models;

namespace HeroTechTest;

public static class Parsers
{
    // Should grab this dynamically through terminal or somthing
    private const string  _MOE_ETHNIC_CODES_PATH = @"D:\_projects\C#\HeroTechTestData\moe-ethnic-codes.csv";

    private static Dictionary<string, string> _moeCodeMap = new();

    public static void Init()
    {
        var csv = File.ReadAllLines(_MOE_ETHNIC_CODES_PATH);

        // should really make a generic csv deserializer and reuse it. dont have time
        foreach (var row in csv)
        {
            var cells = row.Split(",");

            _moeCodeMap.Add(cells[0], cells[1]);
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
    
    public static string[] ParseMoeCodes(string ethnicities)
    {
        foreach (var ethnicity in ethnicities)
        {
            
        }
        
        // stub
        return Array.Empty<string>();
    }
}
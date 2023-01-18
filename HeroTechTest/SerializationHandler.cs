using HeroTechTest.Models;
using Newtonsoft.Json;

namespace HeroTechTest;

public static class SerializationHandler
{
    public static List<StudentData> DeserializeStudentCsv(string[] csvData)
    {
        // This is a bit jank, should read the column index by matching column headers or something like that
        
        var studentsData = csvData.Select(row => row.Split(","))
            .Select(cells => new StudentData
            {
                HeroId = Guid.NewGuid(),
                Name = $"{cells[0]} {cells[1]}",
                Dob = Parsers.ParseDate(cells[8]),
                Gender = Parsers.ParseGender(cells[9]),
                CurrentStudent = Parsers.ParseCurrentStudent(cells[36]),
                Addr1 = cells[2],
                Addr2 = cells[3],
                Addr3 = cells[4],
                Addr4 = Parsers.ParsePostCode(cells[5]),
                Ethnicities = Parsers.ParseMoeCodes(cells[10]),
                Cg1Phone = cells[14],
                Cg1Sms = cells[14],
                Cg2Phone = cells[22],
                Cg2Sms = cells[22],
            })
            .ToList();

        return studentsData;
    }

    public static string SerializeToJson(List<StudentData> studentsData) => JsonConvert.SerializeObject(studentsData);
}
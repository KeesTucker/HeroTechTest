namespace HeroTechTest;

public static class Program
{
    private static string? _path;
    
    private static void Main(string[] args)
    {
        Parsers.Init();
        
        GetPath();

        var csvData = ReadCsv();
        
        var studentsData = SerializationHandler.DeserializeStudentCsv(csvData);

        var jsonString = SerializationHandler.SerializeToJson(studentsData);
        
        WriteToFile(jsonString);
    }

    private static void GetPath()
    {
        while (string.IsNullOrEmpty(_path))
        {
            Console.WriteLine("Please enter the path to the data you wish to process: ");
            _path = Console.ReadLine();
            Console.WriteLine(string.IsNullOrEmpty(_path) ? "You did not enter a path. Please try again." : $"Chosen path: {_path}");
        }
        // TODO: Should do a check for valid path. More error checking
    }

    private static string[] ReadCsv() => File.ReadAllLines(_path!);

    private static void WriteToFile(string jsonData) => File.WriteAllText($"{_path}.JSON", jsonData);
}
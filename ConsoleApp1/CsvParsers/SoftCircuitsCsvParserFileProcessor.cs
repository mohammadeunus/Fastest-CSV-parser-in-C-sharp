using Fastest_CSV_parser.Interface;
using SoftCircuits.CsvParser;

namespace Fastest_CSV_parser.CsvParsers;

internal class SoftCircuitsCsvParserFileProcessor : IBaseProcessor
{
    // reference code: https://github.com/SoftCircuits/CsvParser
    public void ProcessCsvFile(string inputFilePath, string outputFilePath)
    {
        // Read the data from inputFilePath
        using CsvReader reader = new(inputFilePath);

        // write the data at outputFilePath
        using (var writer = new StreamWriter(outputFilePath))
        { 
            // Read data 
            while ((reader.Read()) != false)
            {
                string? column1Index = reader.Columns?[0];
                string? column2OrganizationId = reader.Columns?[1];
                string? column3Name = reader.Columns?[2];
                string? column4Website = reader.Columns?[3];
                string? column5Country = reader.Columns?[4];
                string? column6Description = reader.Columns?[5];
                string? column7Founded = reader.Columns?[6];
                string? column8Industry = reader.Columns?[7];
                string? column9NofEmployee = reader.Columns?[8];

                // Format the data as needed and write it to the output file.
                string formattedData = $"Index: {column1Index}, Organization id: {column2OrganizationId}, Name: {column3Name}, " +
                    $"Website: {column4Website}, Country: {column5Country}, Description: {column6Description}, Founded: {column7Founded}, " +
                    $"Industry: {column8Industry}, NofEmployee: {column9NofEmployee}";
                // Write the formatted data to the output file.
                writer.WriteLine(formattedData);
            }
                
        }
    }
} 
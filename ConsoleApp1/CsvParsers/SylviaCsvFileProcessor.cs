using Fastest_CSV_parser.Interface;
using Sylvan.Data.Csv;

namespace Fastest_CSV_parser.CsvParsers;

public class SylviaCsvFileProcessor : IBaseProcessor
{
    public void ProcessCsvFile(string filePath, string outputFilePath)
    {
        // Configure options (e.g., delimiter, encoding, etc.).
        var options = new CsvDataReaderOptions
        {
            // Tells Sylvan to split the CSV file into columns based on commas
            Delimiter = ',',
        };

        using (var reader = CsvDataReader.Create(filePath, options))

        // Create a StreamWriter for writing to the output file
        using (var writer = new StreamWriter(outputFilePath))
        {
            // Read and process the CSV data row by row.
            while (reader.Read())
            {
                // Access data by column index or column name.
                string column1Index = reader.GetString(0);
                string column2OrganizationId = reader.GetString(1);
                string column3Name = reader.GetString(2);
                string column4Website = reader.GetString(3);
                string column5Country = reader.GetString(4);
                string column6Description = reader.GetString(5);
                string column7Founded = reader.GetString(6);
                string column8Industry = reader.GetString(7);
                string column9NofEmployee = reader.GetString(8);

                // Format the data as needed and write it to the output file
                string formattedData = $"Index: {column1Index}, Organization id: {column2OrganizationId}, Name: {column3Name}, Website: {column4Website}, Country: {column5Country}, Description: {column6Description}, Founded: {column7Founded}, Industry: {column8Industry}, NofEmployee: {column9NofEmployee}";

                // Write the formatted data to the output file
                writer.WriteLine(formattedData);
            }
        }
    }
}

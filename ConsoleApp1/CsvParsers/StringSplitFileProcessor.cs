using System;
using System.IO;
using Fastest_CSV_parser.Interface;

namespace Fastest_CSV_parser.CsvParsers;

public class StringSplitFileProcessor : IBaseProcessor
{
    public void ProcessCsvFile(string filePath, string outputFilePath)
    {
        char delimiter = ','; // Assuming the delimiter in your CSV file is a comma.

        using var reader = new StreamReader(filePath);
        using var writer = new StreamWriter(outputFilePath);
        // Read and process the CSV data row by row.
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();

            if (string.IsNullOrWhiteSpace(line))
            {
                continue; // Skip empty lines.
            }

            // Split the line into columns based on the delimiter.
            string[] columns = line.Split(delimiter);

            if (columns.Length < 9)
            {
                // Handle cases where the CSV file does not have enough columns.
                Console.WriteLine($"Invalid line: {line}");
                continue;
            }

            // Access data by index for each column.
            string column1Index = columns[0];
            string column2OrganizationId = columns[1];
            string column3Name = columns[2];
            string column4Website = columns[3];
            string column5Country = columns[4];
            string column6Description = columns[5];
            string column7Founded = columns[6];
            string column8Industry = columns[7];
            string column9NofEmployee = columns[8];

            // Format the data as needed and write it to the output file.
            string formattedData = $"Index: {column1Index}, Organization id: {column2OrganizationId}, Name: {column3Name}, Website: {column4Website}, Country: {column5Country}, Description: {column6Description}, Founded: {column7Founded}, Industry: {column8Industry}, NofEmployee: {column9NofEmployee}";

            // Write the formatted data to the output file.
            writer.WriteLine(formattedData);
        }
    }
}

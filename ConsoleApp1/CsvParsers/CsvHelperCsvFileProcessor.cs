using System;
using System.Globalization;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using Fastest_CSV_parser.Interface;

namespace Fastest_CSV_parser.CsvParsers;

public class CsvHelperCsvFileProcessor : IBaseProcessor
{
    // reference of this code : https://joshclose.github.io/CsvHelper/getting-started/#reading-a-csv-file
    public void ProcessCsvFile(string inputFilePath, string outputFilePath)
    {
        using (var reader = new StreamReader(inputFilePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        using (var writer = new StreamWriter(outputFilePath))
        {
            {
                csv.Context.RegisterClassMap<CsvRecordMap>();
                var data = csv.GetRecords<CsvRecord>();

                // Write the header row to the output file (optional). 

                foreach (var record in data)
                {
                    string column1Index = record.column1Index;
                    string column2OrganizationId = record.column2OrganizationId;
                    string column3Name = record.column3Name;
                    string column4Website = record.column4Website;
                    string column5Country = record.column5Country;
                    string column6Description = record.column6Description;
                    string column7Founded = record.column7Founded;
                    string column8Industry = record.column8Industry;
                    string column9NofEmployee = record.column9NofEmployee;


                    string formattedData = $"Index: {column1Index}, Organization id: {column2OrganizationId}, " +
                        $"Name: {column3Name}, Website: {column4Website}, Country: {column5Country}, Description: {column6Description}, " +
                        $"Founded: {column7Founded}, Industry: {column8Industry}, NofEmployee: {column9NofEmployee}";


                    // Write the formatted data to the output file
                    writer.WriteLine(formattedData);
                }
            }
        }
    }
    public class CsvRecordMap : ClassMap<CsvRecord>
    {
        public CsvRecordMap()
        {
            Map(m => m.column1Index).Name("Index");
            Map(m => m.column2OrganizationId).Name("Organization Id");
            Map(m => m.column3Name).Name("Name");
            Map(m => m.column4Website).Name("Website");
            Map(m => m.column5Country).Name("Country");
            Map(m => m.column6Description).Name("Description");
            Map(m => m.column7Founded).Name("Founded");
            Map(m => m.column8Industry).Name("Industry");
            Map(m => m.column9NofEmployee).Name("Number of employees");
        }
    }

    public class CsvRecord
    {
        public string column1Index { get; set; }
        public string column2OrganizationId { get; set; }
        public string column3Name { get; set; }

        public string column4Website { get; set; }
        public string column5Country { get; set; }
        public string column6Description { get; set; }

        public string column7Founded { get; set; }
        public string column8Industry { get; set; }
        public string column9NofEmployee { get; set; }
    }
}

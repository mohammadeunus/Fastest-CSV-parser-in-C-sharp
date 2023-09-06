using Fastest_CSV_parser.Interface;
using RecordParser.Builders.Reader;

namespace Fastest_CSV_parser.CsvParsers;

internal class RecordParserFileProcessor : IBaseProcessor
{
    // reference code : https://github.com/leandromoh/RecordParser
    public void ProcessCsvFile(string inputFilePath, string outputFilePath)
    {
        var recordParserReader = new VariableLengthReaderBuilder<(string column1, string column2, string column3, string column4, string column5, string column6, string column7, string column8, string column9)>()
        .Map(x => x.column1, indexColumn: 0)
        .Map(x => x.column2, indexColumn: 1)
        .Map(x => x.column3, indexColumn: 2)
        .Map(x => x.column4, indexColumn: 3)
        .Map(x => x.column5, indexColumn: 4)
        .Map(x => x.column6, indexColumn: 5)
        .Map(x => x.column7, indexColumn: 6)
        .Map(x => x.column8, indexColumn: 7)
        .Map(x => x.column9, indexColumn: 8)
        .Build(",");

        using (var reader = new StreamReader(inputFilePath))
        using (var writer = new StreamWriter(outputFilePath))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (string.IsNullOrWhiteSpace(line))
                {
                    continue; // Skip empty lines.
                }
                var result = recordParserReader.Parse(line);

                // Format the data as needed and write it to the output file.
                string formattedData = $"Index: {result.column1}, Organization id: {result.column2}, Name: {result.column3}, Website: {result.column4}, " +
                    $"Country: {result.column5}, Description: {result.column6}, Founded: {result.column7}, Industry: {result.column8}, NofEmployee: {result.column9}";

                // Write the formatted data to the output file.
                writer.WriteLine(formattedData);
            }
        }
    }
}

using Fastest_CSV_parser.CsvParsers;
using Fastest_CSV_parser;

//dictionary to store the processing time of each csv file parser
Dictionary<string, double> recordsOfCsvProcessing = new Dictionary<string, double>();

var SylviaCsvProcessingTime = new CalculateDuration().returnProcessingTime(new SylviaCsvFileProcessor());
recordsOfCsvProcessing.Add("sylvia", SylviaCsvProcessingTime);


var SoftCircuitsCsvParserProcessingTime = new CalculateDuration().returnProcessingTime(new SoftCircuitsCsvParserFileProcessor());
recordsOfCsvProcessing.Add("SoftCircuitsCsvParser", SoftCircuitsCsvParserProcessingTime);

var csvHelperProcessingTime = new CalculateDuration().returnProcessingTime(new CsvHelperCsvFileProcessor());
recordsOfCsvProcessing.Add("csvHelper", csvHelperProcessingTime);



var StringSplitProcessingTime = new CalculateDuration().returnProcessingTime(new StringSplitFileProcessor());
recordsOfCsvProcessing.Add("StringSplit", StringSplitProcessingTime);

var RecordParserProcessingTime = new CalculateDuration().returnProcessingTime(new RecordParserFileProcessor());
recordsOfCsvProcessing.Add("RecordParser", RecordParserProcessingTime);



foreach (KeyValuePair<string, double> ele1 in recordsOfCsvProcessing)
{
    Console.WriteLine($"{ele1.Key} takes {ele1.Value} second");
}

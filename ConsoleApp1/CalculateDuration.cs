using System.Diagnostics;
using Fastest_CSV_parser.Interface;

namespace Fastest_CSV_parser;

public class CalculateDuration
{
    public double returnProcessingTime(IBaseProcessor universalProcessor)
    {
        string filePath = "E:\\project\\csv file using c#\\organizations-2000000\\organizations-2000000.csv"; // Replace with the path to your CSV file.

        int randomNumber = new Random().Next(1, 2001);
        string outputFilePath = $"E:\\project\\csv file using c#\\organizations-2000000\\output{randomNumber}.txt"; // Replace with the path for the output file.

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        // Assuming the ProcessCsvFile method returns a double.
        universalProcessor.ProcessCsvFile(filePath, outputFilePath);

        stopwatch.Stop();

        return stopwatch.Elapsed.TotalSeconds;
    }
 
}

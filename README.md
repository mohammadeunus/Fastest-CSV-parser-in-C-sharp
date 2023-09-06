# CSV Parser Comparison

This project aims to compare the performance of various CSV parsers in C# by measuring the time it takes to process a CSV file. We have used five different CSV parsers: Sylvia, SoftCircuitsCsvParser, CsvHelper, StringSplit, and RecordParser. The goal is to find the fastest CSV parser for your specific use case.

## Methodology

We followed a similar pattern for each CSV parser:

1. Read the CSV file.
2. Process the CSV data.
3. Measure the time taken for processing.

The total processing time was calculated using a stopwatch, and the results were recorded in a dictionary.

## Results

Here are the processing times for each CSV parser (in seconds) based on multiple runs:

- **Sylvia CSV Parser**
    - Run 1: 2.8358982 seconds
    - Run 2: 2.792869 seconds
    - Run 3: 2.766634 seconds

- **SoftCircuits CSV Parser**
    - Run 1: 8.9534291 seconds
    - Run 2: 10.103374 seconds
    - Run 3: 8.2693004 seconds

- **CsvHelper**
    - Run 1: 4.7226823 seconds
    - Run 2: 4.7959622 seconds
    - Run 3: 5.4381193 seconds

- **StringSplit**
    - Run 1: 2.8989364 seconds
    - Run 2: 2.9491736 seconds
    - Run 3: 3.3129476 seconds

- **RecordParser**
    - Run 1: 3.3954582 seconds
    - Run 2: 4.4059097 seconds
    - Run 3: 3.824507 seconds

These results indicate that the "Sylvia CSV Parser" is consistently the fastest among the tested libraries, with the lowest processing times.

## Conclusion

Based on our tests, the "Sylvia CSV Parser" appears to be the fastest CSV parser for the provided use case. However, it's essential to consider other factors such as ease of use, features, and compatibility with your specific CSV data when choosing a CSV parser for your project.

Feel free to use the code provided in this repository to conduct your CSV parser performance tests and make an informed decision.
 

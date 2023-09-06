# CSV Parser Comparison

This project aims to determine the fastest CSV parser for a specific use case involving the processing of CSV files. It involves handling CSV files containing organizational data. The goal is to identify the most efficient CSV parser for this particular scenario.

## Use Case Details

**CSV Data:** The CSV files used in this comparison contain organizational data, including information such as organization IDs, names, websites, countries, descriptions, founding years, industries, and the number of employees.

**Processing Steps:** The common processing steps for each CSV parser include reading the CSV data, parsing it, and then creating a formatted text output file with the processed data.

**Performance Measurement:** To evaluate the performance of each CSV parser, the time taken to complete the processing of a sample CSV file is measured using the `Stopwatch` class. The results are collected and compared to determine which CSV parser performs the best for this specific use case.

The total processed time calculated using the stopwatch was then recorded in a dictionary.

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
 

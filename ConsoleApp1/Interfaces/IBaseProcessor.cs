using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastest_CSV_parser.Interface;

public interface IBaseProcessor
{
    void ProcessCsvFile(string inputFilePath, string outputFilePath);
}

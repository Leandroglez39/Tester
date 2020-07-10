using System;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace Tester
{
    class Program
    {
        private static void Main()
        {

            var reader = new StreamReader("C:\\Users\\Leo\\Desktop\\TraceAligment CSV Data\\CargaBDClassLibraryOK\\ConsoleApp1\\bin\\Debug\\EVENTO.csv");
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<CSV>().ToList();

            foreach (var x in records)
                Console.WriteLine(x.BOSS);
            Console.WriteLine();

        }
    }
}

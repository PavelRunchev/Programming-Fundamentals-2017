using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankReceipt
{
    class BlankReceipt
    {
        static void Main(string[] args)
        {
            PrintReceiptHeader();
            PrintReceipBody();
            PrintReceiptFooter();
        }

        private static void PrintReceiptFooter()
        {
            Console.WriteLine("{0}", new string('-', 30));
            Console.WriteLine("\u00A9" + " SoftUni");
        }

        private static void PrintReceipBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        private static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("{0}", new string('-', 30));
        }
    }
}

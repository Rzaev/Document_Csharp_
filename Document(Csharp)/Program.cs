using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Csharp_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1)BASIC\n2)PRO\n3)EXPERT");
            string select = Console.ReadLine();
            select = select.ToUpper();
            while (!(select is "BASIC" || select is "PRO"||select is "EXPERT"))
            {
                Console.WriteLine("Input again:");
                select = Console.ReadLine();
                select = select.ToUpper();
            }
            DocumentProgram docProgram;
            if (select=="BASIC")
            {
                docProgram = new DocumentProgram();
            }
            else if(select=="PRO")
            {
                docProgram = new ProDocumentProgram();
            }
            else
            {
                docProgram = new ExpertDocument();
            }
            docProgram.OpenDocument();
            docProgram.EditDocument();
            docProgram.SaveDocument();
        }
    }
}

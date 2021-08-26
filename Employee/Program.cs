using System;
using System.IO;

namespace Employee.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            LerArquivo arq = new LerArquivo();
            Employees list;
            try
            {
                list = arq.GetArquivo();
                
                list.GetEmployeeBySalary(2000.00);
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e);
            }
        }
    }
}

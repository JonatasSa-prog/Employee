using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Globalization;

namespace Employee.Entities
{


    class LerArquivo
    {
        string Path = @"C:\Users\jonatas.santos\Desktop\Teste3\Employee\Employees.txt";
        Employees list = new Employees();
        public Employees GetArquivo()
        {
            try
            {
                using (StreamReader sr = File.OpenText(Path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        string email = line[1];
                        double salary = double.Parse(line[2], CultureInfo.InvariantCulture);

                        list.AddEmployee(new Employee(name, email,salary));

                    }
                    return list;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            return null;
        }
    }
}


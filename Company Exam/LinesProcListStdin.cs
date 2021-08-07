using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgramNamespace
{
    //
    /* In C# 9.0, We can declare ApiInfo class with one line using "record" type */
    //
    //public record ApiInfo(string CompanyName, string ApiName, int ApiLevel);
    public class ApiInfo
    {
        public ApiInfo(string companyName, string apiName, int apiLevel)
        {
            this.CompanyName = companyName;
            this.ApiLevel = apiLevel;
            this.ApiName = apiName;
        }

        public string CompanyName { get; private set; }
        public string ApiName { get; private set; }
        public int ApiLevel { get; private set; }
    }

    public class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                String line;
                var inputLines = new List<String>();
                while ((line = Console.ReadLine()) != null)
                {
                    line = line.Trim();
                    if (line != "")
                        inputLines.Add(line);
                }
                
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

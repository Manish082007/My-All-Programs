//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

///* Don't change anything here.
// * Do not add any other imports. You need to write
// * this program using only these libraries 
// */

//namespace ProgramNamespace
//{
//  /* You may add helper classes here if necessary */
//  public record ApiInfo(string CompanyName, string ApiName, int ApiLevel);

//  public class Program
//  {
//    public static IList<string> processData(
//                                    IEnumerable<string> lines)
//    {
//      List<ApiInfo> allApiInfo = new();
      
//      foreach (string line in lines)
//      {
//        string[] info = line.Split(',');

//        string companyName = info[0];
//        string apiName = info[2].TrimStart();
//        int apiLevel = int.Parse(info[3].Replace(" Level ", ""));

//        allApiInfo.Add(new ApiInfo(companyName, apiName, apiLevel));
//      }

//      List<string> result = new();

//      allApiInfo
//        .GroupBy(x => x.ApiName, x => new { x.CompanyName, x.ApiLevel })
//        .Where(x => x.ToList().Count() > 1)
//        .ToList()
//        .ForEach(x => {
//          result.Add(x.OrderBy(x => x.ApiLevel).First().CompanyName);
//        });

//      return result;
//    }

//    static void Main(string[] args)
//    {
//      try
//      {
//        String line;
//        var inputLines = new List<String>();

//        inputLines.Add("RP Solutions, Australia, Cloud Telephony, Level 7");
//        inputLines.Add("Marketrac Inc, Baharain, Machine Learning, Level 9");
//        inputLines.Add("RP Solutions, Australia, Machine Learning, Level 10");
//        inputLines.Add("NewScore, Baharain, Auth API, Level 5");
//        inputLines.Add("Sun Fintech, Sweden, Auth API, Level 6");
//        inputLines.Add("RG.com, Australia, Email API, Level 10");
//        inputLines.Add("RP Solutions, Sweden, Auth API, Level 6");
//        inputLines.Add("RP Solutions, Australia, Storage, Level 3");
//        inputLines.Add("FPRP Solutions, Baharain, Storage, Level 2");
//        inputLines.Add("NewScore, Baharain, Storage, Level 4");
//        inputLines.Add("Marketrac Inc, Baharain, Storage, Level 3");

//        //while ((line = Console.ReadLine()) != null)
//        //{
//        //  line = line.Trim();
//        //  if (line != "")
//        //    inputLines.Add(line);
//        //}
//        var retVal = processData(inputLines);
//        foreach (var res in retVal)
//          Console.WriteLine(res);
//      }
//      catch (IOException ex)
//      {
//        Console.WriteLine(ex.Message);
//      }
//    }

//  }
//}

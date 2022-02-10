using OSIsoft.AF;
using OSIsoft.AF.Time;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFUtility01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PISystems piSystems = new PISystems();
            var piSystem = piSystems["Gary-VM2.dev.osisoft.int"];
            var analysisService = piSystem.AnalysisService;

            Console.WriteLine("Analysis Service Hostname: {0}", analysisService.Host);
            Console.WriteLine("");

            string query = "lastLag :> 5000";
            string fields = "id name lastLag lastTriggerTime";

            var results = analysisService.QueryRuntimeInformation(query, fields);

            //let's try to make a super dump version of getting first 5 analyses, because foreach still doesn't work
            Console.WriteLine($"First 5 Analyses with {query}");
            Console.WriteLine("");

            Console.WriteLine($"{fields}:");
            var firstAnalysis = results.ElementAt(0);
            Console.WriteLine($"{(Guid)firstAnalysis[0]}, {(string)firstAnalysis[1]}, {(double)firstAnalysis[2]}, {(AFTime)firstAnalysis[3]}");
            var secondAnalysis = results.ElementAt(1);
            Console.WriteLine($"{(Guid)secondAnalysis[0]}, {(string)secondAnalysis[1]}, {(double)secondAnalysis[2]}, {(AFTime)secondAnalysis[3]}");
            var thirdAnalysis = results.ElementAt(2);
            Console.WriteLine($"{(Guid)thirdAnalysis[0]}, {(string)thirdAnalysis[1]}, {(double)thirdAnalysis[2]}, {(AFTime)thirdAnalysis[3]}");
            var fourthAnalysis = results.ElementAt(3);
            Console.WriteLine($"{(Guid)fourthAnalysis[0]}, {(string)fourthAnalysis[1]}, {(double)fourthAnalysis[2]}, {(AFTime)fourthAnalysis[3]}");
            var fifthAnalysis = results.ElementAt(4);
            Console.WriteLine($"{(Guid)fifthAnalysis[0]}, {(string)fifthAnalysis[1]}, {(double)fifthAnalysis[2]}, {(AFTime)fifthAnalysis[3]}");

            //foreach (var result in results)
            //{
            //    var analysis = result.ElementAt(0);
            //    Console.WriteLine($"{(Guid)analysis[0]}, {(double)analysis[1]}, {(AFTime)analysis[2]}");
            //}

            //ReadLine so it doesn't auto close
            Console.ReadLine();
        }
    }
}

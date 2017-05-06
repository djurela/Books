using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cohort1 = new string[]{"Rachel", "Gareth", "Jonathan", "George"};
            var cohort2 = new string[]{"Jack", "Stephen", "Daniel", "Jack", "Jared"};
            var cohort3 = new string[]{"Declan", "Jack", "Jack", "Jasmine", "Conor"};
            
            Output(cohort1, "Cohort 1");
            Output(cohort2, "Cohort 2");
            Output(cohort3, "Cohort 3");
            WriteLine();

            Output(cohort2.Distinct(), "cohort2.Distinct()");
            Output(cohort2.Union(cohort3), "cohort2.Union(cohort3)");
            Output(cohort2.Concat(cohort3), "cohort2.Concat(cohort3)");
            Output(cohort2.Intersect(cohort3), "cohort2.Intersect(cohort3)");
            Output(cohort2.Except(cohort3), "cohort2.Except(cohort3)");
            Output(cohort1.Zip(cohort2, (c1, c2) => $"{c1} matches with {c2}"), "cohort1.Zip(cohort2, (c1, c2) => $\"{c1} matches with {c2}\")");
        }

        private static void Output(IEnumerable<string> cohort, string description = "")
        {
            WriteLine(description);
            WriteLine(String.Join(", ", cohort.ToArray()));
        }
    }
}

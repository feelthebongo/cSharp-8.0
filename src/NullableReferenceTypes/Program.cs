using System;
using System.Collections.Generic;

#nullable enable
namespace NullableReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var candidates = Service.GetCandidates();
            var names = GetNames(candidates);

            foreach (var name in names)
            {
                Console.WriteLine($"{name} has been added to CVDB");
            }

            Console.ReadKey();
        }

        static IEnumerable<string> GetNames(IEnumerable<Candidate> candidates)
        {
            foreach (var candidate in candidates)
            {
                yield return $"{candidate.FirstName} {candidate.MiddleName} {candidate.LastName} {candidate.Applications.Count}";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncStreams
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var candidates = GetCandidatesAsync();
            var names = GetNamesAsync(candidates);

            await foreach (var name in names)
            {
                Console.WriteLine($"{name} has been added to CVDB");
            }

            Console.ReadKey();
        }

        static async IAsyncEnumerable<string> GetNamesAsync(IAsyncEnumerable<Candidate> candidates)
        {
            await foreach (var candidate in candidates)
            {
                yield return $"{candidate.FirstName} {candidate.MiddleName} {candidate.LastName} {candidate.Applications.Count}";
            }
        }

        static async IAsyncEnumerable<Candidate> GetCandidatesAsync()
        {
            foreach (var candidate in Service.GetCandidates())
            {
                await Task.Delay(100);
                yield return candidate;
            }
        }
    }
}
